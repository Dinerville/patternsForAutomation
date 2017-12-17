using SeleniumDomainLogic.Forms;
using SeleniumFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDomainLogic.Elements
{
    public class SearchBox:BaseElement
    {
        public SearchBox() : base("//*[@id='ggl']")
        {
        }
        public ResultsForm Search(string text) {
            
            return new ResultsForm();
        }
    }
}
