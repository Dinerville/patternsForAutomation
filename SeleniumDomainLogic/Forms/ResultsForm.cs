using SeleniumFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDomainLogic.Forms
{
    public class ResultsForm: BaseForm
    {
        public ResultsForm(bool directNavigation = false) : base(Locators.ResultsForm.MainLocator,"/results",navigate:directNavigation)
        {
        }
        public List<string> GetResults(){
            return new List<string> { "", "result" };
        }
    }
}
