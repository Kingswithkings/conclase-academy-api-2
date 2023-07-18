using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conclase_academy_api_2.interfaces
{
   public interface iuniversal
    {
        Guid operationId { get; }
    }
    public interface iuniversaltransient : iuniversal { }
}
