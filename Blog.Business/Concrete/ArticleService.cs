using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Blog.Business.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleService(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void Add(Article article)
        {
            article.CreatedDate = DateTime.Now;
            _articleDal.Add(article);
        }

        public void Create(Article article)
        {
            _articleDal.Add(article);
        }

        public void Delete(int id)
        {
            Article article = _articleDal.GetById(id);
            _articleDal.Delete(article);
        }
        public void Update(Article article)
        {
            _articleDal.Update(article);
        }
        public List<Article> GetAll()
        {
            return _articleDal.GetAll();
        }

        public List<Article> GetByAuthor(string author)
        {
            var result = _articleDal.GetByAuthor(author);
            return result;
        }

        public Article GetById(int id)
        {
            return _articleDal.GetById(id);
        }


    }
}
