using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject
{
    internal class CampingTripShoping
    {
        public static int GetSavedSteps(string[][] products, string[] shopingList)
        {
            Dictionary<string, string> productsDic = new Dictionary<string, string>();

            for (int i = 0; i < products.Length; i++)
            {
                productsDic.Add(products[i][0], products[i][1]);
            }

            int savedTime = 0;

            List<string> departmentsPath = new List<string>();

            string dep = "";

            foreach (string shopingItem in shopingList)
            {
                foreach (var product in productsDic)
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