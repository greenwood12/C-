using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //concise service c# 6.0

// declarative... 선언적(Markup-language) VS 구현적 .... imperative... coding
namespace demo1 // classSet... static memorySet
{
    //WriteLine("Hello world....." +
    //            "state....memory service...compile-time...." +
    //            "run-time.....store...storage..." +
    //            "service....stream/sequence===>5S+4C+3I");

    class helele1 { }
    class helele2 { }
    class helele3 { }
    class helele4 { }



    internal class Program //static data service... memory service
    {
        //WriteLine("Hello world....." +
        //        "state....memory service...compile-time...." +
        //        "run-time.....store...storage..." +
        //        "service....stream/sequence===>5S+4C+3I");
        static void Main(string[] args)
        {
            
            void heleleFunc4()
            {
                WriteLine("throw new NotImplementedException();");
            }


            //state + ment....gloup-statement..set
            heleleFunc1();  //function
            heleleFunc2();  //function
            heleleFunc3();  //function
            heleleFunc4();  //function
            //state + ment......set
            //state + ment......set
            //state + ment......set

            //state + ment....single-statement..set....thread...excution unit
            WriteLine("Hello world....." +
                "state....memory service...compile-time...." +
                "run-time.....store...storage..." +
                "service....stream/sequence===>5S+4C+3I");

            //state + ment....single-statement..set....thread
            WriteLine(@"Hello world.....
                state....memory service...compile-time....
                run-time.....store...storage...
                service....stream/sequence===>5S+4C+3I");
        }

        private static void heleleFunc4()
        {
            WriteLine("throw new NotImplementedException();");
        }

        private static void heleleFunc3()
        {
            WriteLine("throw new NotImplementedException();");
        }

        private static void heleleFunc2()
        {
            WriteLine("throw new NotImplementedException();");
        }

        private static void heleleFunc1()
        {
            WriteLine("throw new NotImplementedException();");
        }
    }
}
