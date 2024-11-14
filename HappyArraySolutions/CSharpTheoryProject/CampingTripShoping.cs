using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject
{
    internal class CampingTripShoping
    {
        public static int SaveShopingTime(Dictionary<string, string> products, List<string> shopingList)
        {
            int savedTime = 0;

            List<string> departmentsPath = new List<string>();

            string dep = "";

            foreach (string shopingItem in shopingList)
            {
                foreach (var product in products)
                {
                    if (shopingItem == product.Key && dep != product.Value)
                    {
                        departmentsPath.Add(product.Value);
                        dep = product.Value;
                        break;
                    }
                }
            }

            HashSet<string> departmentsAmount = new HashSet<string>(departmentsPath);

            savedTime = departmentsPath.Count - departmentsAmount.Count;

            return savedTime;
        }
    }
}
