using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDomainLogic
{
    public sealed class PositionModelPrototypeMultiton
    {
        private static readonly ConcurrentDictionary<PositionModelTypes, PositionModelPrototype> _instances = new ConcurrentDictionary<PositionModelTypes, PositionModelPrototype>();
        private PositionModelPrototypeMultiton() {
            var config = PositionPrototypesConfigurator.Configure;
        }
        public static PositionModelPrototype GetPosition(PositionModelTypes key)
        {
            return _instances.GetOrAdd(key, (x) => new PositionModelPrototype());
        }
    }

    public class PositionModelPrototype{
        public string Id { get; set; }
        public string Symbol { get; set; } = "AAPL";
        public string InitDate { get; set; } = "10/10/2010";
        public string Period { get; set; } = "100";

        public  PositionModelPrototype Clone()
        {
            return (PositionModelPrototype)MemberwiseClone();
        }
    }
}
