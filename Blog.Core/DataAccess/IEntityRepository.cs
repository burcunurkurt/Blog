using Blog.Core.Entities;

namespace Blog.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {

    }
}
