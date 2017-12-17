using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDomainLogic
{
    public class PositionPrototypesConfigurator
    {
        private static PositionPrototypesConfigurator configure;
        private PositionPrototypesConfigurator() {
            InitAALP();
            InitEPAM();
            InitWithoutDates();
            InitWithSpecialSymbols();
        }
        public static PositionPrototypesConfigurator Configure
        {
            get
            {
                if (configure == null)
                {
                    configure = new PositionPrototypesConfigurator();
                }
                return configure;
            }
        }

        private void InitAALP() {
            var obj = PositionModelPrototypeMultiton.GetPosition(PositionModelTypes.AAPL);
            obj.Symbol = "AAPL";
        }
        private void InitEPAM()
        {
            var obj = PositionModelPrototypeMultiton.GetPosition(PositionModelTypes.EPAM);
            obj.Symbol = "EPAM";
        }
        private void InitWithoutDates()
        {
            var obj = PositionModelPrototypeMultiton.GetPosition(PositionModelTypes.WithoutDates);
            obj.InitDate = null;
        }
        private void InitWithSpecialSymbols()
        {
            var obj = PositionModelPrototypeMultiton.GetPosition(PositionModelTypes.WithSpecialSymbols);
            obj.Symbol = "@$#$!^@%#&$**%&*(&\"";
        }
    }
    public enum PositionModelTypes
    {
        AAPL,
        EPAM,
        WithoutDates,
        WithSpecialSymbols
    }
}
