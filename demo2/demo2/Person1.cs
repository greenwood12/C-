// compile-time(static).....(dynamic)eager-system
// C# 4.0 later
// run-time(dynamic).....(dynamic)lazy-system....diterministric
// run-time(dynamic).....(dynamic)lazy-system....diterministric
// C# 9.0 dataClass===> record
public record Person1  // data-class....DTO....data-transport-object
{
    // C# 3.0 Auto-property
    public int Id { get; set; } // excution service
    // C# 1.0 store servcie.....field
    int age;
    public int Age //{ get; set; }.....in-line-coding vs hash-code
    {
        get  // get accessor
        {
            return age;
        }
        set  // set accessor
        {
            age = value;
        }
    }
    public string Name { get; set; }
    public bool Gender { get; set; }
    public string Address { get; set; }
}
