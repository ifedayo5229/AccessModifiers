using System;

namespace DemoAccesModifiers
{
    class Program
    {

        // The application print the name of a particular user workspace..
        static void Main(string[] args)
        {
            UserName  user1 = new UserName();
		     user1.printUserName();
            // Console.WriteLine("Hello World!");
        }
    }

    public class User
     {
	private string Name ="IFE";

	protected string display()
	{
		return Name;
	}
}
public class UserName: User
{
	public string  name;
	public void printUserName()
	{
		name = display();
		Console.WriteLine("The username : " + name);
	}

}

}
