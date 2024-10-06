namespace DiamondKata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char charValue = Console.ReadLine().ToUpper()[0];

            var shape = new DiamondPatternBuilder().Build(charValue, "_");

            Console.WriteLine(shape);
        }
    }
}
