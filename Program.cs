namespace ConsoleApp1
{
    internal class Program
    {
        public static int CaloriesCalculator(string[] x, int[] y)
        {
            int totalCalories = 0;
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i] + " : " + y[i]);
                totalCalories = y[i] + totalCalories;
            }
            return totalCalories;
        }

        public static void checkCalories(int totalCal, int myLimit)
        {   
            if(myLimit < totalCal)
            {
                Console.WriteLine("Good Diet");
            }
            else
            {
                Console.WriteLine("Eat More");
            }
        }
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "orange", "bannana" };
            int[] calories = { 120, 85, 90 };

            int myCalorieLimit = 300;

            int totalCal = CaloriesCalculator(fruits, calories);

            checkCalories(totalCal, totalCal);

        }
    }
}