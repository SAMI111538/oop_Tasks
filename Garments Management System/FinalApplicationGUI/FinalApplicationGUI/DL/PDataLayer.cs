using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalApplicationGUI.BL;

namespace FinalApplicationGUI.DL
{
    class PDataLayer//DataLAyer for the produccts
    {
        private static List<pro_duct> products = new List<pro_duct>();//Product lst for add the products in the list

        public static void addProduct(pro_duct F)//Funtion to Add products in the list
        {
            products.Add(F);
        }
        public static void RemoveParticularProduct(int index)//Funtion to Remove products in the list
        {
            products.RemoveAt(index);
        }
        public static List<pro_duct> getProducts()//Funtion to get product's list
        {
            return products;
        }
        public static List<pro_duct> sortByPrice()//Funtion to Sort products in the list by Price
        {
            List<pro_duct> temp = products.OrderByDescending(o => o.get_pro_Price()).ToList();
            return temp;
        }

        public static void storeProductDataInList(pro_duct pro)//Funtion to Store products in the list
        {
            products.Add(pro);
        }
        public static void store_Data_In_File(string path1, pro_duct pro)//Funtion to Store product's Data in the File
        {
            StreamWriter myfile = new StreamWriter(path1, true);
            myfile.WriteLine(pro.get_pro_Name() + "," + pro.get_pro_Price() + "," + pro.get_pro_Stock() + "," + pro.getDiscount());
            myfile.Flush();
            myfile.Close();
        }
        public static void store_Data_In_File()//Funtion to Store product's Data in the File
        {
            StreamWriter myfile = new StreamWriter(@"C:\Users\AL-FATAH LAPTOP\OneDrive\Desktop\data.txt");
            foreach (pro_duct pro in PDataLayer.products)
            {
                myfile.WriteLine(pro.get_pro_Name() + "," + pro.get_pro_Price() + "," + pro.get_pro_Stock() + "," + pro.getDiscount());
            }
            myfile.Flush();
            myfile.Close();
        }
        public static List<pro_duct> SortByQuntity(List<pro_duct> Bought_Products)//Funtion to Sort products in the list by Quantity
        {

            List<pro_duct> sortedList = Bought_Products.OrderByDescending(o => o.getQuantity()).ToList();
            return sortedList;

        }

        public static bool readProductData(string path1, List<pro_duct> products)//Funtion to Read products's Data in the from the File
        {
            if (File.Exists(path1))
            {
                StreamReader fileVariable = new StreamReader(path1);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string pro_Name = MUserDL.parseData(record, 1);
                    int pro_Price = int.Parse(MUserDL.parseData(record, 2));
                    int pro_Stock = int.Parse(MUserDL.parseData(record, 3));
                    pro_duct pro = new pro_duct(pro_Name, pro_Price, pro_Stock);
                    storeProductDataInList(pro);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

        //public static string GetPathForProductsFile()
        //{
        //    string path = @"C:\Users\AL-FATAH LAPTOP\OneDrive\Desktop\data.txt";
        //    return path;
        //}
        public static void OnAndOffLocal(pro_duct p)
        {
            Console.WriteLine("IS THE PRODUCT IS LOCAL(YES / NO)");
            string x = Console.ReadLine();
            if (x == "yes")
            {
                p.setCountry(true);

            }
            else if (x == "no")
            {
                p.setCountry(false);
                p.set_pro_Price(p.get_pro_Price() + (p.get_pro_Price() * 0.5));
            }
        }
    }
}
