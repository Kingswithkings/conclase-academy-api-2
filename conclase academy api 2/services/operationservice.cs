using conclase_academy_api_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conclase_academy_api_2.services
{
    public class operationservice : ioperationtransient
    {
        Guid guid;

        public operationservice()
        {
            guid = Guid.NewGuid();
        }
                public Guid operationId => guid;
    }

}
