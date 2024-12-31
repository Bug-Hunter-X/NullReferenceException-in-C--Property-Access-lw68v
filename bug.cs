public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // This will throw a NullReferenceException if MyProperty is not initialized
        Console.WriteLine(MyProperty.ToString());
    }
}