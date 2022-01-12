using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routine.Services
{
    public class PropertyMappingValue 
    { 
        public IEnumerable<string> DestinationProperties { get; set; }
        public bool Revert { get; set; }
        public PropertyMappingValue(IEnumerable<string> destinationProperties, bool revert = false)
        {
            Revert = revert;
            DestinationProperties = destinationProperties ?? throw new ArgumentNullException(nameof(destinationProperties));
        }
    }
}
