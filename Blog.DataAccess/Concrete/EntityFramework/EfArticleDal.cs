using Blog.Core.DataAccess.EntityFramework;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EfEntityRepositoryBase<Article, BlogContext>, IArticleDal
    {
        public List<Article> GetAll()
        {
            return GetList();
        }

        public List<Article> GetByAuthor(string author)
        {
            Expression<Func<Article, bool>> filter = p => p.Author.Contains(author);
            return GetList(filter);
        }

        public Article GetById(int id)
        {
            Expression<Func<Article, bool>> filter = p => p.Id == id;
            return Get(filter);
        }

        public List<Article> GeyByCreatedDate(DateTime createdDate)
        {
            Expression<Func<Article, bool>> filter = p => p.CreatedDate == createdDate;
            return GetList(filter);
        }
    }
}
