using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumDomainLogic;
using System.Threading;
using SeleniumFramework.Base;
using System.Linq;
using System.Collections.Generic;
using SeleniumDomainLogic.Actions;
using SeleniumDomainLogic.Actions.PreconditionStrategy;

namespace SeleniumBasic
{
    [TestClass]
    public class UnitTest1:BaseTest
    {
        private PositionModelPrototype model1;
        private PositionModelPrototype model2;
        [TestInitialize]
        public void Init() {
            model1 = PositionModelPrototypeMultiton.GetPosition(PositionModelTypes.AAPL).Clone();
            model1.Period = "567";

            model2 = PositionModelPrototypeMultiton.GetPosition(PositionModelTypes.AAPL);
        }
        [TestMethod]
        public void TestMethod1()
        {
            var preconditionActions = new PreconditionActions(new UIActions());
            preconditionActions.CreatePosition(model1);
            preconditionActions.SetActionType(new DBActions());
            preconditionActions.CreatePosition(model2);

            var mainForm = new MainForm(true);
            var results = mainForm.searchBox
                .Search("123")
                .GetResults();

            Assert.IsTrue(results.SequenceEqual(new List<string> { "", "result" }),"results are not as expected");
        }
    }
}
