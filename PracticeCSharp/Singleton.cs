using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    public class Singleton
    {

        private static string miSingle;
        private static Lazy<object> lazyLoad;
        public static string MiSingle
        {
            get
            {
                if (miSingle == null)
                    miSingle = "test 123";
                return miSingle;
            }
        }

        public static object LazyLoad
        {
            get {
                if (lazyLoad == null)
                    lazyLoad = new Lazy<object>();

                return lazyLoad.Value;
            }
        }



    }
}
