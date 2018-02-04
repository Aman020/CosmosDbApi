using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CosmosDb.DAL.Repositories
{
    public interface IRepository<T> where T:class
    {
        RepositoryActionResult<T> RetrieveEntities(Expression<Func<T, bool>> evalPredicate = null);
        RepositoryActionResult<T> RetrieveEntityByID(int id);
        RepositoryActionResult<T> InsertEntity(T entity);
        RepositoryActionResult<T> UpdateEntity(T updatedEntity);
        RepositoryActionResult<T> DeleteEntity(T deletedEntity);


    }
}
