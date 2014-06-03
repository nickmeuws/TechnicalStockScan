using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TechnicalStockScan
{
    internal class Resources
    {
        static System.Resources.ResourceManager m_rmNameValues;

        static Resources()
        {
            m_rmNameValues = new System.Resources.ResourceManager(
                "TechnicalStockScan.Resources", typeof(Resources).Assembly);
        }

        public static string GetString(string name)
        {
            return m_rmNameValues.GetString(name);
        }
    }
}
