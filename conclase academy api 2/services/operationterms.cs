using conclase_academy_api_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conclase_academy_api_2.services
{
    public class operationterms : ioperationalscoped
    {
        Guid _guid;

        public operationterms()
        {

            _guid = Guid.NewGuid();

        }

        public Guid operationalId => _guid;

        public object operationId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
