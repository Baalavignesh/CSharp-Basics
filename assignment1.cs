using System;
using System.Security.Cryptography;


public struct UserInfo
{
    public string name;
    public string zodiac;
    public string dob;

    public Dictionary<string, string> question_answer = new Dictionary<string, string>() {
            {"What is your favorite food : ", "" },
            {"What is your favorite time (day/night) : ", "" },
            {"What is your favorite color : ", "" },
        };


    public UserInfo() {
        Console.WriteLine("Enter your name : ");
        name = Console.ReadLine();
        Console.WriteLine("Enter your DOB (DD-MM-YYYY): ");
        DateTime date1 = Convert.ToDateTime(Console.ReadLine());
        dob = date1.ToShortDateString();


        Console.WriteLine("Enter your Zodiac : ");
        zodiac = Console.ReadLine();
    }

}
public class SaraProblem
{
	enum zodiac { Aries, Taurus, Gemini, Cancer, Leo, Virgo, Libra, Scorpio, Sagittarius, Capricorn, Aquarius, Pisces }
    enum Months { January, February, March, April, May, June, July, August, September, October, November, December }


    public SaraProblem(UserInfo u1)
	{
        this.Mentalist(u1);


    }


	public void Mentalist(UserInfo u1)
	{
        // Get the question and answer of user by iterating a list
		foreach(KeyValuePair<string, string> val in u1.question_answer)
        {
            Console.WriteLine(val.Key);
            string answer =  Console.ReadLine();
            //val.Value = answer;
        }
    }

    public void MimicPtolemy(UserInfo u1) {
        Console.WriteLine("Enter your Zodiac Sign : ");
        u1.zodiac = Console.ReadLine();
    }

    public void CalanderMan(UserInfo u1)
    {
        DateTime newDate = DateTime.Now;
        // subtract current date to the dob entered to finds the age
    }

	static void Main(string[] args)
	{
        UserInfo u1 = new UserInfo();

        SaraProblem s1 = new SaraProblem(u1);

    }
}
