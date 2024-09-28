using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Blog.DataAccess.Abstract
{
    public interface IArticleDal
    {
        List<Article> GetAll();
        Article GetById(int id);
        List<Article> GeyByCreatedDate(DateTime createdDate);
        List<Article> GetByAuthor(string author);
        void Add(Article article);
        void Delete(Article article);
        void Update(Article article);   

    }
}
