using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesSample
{
    public static class StaticClass
    {
        static StaticClass( )
        {
            
        }

        public static string GetGreeting()
        {
            return "Hi there!";
        }

        //public string DynamicNotAllowed()
        //{
        //    return "error";
        //}
    }
}
