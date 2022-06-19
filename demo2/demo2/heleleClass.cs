
// abstraction + encaptulation(access-modifier:private,protected,public,,,,,internal)
public class heleleClass
{
    public void HeleleFunc()
    {
        Person0 per0 = new();  // C# 9.0 new-expression service
        Person per = new();  // C# 9.0 new-expression service
        Person1 per1 = new();  // C# 9.0 new-expression service
        Person2 per2 = new();  // C# 9.0 new-expression service
        Person3 per3 = new();  // C# 9.0 new-expression service
        WriteLine($$"""
        {
            "per0" : {{per0}},      "per0" : {{per0.GetType()}},
            "per" : {{per}},        "per" : {{per.GetType()}},
            "per1" : {{per1}},    "per1" : {{per1.GetType()}},
            "per2" : {{per2}},    "per2" : {{per2.GetType()}},
            "per3" : {{per3}},    "per3" : {{per3.GetType()}},
        }
        """);
        WriteLine($$"""
        {
            "per0" : {{per0.GetType()}},    "per0" : {{per0.GetType().BaseType}},   "per0" : {{per0.GetType().BaseType.BaseType}},
            "per" :   {{per.GetType()}},      "per" : {{per.GetType().BaseType}},
            "per1" : {{per1.GetType()}},    "per1" : {{per1.GetType().BaseType}},
            "per2" : {{per2.GetType()}},    "per2" : {{per2.GetType().BaseType}},
            "per3" : {{per3.GetType()}},    "per3" : {{per3.GetType().BaseType}},   "per3" : {{per3.GetType().BaseType.BaseType}},
        }
        """);
        // compile-time(static).....(dynamic)eager-system
        int su1 = 1;
        object su2 = 2;   // before C# 4.0
                          // C# 4.0 later
        dynamic su3 = 3;
        // run-time(dynamic).....(dynamic)lazy-system....diterministric
        Lazy<int> su4 = new Lazy<int>(4);
        // run-time(dynamic).....(dynamic)lazy-system....diterministric
        Lazy<int> su5 = new Lazy<int>(() => 5);  // C# 1.0 delegate-object
        WriteLine($$"""
        {
            "su1" : {{su1}},
            "su2" : {{su2}},
            "su3" : {{su3}},
            "su4" : {{su4}},
            "su5" : {{su5}},    "su5" : {{su5.Value}},   selector/pointer/injector
        }
        """);
        WriteLine($$"""
        {
            "per0" : {{per0}},      "per0" : {{per0.GetType()}},
            "per" : {{per}},        "per" : {{per.GetType()}},
            "per1" : {{per1}},    "per1" : {{per1.GetType()}},
            "per2" : {{per2}},    "per2" : {{per2.GetType()}},
            "per3" : {{per3}},    "per3" : {{per3.GetType()}},
        }
        """);
        WriteLine($$"""
        {
            "per0" : {{per0.GetType()}},    "per0" : {{per0.GetType().BaseType}},   "per0" : {{per0.GetType().BaseType.GetType()}},     "per0" : {{per0.GetType().BaseType.GetType().BaseType.BaseType}},
            "per" : {{per.GetType()}},        "per" : {{per.GetType().BaseType}},        "per" : {{per.GetType().BaseType.GetType()}},        "per" : {{per.GetType().BaseType.GetType().BaseType.BaseType}},
            "per1" : {{per1.GetType()}},    "per1" : {{per1.GetType().BaseType}},    "per1" : {{per1.GetType().BaseType.GetType()}},    "per1" : {{per1.GetType().BaseType.GetType().BaseType.BaseType}},
            "per2" : {{per2.GetType()}},    "per2" : {{per2.GetType().BaseType}},    "per2" : {{per2.GetType().BaseType.GetType()}},    "per2" : {{per2.GetType().BaseType.GetType().BaseType.BaseType}},
            "per3" : {{per3.GetType()}},    "per3" : {{per3.GetType().BaseType}},    "per3" : {{per3.GetType().BaseType.GetType()}},    "per3" : {{per3.GetType().BaseType.GetType().BaseType.BaseType}},
        }
        """);

    }
}