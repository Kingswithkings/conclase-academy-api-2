using conclase_academy_api_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conclase_academy_api_2.services
{
    public class products : iproductiontransient
    {
        Guid _guid;

        public products()
        {
            _guid = Guid.NewGuid();
        }

        public Guid productsId => _guid;

        public Guid operationId => throw new NotImplementedException();
    }
}
