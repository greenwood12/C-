//delegate-object(top-level-object) vs class-object(class-oop-object)
//using System.Reflection.Emit;

//Helele2Class obj = new();
//obj.Func1();

//class....property+method+event....classic-oop
Person person1 = new Person(); //constructor-call...default-service

WriteLine(person1);

person1.SetId(1);
WriteLine($"id:{person1.GetId()}") ;
WriteLine(person1);

person1.SetId(10);
WriteLine($"id:{person1.GetId()}");
WriteLine(person1);

WriteLine("========================");

Person person2 = new Person();  // constructor-call...default service
person2.SetId(1);
WriteLine($"id:{person2.GetId()}");
WriteLine(person2);

person2.SetId(10);
WriteLine($"id:{person2.GetId()}");
WriteLine(person2);

// data====>direct-call....beast-code...bad.coding
WriteLine(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10);
WriteLine("expression: data,,, operator....combination");
WriteLine("expression....no-thread-service....type-safety");
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
//data====>in-direct-call....beauty-code....good-coding
// c# 6.0 ceremony-coding.....2010 year....vs2012
int One() => 1; int Two() => 2; int Three() => 3;
int Four() => 4; int Five() => 5; int Six() => 6;
int Seven() => 7; int Eight() => 8; int Nine() => 9;
int Ten() => 10;

WriteLine(One() + Two() + Three() + Four() + Five() + Six() + Seven() + Eight() + Nine() + Ten());
WriteLine("expression: data,,, operator....combination");
WriteLine("expression....no-thread-service....type-safety");

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
// c# 6.0 ceremony-coding.....2010 year....vs2012
var OneObj =() => 1; var TwoObj =() => 2;
var ThreeObj =() => 3; var FourObj =() => 4;
var FiveObj =() => 5; var SixObj =() => 6;
var SevenObj=() => 7; var EightObj =() => 8; 
var NineObj=() => 9;var TenObj=() => 10;

WriteLine(OneObj() + TwoObj() + ThreeObj() + FourObj() + FiveObj() + SixObj() + SevenObj() + EightObj() + NineObj() + TenObj());
WriteLine("expression: data,,, operator....combination");
WriteLine("expression....no-thread-service....type-safety");

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
//general-class =======>dataClass(record)...DTO...data-transport-object

Person person3 = person1 + person2;
WriteLine("OOP is studpid.......basic calculation(X)");
WriteLine(person3);
WriteLine(person3);


public partial class Person 
{
    public static Person operator +(Person p1, Person p2) =>
        new Person { id = p1.GetId() + p2.GetId() };

    //presentation....View-service...result(value)...Html4
    //representation....Data-service....vector-space(set)..calcuation....Html5
    //representation-service
    //default....fully-(E)qualifyed-name..namespace.nlassName.functionName
    //C# 6.0 later....ceremony-coding

    public override string ToString() => $"Id:{this.id}";
    //{
    //    return base.ToString();
    //    return $"id:{this.GetId()}";
    //}

    //public override string ToString()
    //{
    //    return base.ToString();
    //    return $"id:{this.GetId()}";
    //}

    // memory ===> store ===>storage ==>EntityFramework(NoSQL service) ===>SQL
    int id;

    public int GetId() => id;
    //public int GetId() 
    //{ 
    //    return id;
    //}

    public void SetId(int i) => id = i;
    //public void SetId(int i) 
    //{
    //    this.id = i;
    //}
}