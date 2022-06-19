//delegate-object(top-level-object) vs class-object(class-oop-object)
public class HeleleClass 
{
    //C# 3.0 local-variable ====> C# 10.0 general-delegate-object
    public void heleleFunc ()
    {   
        var HeleleObj =() =>
        {
            //C# 1.0 later
            unsafe
            {
                int su1 = 10;
                int* su2 = &su1;
                int* su3 = &su1;
                int* su4 = &su1;

                WriteLine($"single-source-of-thruth---su1:{su1} su2:{*su2} su3:{*su3} su4:{*su4}");
                *su2 = 1000;
                WriteLine($"single-source-of-thruth---su1:{su1} su2:{*su2} su3:{*su3} su4:{*su4}");
                *su3 = 20000;
                WriteLine($"single-source-of-thruth---su1:{su1} su2:{*su2} su3:{*su3} su4:{*su4}");
                *su4 = 1234;
                WriteLine($"single-source-of-thruth---su1:{su1} su2:{*su2} su3:{*su3} su4:{*su4}");
            }


            int suja = 10;  //integer-variable

            //C# 8.0 --single-source-of-thruth :: SOTA..state-of-the-art
            ref int suja1 = ref suja;
            ref int suja11 = ref suja;
            ref int suja111 = ref suja;
            ref int suja1111 = ref suja;

            WriteLine($$"""
                    single-source-of-thruth---
                    suja1:{{suja1}} 
                    suja11:{{suja11}} 
                    suja111:{{suja111}} 
                    suja1111:{{suja1111}}
                    """);

            suja1 = 1000;

            WriteLine($$"""
                    single-source-of-thruth---
                    suja1:{{suja1}} 
                    suja11:{{suja11}} 
                    suja111:{{suja111}} 
                    suja1111:{{suja1111}}
                    """);
            suja11 = 1100;

            WriteLine($$"""
                    single-source-of-thruth---
                    suja1:{{suja1}} 
                    suja11:{{suja11}} 
                    suja111:{{suja111}} 
                    suja1111:{{suja1111}}
                    """);
            suja111 = 1110;

            WriteLine($$"""
                    single-source-of-thruth---
                    suja1:{{suja1}} 
                    suja11:{{suja11}} 
                    suja111:{{suja111}} 
                    suja1111:{{suja1111}}
                    """);
            suja111 = 1111;

            // C# 11.0 later
            IntPtr suja2 = 10; // interger-pointer <==== likely-python...dynamic program

            var kkk = """
                pre-format
                C# 1.0 --- string-immutable-class
                mathematics....invarience....calculation...result
                constant.....single-source-of-truth...state-ment
                run-time(code-level::compile-time) vs dynamic-time(data-level)
                Hello, World!
                raw-string
                """u8;

            WriteLine($"{kkk.ToString()}- suja:{suja.ToString()} -suja2:{suja2.ToString()}");
        };

        HeleleObj();
    }
}