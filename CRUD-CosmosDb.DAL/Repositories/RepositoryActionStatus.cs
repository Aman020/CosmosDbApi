using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CosmosDb.DAL.Repositories
{
    public enum RepositoryActionStatus
    {

        Ok,
        Created,
        Updated,
        NotFound,
        Deleted
       
    }
}
