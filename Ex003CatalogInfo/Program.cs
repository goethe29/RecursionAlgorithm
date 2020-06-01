using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003CatalogInfo
{
    class Program
    {

        static void CatalogInfo(string Path, string Indent = "")
        {
            DirectoryInfo catalogs = new DirectoryInfo(Path);
            
            foreach (var currentCatalog in catalogs.GetDirectories())
            {
                Console.WriteLine($"{Indent}{currentCatalog.Name}");
                CatalogInfo(currentCatalog.FullName, Indent + "  ");
            }

            foreach (var item in catalogs.GetFiles())
            {
                Console.WriteLine($"{Indent}{item.Name}");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("RecursionAlgorithm");
            string path = @"C:\Users\i\source\repos\RecursionAlgorithm";
            CatalogInfo(path);
        }
    }
}
