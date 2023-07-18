using conclase_academy_api_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conclase_academy_api_2.services
{
    public class universal : iuniversaltransient
    {
        Guid _guid;

        public universal()
        {
            _guid = Guid.NewGuid();
        }

        public Guid universalId => _guid;

        public Guid operationId => throw new NotImplementedException();
    }
}
