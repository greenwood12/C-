// C# 10 later....gerneral delegate
// C# 3.0 later
using demo3;
using System.Net;
// C# 5.0
var heleleObj = async () =>
{
    var heleleObj = () =>
    {
        // data===>direct-call.....beast-code....bad-coding
        WriteLine(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10);
        WriteLine("expression:   data ,,,,  operator....combination");
        WriteLine("expression...no-thread-service....type-safety-service");
        WriteLine(1);
        WriteLine(2);
        WriteLine(3);
        WriteLine(4);
        WriteLine(5);
        WriteLine(6);
        WriteLine(7);
        WriteLine(8);
        WriteLine(9);
        WriteLine(10);
        // data===>in-direct-call.....beauty-code....good-coding
        // C# 6.0 ceremony-coding.....2010 year....vs2012
        int One() => 1; int Two() => 2; int Three() => 3;
        int Four() => 4; int Five() => 5; int Six() => 6;
        int Seven() => 7; int Eight() => 8; int Nine() => 9;
        int Ten() => 10;
        WriteLine(One() + Two() + Three() + 4 + 5 + 6 + 7 + 8 + 9 + 10);
        WriteLine("expression:   data ,,,,  operator....combination");
        WriteLine("expression...no-thread-service....type-safety-service");
        WriteLine(One());
        WriteLine(Two());
        WriteLine(Three());
        WriteLine(Four());
        WriteLine(Five());
        WriteLine(Six());
        WriteLine(Seven());
        WriteLine(Eight());
        WriteLine(Nine());
        WriteLine(Ten());
        // C# 3.0 delegate-object
        // C# 6.0 ceremony-coding.....2010 year....vs2012
        var OneObj = () => 1; var TwoObj = () => 2;
        var ThreeObj = () => 3; var FourObj = () => 4;
        var FiveObj = () => 5; var SixObj = () => 6;
        var SevenObj = () => 7; var EightObj = () => 8;
        var NineObj = () => 9; var TenObj = () => 10;
        WriteLine(OneObj() + TwoObj() + ThreeObj() + 4 + 5 + 6 + 7 + 8 + 9 + 10);
        WriteLine("expression:   data ,,,,  operator....combination");
        WriteLine("expression...no-thread-service....type-safety-service");
        WriteLine(OneObj());
        WriteLine(TwoObj());
        WriteLine(ThreeObj());
        WriteLine(FourObj());
        WriteLine(FiveObj());
        WriteLine(SixObj());
        WriteLine(SevenObj());
        WriteLine(EightObj());
        WriteLine(NineObj());
        WriteLine(TenObj());
        // delegate-object(top-level-object) vs class-object(classic--oop object)
        //using System.Reflection.Emit;
        //Helele2Class obj = new();
        //obj.Func1();
        // class.....property+method+event....classic-oop
        Person person1 = new Person();  // constructor-call...default service
        WriteLine(person1);
        person1.SetId(1);
        //WriteLine($"Id:{person1.GetId()}");
        WriteLine(person1);
        person1.SetId(10);
        //WriteLine($"Id:{person1.GetId()}");
        WriteLine(person1);
        WriteLine("================");
        Person person2 = new Person();  // constructor-call...default service
        WriteLine(person2);
        person2.SetId(1);
        //WriteLine($"Id:{person1.GetId()}");
        WriteLine(person2);
        person2.SetId(10);
        //WriteLine($"Id:{person1.GetId()}");
        WriteLine(person2);
        Person person3 = person1 + person2;
        WriteLine("OOP is studpid.......basic calculation(X)");
        WriteLine(person3);
        WriteLine(person3);
    };
    heleleObj();
    //public swaggerClient(string baseUrl, System.Net.Http.HttpClient httpClient)
    swaggerClient obj2 = new swaggerClient("", new HttpClient());
    try
    {
        await obj2.AAAAsync();
        await obj2.BBBAsync(100, 200);
    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
    }
    finally
    {
        obj2 = null;
        WriteLine("finally exception service.....^^/");
    }
};
await heleleObj();