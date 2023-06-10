using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTool2
{
    public class Table
    {
        public class Product
        {

            public int row = 0;
            public string nameProvider;
            public int price;
            public int count = 0;

            public Product(string nameProvider, int price, int count)
            {
                this.nameProvider = nameProvider;
                this.price = price;
                this.count = count;
            }

        }

        public class Prod
        {
            public int count;
            public bool color = false;

            public Prod(int count)
            {
                this.count = count;
            }
        }

        public Dictionary<string, Product> product = new Dictionary<string, Product>();
        public SortedDictionary<string, Color> colorMapCompany = new SortedDictionary<string, Color>();
        public Dictionary<string, Color> colorMapProduct = new Dictionary<string, Color>();
        public SortedDictionary<string, Dictionary<string, Prod>> company = new SortedDictionary<string, Dictionary<string, Prod>>();

    }
}
