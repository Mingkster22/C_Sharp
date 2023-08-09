public class User
{
    public static string _Created_id = "";
    public static int _Created_pw;

    public static List <string> User_info = new List <string>();

    public static void saver()
    {
        using (StreamWriter outputFile = new StreamWriter("UserFile.txt"))
        {
           foreach (string i in User_info)
           {
                outputFile.WriteLine(i);
           }
        }
    } 

    public void Id_pass(string id)
    {
        _Created_id = id;

    }

    public void Pw_pass(int pw)
    {
        _Created_pw = pw;
    }

    public void Animation()
    {
        Console.WriteLine("Loading...");
        
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b");
    }

}