namespace ConsoleApp1
{
    internal class Program
    {
        public static void CaloriesCalculator(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Main(string[] args)
        {
            int apple = 160;
            int orange = (int)120.2;

            CaloriesCalculator(apple, orange);

        }
    }
}