using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
  public  class TestSingleton
    {
        private static string mySingle;
        private static Lazy<object> lazyobj;


        public static string MySingle
        {
            get {
                if (mySingle == null)
                     mySingle = "";
                return mySingle;
            }
        }

        public static object LazyOb {

            get {
                if (lazyobj == null)
                    lazyobj = new Lazy<object>();

                return lazyobj.Value;
            }
        }


    }
}
