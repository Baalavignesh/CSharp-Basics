namespace ConsoleApp1
{
   
    internal class CaloriesTracker
    {

        public struct NewUser
        {
            public string username;
            public int age;
            public float height;
            public float weight;
        }

        public CaloriesTracker(NewUser user1)
        {
            user1.username = "Baalavignesh A";
            user1.age = 22;
            user1.height = 170;
            user1.weight = 77;

            Console.WriteLine("User Initialized");
        }



        public void AddItem(ref string[] fruites, ref int[] calories)
        {
            string new_food;
            int new_cal;
            Console.WriteLine("Adding a New Item");

            // Enter the food item and validate it
            Console.Write("Enter a Food Item :");
            new_food = Console.ReadLine();
            if (!string.IsNullOrEmpty(new_food))
            {
                fruites = fruites.Append(new_food).ToArray();
            }

            // Enter the food calories and validate
            bool is_valid = false;
            while(!is_valid)
            {
                try
                {
                    Console.Write("Enter a Food Item Calories:");
                    new_cal = Convert.ToInt32(Console.ReadLine());
                    is_valid = true;
                    calories = calories.Append(new_cal).ToArray();

                }
                catch(Exception e)
                {
                    Console.WriteLine("Enter a Valid Input");
                    is_valid = false;
                }
            }



        }
        public int CaloriesCalculator(string[] x, int[] y)
        {
            Console.WriteLine("\nCurrent Diet and the Calories");
            int total_calories = 0;
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i] + " : " + y[i]);
                total_calories = y[i] + total_calories;
            }
            return total_calories;
        }

        public void CaloriesResult(int total_cal, int my_limit)
        {   
            if(my_limit < total_cal)
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
            NewUser user1 = new NewUser();

            CaloriesTracker Tracker1 = new CaloriesTracker(user1);

            Console.WriteLine(user1.username);
            string[] fruits = { "apple", "orange", "bannana" };
            int[] calories = { 120, 85, 90 };
            int myCalorieLimit = 300;



            Tracker1.AddItem(ref fruits,ref calories);

            int totalCal = Tracker1.CaloriesCalculator(fruits, calories);

            Tracker1.CaloriesResult(totalCal, myCalorieLimit);

        }
    }
}