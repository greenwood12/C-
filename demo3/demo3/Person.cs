//delegate-object(top-level-object) vs class-object(class-oop-object)
//using System.Reflection.Emit;

//Helele2Class obj = new();
//obj.Func1();

//class....property+method+event....classic-oop







// data====>direct-call....beast-code...bad.coding
//data====>in-direct-call....beauty-code....good-coding
// c# 6.0 ceremony-coding.....2010 year....vs2012


// C# 3.0 delegate-object
// c# 6.0 ceremony-coding.....2010 year....vs2012


//general-class =======>dataClass(record)...DTO...data-transport-object

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