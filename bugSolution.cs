public class ExampleClass
{
    public int? MyProperty { get; set; } //Nullable int

    public ExampleClass(int? value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Check for null before accessing the property
        Console.WriteLine(MyProperty?.ToString() ?? "MyProperty is null"); 
    }
}