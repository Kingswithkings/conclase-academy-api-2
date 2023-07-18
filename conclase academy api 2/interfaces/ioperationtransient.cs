using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conclase_academy_api_2.interfaces
{
    public interface ioperation
    {
        Guid operationId { get; }
    }

    public interface ioperationtransient : ioperation
    {
    }
}
