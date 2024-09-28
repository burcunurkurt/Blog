using Blog.Entities.Concrete;
using System.Collections.Generic;

namespace Blog.Business.Abstract
{
    public interface IArticleService
    {
        void Add(Article article);
        void Create(Article article);
        void Update(Article article);
        void Delete(int id);
        List<Article> GetAll();
        List<Article> GetByAuthor(string author);
        Article GetById(int id);
    }
}
