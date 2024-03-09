internal class Program
{
    private static void Main(string[] args)
    {
        byte byteValue = 255;
        short shortValue = 32767;
        int intValue = 2147483647;
        long longValue = 9223372036854775807L;

        float floatValue = 3.14f;
        double doubleValue = 3.141592653589793;

        char charValue = 'A';

        bool boolValue = true;

        string stringValue = "Hello, World!";

        object objectValue = 42;

        Console.WriteLine($"Byte Value: {byteValue}");
        Console.WriteLine($"Short Value: {shortValue}");
        Console.WriteLine($"Int Value: {intValue}");
        Console.WriteLine($"Long Value: {longValue}");
        Console.WriteLine($"Float Value: {floatValue}");
        Console.WriteLine($"Double Value: {doubleValue}");
        Console.WriteLine($"Char Value: {charValue}");
        Console.WriteLine($"Bool Value: {boolValue}");
        Console.WriteLine($"String Value: {stringValue}");
        Console.WriteLine($"Object Value: {objectValue}");
    }
}