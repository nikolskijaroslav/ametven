using System;

public class FieldDef
{
    public string Sort { get; set; }
    public string OtherProp { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Example objects
        object fieldOrDatumDef1 = new FieldDef { Sort = "ascending", OtherProp = "value1" };
        object fieldOrDatumDef2 = new { OtherProp = "value2" };

        // Using the conditional operator for assignment
        string sort1 = IsFieldDef(fieldOrDatumDef1) ? ((FieldDef)fieldOrDatumDef1).Sort : null;
        string sort2 = IsFieldDef(fieldOrDatumDef2) ? ((FieldDef)fieldOrDatumDef2).Sort : null;

        Console.WriteLine(sort1); // Output: 'ascending'
        Console.WriteLine(sort2); // Output: (null)
    }

    // Function to check if an object is of type FieldDef
    public static bool IsFieldDef(object def)
    {
        return def is FieldDef;
    }
}
