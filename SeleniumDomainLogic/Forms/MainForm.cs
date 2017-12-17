using SeleniumDomainLogic.Elements;
using SeleniumFramework.Base;
using SeleniumFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDomainLogic
{
    public class MainForm : BaseForm
    {
        public MainForm(bool directNavigation = false) : base(Locators.MainForm.TitleLocator,"",navigate:directNavigation)
        {
        }
        public SearchBox searchBox = new SearchBox();
        public void DoLove() { }
    }
}
