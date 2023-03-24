namespace ConsoleApp1
{

    public class HeroVillan
    {

        int total_bullets = 20;
        List<int> heroBullets = new List<int>();
        List<int> villanBullets = new List<int>();
        public void StartFight() 
        {
            int current_bullet = 0;
            while (total_bullets > 0)
            {
                Console.Write("Enter Who is shooting (1 Hero, 2 Villan) :");

                int user_input = Convert.ToInt32(Console.ReadLine());

                if (user_input == 1)
                {
                    total_bullets--;
                    current_bullet++;
                    heroBullets.Add(current_bullet);
                }
                else if (user_input == 2)
                {
                    total_bullets = total_bullets - 2;
                    current_bullet = current_bullet + 2;
                    villanBullets.Add(current_bullet);  
                }
                 
                else
                {
                    Console.WriteLine("Enter a Valid Input");
                }
                Console.WriteLine($"Bullets Remaining {total_bullets}");
            }

        }

        public void ViewResult()
        {
            foreach (var item in heroBullets)
            {
                Console.Write($"{item} ");

            }
            Console.WriteLine();
            foreach (var item2 in villanBullets)
            {
                Console.Write(item2);
            }
        }

            static void Main(string[] args)
            {
                HeroVillan incident = new HeroVillan();

            incident.StartFight();
            incident.ViewResult();
            }
        
    }
}