//delegate-object(top-level-object) vs class-object(class-oop-object)
//using System.Reflection.Emit;

// C# 2.0 class.....C# 3.0 partial-method....C# 9.0.....source-generator service
public partial class Helele1Class
{
    public void HeleleFunc1()
    {
        var heleleObj = (int su1, int su2) =>
        {
            HeleleClass obj = new();
            obj.heleleFunc();
            WriteLine($"su1:{su1} su2:{su2}");
        };
        heleleObj(10, 20);
    }
}
