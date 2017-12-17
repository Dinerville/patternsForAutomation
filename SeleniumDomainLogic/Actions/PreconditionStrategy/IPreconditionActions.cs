using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDomainLogic.Actions.PreconditionStrategy
{
    public interface IPreconditionActions
    {
        void CreatePosition(PositionModelPrototype model);
    }
}
