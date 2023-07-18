using conclase_academy_api_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conclase_academy_api_2.services
{
    public class consumer : iconsumer
    {
        public ioperationtransient _operationtransientprop { get; set; }

        public Guid operationId => throw new NotImplementedException();

        public consumer(ioperationtransient operationprop)
        {
            _operationtransientprop = operationprop;

            var guidinconsumer = operationprop.operationId;

            Console.WriteLine($"guid in consumer service is: {operationprop.operationId}");
        }
    }
}
