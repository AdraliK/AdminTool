using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTool2
{
    public class OutletStats
    {
        public int countSummary, lastCountSummary, lastNowCountSummary;
        public double proceedsSummary, lastProceedsSummary, lastNowProceedsSummary;
        public Dictionary<string, Product> outlet = new Dictionary<string, Product>();

        public class Product
        {
            public int count { get; set; }
            public double proceeds { get; set; }
        }

        public void Add(string nameCompany, int count, int proceeds)
        {
            if (!outlet.ContainsKey(nameCompany))
            {
                outlet.Add(nameCompany, new Product() { count = count, proceeds = proceeds });
            }
            else 
            {
                outlet[nameCompany].proceeds += proceeds;
                outlet[nameCompany].count += count;
            }
        }

        public void SortOutlet()
        {
            var temp = from entry in outlet orderby entry.Value.proceeds descending select entry;
            outlet = temp.ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
