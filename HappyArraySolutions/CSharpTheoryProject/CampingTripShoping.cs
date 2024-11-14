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

        //public static int ShopingTimeDiff(List<string[]> products, List<string> shopingList)
        //{
        //    int savedTime = 0;

        //    var sortedProducts = SortProducts(products);

        //    List<string> departmentsPath = new List<string>();

        //    for (int i = 0; i < shopingList.Count; i++)
        //    {
        //        for (int j = 0; j < sortedProducts.Count; j++)
        //        {
        //        }
        //    }


        // створити ліст - відділи по шопінглисту
        // стоврити хешсет - вибрати тільки унікальні назви відділів
        // повернути різницю - ліст - хешсет = це те, скільки ми зекономимо кроків

        //    return savedTime; 
        //}

        //public static List<string> DepartmentsPath(List<string> shopingList, Dictionary<string, List<string>> sortedProducts)
        //{
        //    List<string> result = new List<string>();
        //    string dep = "";

        //    for (int i = 0; i < shopingList.Count; i++)
        //    {
        //        foreach (var item in sortedProducts)
        //        {

        //            foreach (var value in item.Value)
        //            {
        //                if (shopingList[i] == value & dep != item.Key)
        //                {
        //                    result.Add(item.Key);
        //                    dep = item.Key;
        //                }
        //            }
        //        }
        //    }
        //    return result;
        //}
        //public static int CoutnDepartments(List<string> shopingList, Dictionary<string, List<string>> sortedProducts)
        //{
        //    int countDepartments = 0;
        //    string dep = "";

        //    for (int i = 0; i < shopingList.Count; i++)
        //    {
        //        foreach (var item in sortedProducts)
        //        {

        //            foreach (var value in item.Value)
        //            {
        //                if (shopingList[i] == value & dep != item.Key)
        //                {
        //                    countDepartments++;
        //                    dep = item.Key;
        //                }
        //            }
        //        }
        //    }
        //    return countDepartments;
        //}

        //public static Dictionary<string, List<string>> SortProducts(List<string[]> products)
        //{
        //    Dictionary<string, List<string>> productsDic = new Dictionary<string, List<string>>();

        //    for (int i = 0; i < products.Count; i++)
        //    {
        //        if (productsDic.ContainsKey(products[i][1]))
        //        {
        //            productsDic[products[i][1]].Add(products[i][0]);
        //        }
        //        else
        //        {
        //            productsDic.Add(products[i][1], new List<string> { products[i][0] });
        //        }
        //    }
        //    return productsDic;
        //}

    }
}
