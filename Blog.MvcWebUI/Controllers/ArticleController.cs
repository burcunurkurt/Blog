using Blog.Business.Abstract;
using Blog.Entities.Concrete;
using Blog.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.MvcWebUI.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public ActionResult Index()
        {
            var articles=_articleService.GetAll();
            ArticleListViewModel model = new ArticleListViewModel
            {
                Articles = articles
            };
            return View(model);
        }

        public ActionResult Add()
        {
            var model = new ArticleAddViewModel()
            {
                Article= new Article()

            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Article article)
        {
            if (ModelState.IsValid)
            {
               
                _articleService.Add(article);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var model = new ArticleUpdateViewModel
            {
                Article = _articleService.GetById(id)
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Article article)
        {
            if (ModelState.IsValid)
            {
                _articleService.Update(article);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _articleService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult GetByAuthor(ArticleSearchModel searchModel)
        {
            var articles = _articleService.GetByAuthor(searchModel.Author);
            ArticleListViewModel model = new ArticleListViewModel()
            {
                Articles = articles 
            };
            return Json(model);
        }


    }
}
