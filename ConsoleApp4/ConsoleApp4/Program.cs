namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mehsul = "Hp";
            int firstValue = 1000;
            double percent = 0.11;
            int lastValue = (int)(firstValue - (firstValue * percent));
            Console.WriteLine($"mehsulun adi: {mehsul},son qiymet: {lastValue}");
        }
    }
}
