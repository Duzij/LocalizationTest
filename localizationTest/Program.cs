using localizationTest.Resourses;
using System;
using System.Globalization;
using System.Resources;

namespace localizationTest
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AppResource.resourseText);
            Console.ReadLine();
            CultureInfo.CurrentCulture = new CultureInfo("cs");
            CultureInfo.CurrentUICulture = new CultureInfo("cs");
            CultureInfo cul = new CultureInfo("cs");

            Console.WriteLine(AppResource.resourseText);
            Console.WriteLine(AppResource.ResourceManager.GetString("resourseText"));
            Console.WriteLine(AppResource.ResourceManager.GetString("resourseText", cul));
            Console.ReadLine();
        }
    }
}