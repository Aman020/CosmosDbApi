using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CosmosDb.DAL.Repositories
{
    public class RepositoryActionResult<T> where T:class
    {
        public T Entity { get; private set; }

        public RepositoryActionStatus Status { get; private set; }

        public Exception Exception { get; set; }


        public RepositoryActionResult(T Entity, RepositoryActionStatus Status )
        {
            this.Entity = Entity;
            this.Status = Status;
        }

        public RepositoryActionResult(T Entity , RepositoryActionStatus Status, Exception Exception)
        : this(Entity,Status)

        {
           
            this.Exception = Exception;
                
        }

    }
}
