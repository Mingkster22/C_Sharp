using System;
using System.IO; 
public class Program
{
    public static void Main(string[] args)
    {
        int _decision = 0;

        Console.WriteLine("Welcome to Minkee's atm");
        
        Console.WriteLine("Press 1 sign up or press 2 to log in");
        _decision = int.Parse(Console.ReadLine());

        if (_decision == 1)
        {
            Console.WriteLine("Please enter the ID you would like to create: ");
            (User._Created_id) = Console.ReadLine();
            User.User_info.Add(User._Created_id);

            Console.WriteLine("Please enter the password you would like to create: ");
            User._Created_pw = int.Parse(Console.ReadLine());
            User.User_info.Add(User._Created_pw.ToString());
            User.saver();

        }

        else if (_decision == 2)
        {
            User user = new User();

            Console.WriteLine("Please enter your ID: ");
            string id = Console.ReadLine();

            var lines_Read = File.ReadLines("UserFile.txt");

            foreach (var i  in lines_Read)
            {
                if (i == id)
                {
                    Console.WriteLine("Please enter your Password: ");
                    string pw = Console.ReadLine();

                    foreach (var ii in lines_Read)
                    {
                        if (ii == pw)
                        {
                            Console.WriteLine("You have logged in successfully");
                            Thread.Sleep(1000);

                            user.Animation();

                            Console.WriteLine("Please select from the options: ");

                            Console.WriteLine("1. Open checking account/n"+
                            "2. Open savings account/n"+
                            "3. Open credit card/n"
                            );
                            
                            int decision;

                            if (decision == 1)
                            {

                            }

                        }
                    }
                }

                else if (i != id)
                {
                    Console.WriteLine("The Id you entered does not exist, please enter a different Id: ");

                    continue;
                }

            }
        }

        

    }
}
