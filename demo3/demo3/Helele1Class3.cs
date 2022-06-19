//delegate-object(top-level-object) vs class-object(class-oop-object)
//using System.Reflection.Emit;

public partial class Helele1Class
{
    public void HeleleFunc4()
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
