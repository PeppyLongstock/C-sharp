int userNumber1 = new int ();
int userNumber2 = new int ();
Console.WriteLine ("enter a number");
    userNumber1 = Convert.ToInt32(Console.ReadLine());
    userNumber2 = Convert.ToInt32(Console.ReadLine());
int result = userNumber1 * userNumber1;
if (result == userNumber2)
    Console.WriteLine("yes");
else
 {
    Console.WriteLine("no");
    }