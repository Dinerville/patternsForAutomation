using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Extensions
{
    public class SRandom
    {
        private static Random instance;

        private SRandom() { }

        public static Random Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Random();
                }
                return instance;
            }
        }
    }
}
