using SeleniumDomainLogic.Actions.PreconditionStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDomainLogic.Actions
{
    public class PreconditionActions: IPreconditionActions
    {
        private List<string> _list = new List<string>();
        private IPreconditionActions _preconditionActions;

        public PreconditionActions(IPreconditionActions preconditionActions)
        {
            _preconditionActions = preconditionActions;
        }
        public void SetActionType(IPreconditionActions preconditionActions) {
            _preconditionActions = preconditionActions;
        }
        public void CreatePosition(PositionModelPrototype model)
        {
            _preconditionActions.CreatePosition(model);
        }    
    }
}
