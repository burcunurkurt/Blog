using Blog.Core.Entities;
using System;

namespace Blog.Entities.Concrete
{
    public class Article:IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }

    }
}
