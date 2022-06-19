global using System.Text.Json; //jsonformater
//const int kkkk = 1234;
//readonly int kkk = 12345;

// compile-before....static data-area service
//1=10; //literal service...static constructor service
//static-operation....className

//compile-time service
//Person.Address = "1212121212121"; //const keyword
Person.Juso = "aaaaasasa";

// CLR service....R....RunTime service....constructor service
// new instance...readonly keyword....object-access
Person person2 = new Person { Id = 1, Age = 11, Gender = true, Name = "AAA" };
//person.Id = 1234; //immutale service....real-time service

int id = person2.Id;
string aaa = person2.JusoAddress;
//person2.JusoAddress = "aaaaa";
// readonly-keyworld
// dynaminc-time....immutable

return;
//object....scope service + life-time service

// variable-write = variable-read;....input/output operation
// serialization/deserialization
// left-value = right-value; ....data moving service....code
//1 = 10; //literal...constant....fixed service...immutable

//C# 3.0 object-initialization-
Person person = new Person{ Id=1, Age=11, Gender=true, Name="AAA" };
WriteLine(person);

var personStr = JsonSerializer.Serialize(person);

List<Person> people = new List<Person> 
{
    person,
    new Person{ Id=1, Age=11, Gender=true, Name="AAA" },
    new Person { Id = 2, Age = 21, Gender = false, Name = "BBB" },
    new Person { Id = 3, Age = 31, Gender = true, Name = "CCC" },
};
WriteLine(people); //object display
var peopleStr = JsonSerializer.Serialize(people);
WriteLine(peopleStr); //string display


var imsiPerson = JsonSerializer.Deserialize<List<Person>>(peopleStr);
//Person imsiPerson = JsonSerializer.Deserialize<Person>(personStr);
WriteLine(imsiPerson);

foreach (var kkk in people) //C# group-object...loop statement
{
    
    WriteLine(kkk);
}

foreach (var kkk in imsiPerson) //C# group-object...loop statement
{

    WriteLine(kkk);
}
return;

//do
//{
//    //C# 2.0 using...block-scope service
//    //C# 8.0 using scope service.....module(file) scope...upGrading
//    using Person p1 = new() ;
//    //{
//        {
//            int c = 30;
//            using Person p2 = new() ;
//            //{
//                {
//                    int b = 20;
//                    using Person p3 = new() ;
//                    //{
//                        {
//                            int a = 10; // local-scope
//                            using Person p4 = new() ;
//                            //{
//                                WriteLine($"a:{a} b:{b} c:{c}");
//                                WriteLine(p4);
//                            //}
//                        }
//                        WriteLine($"a:a b:{b} c:{c}");
//                        WriteLine(p3);
//                    //}
//                }                
//                WriteLine($"a:a b:b c:{c}");
//                WriteLine(p2);
//            }            
//        //}
//        WriteLine($"a:a b:b c:c");
//        WriteLine(p1);
//    }
////}
//// sequence....idempotent.....(Once(continuation)...one(discreate)).....single-source-of-truth
//while (ReadKey().Key != ConsoleKey.Z);
public partial class Person :IDisposable
{
    public void Dispose() => WriteLine("Person class....Dispose statme");
}

public partial class Person
{
    public required int Id { get; init; } = default;
    public required int Age { get; init; } = default;
    public required string Name { get; init; } = default(string);
    public required bool Gender { get; init; } = default;
}

public partial class Person
{
    public override string ToString()
            => $"Id:{Id} Age:{Age} Name:{Name} Gender:{Gender}";
    
}

public partial class Person
{
    public static string Juso = "Seoul";

    //instance-constructor...instance-member
    //public Person() // instance
    //{
    //    //Person.Address = "rrrrrrr";
    //    //Person.Juso = "aaaaaaa";
    //}

    // static constructor...static-member-initialization
    static Person()
    {
        Person.Juso = "Inchun";  //literal-service
    }

    public const string Address = "Pusan";
    public readonly string JusoAddress = "KangJu";
}

public partial class Person
{
}


