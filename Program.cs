internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dt = new DateTime(2023, 06, 14, 15, 04, 33);
        Console.WriteLine(dt.ElapsedTime());
    }
}