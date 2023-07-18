using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace conclase_academy_api_2.interfaces
{
    public interface iDatabaseHelper
    {
        public DataTable ExecuteQuerry(string querry);
    }
}
