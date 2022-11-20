int N = new int();
Console.WriteLine("Enter a number");
N = Covert.ToInt32(Console.ReadLine());
int i = 0;
while (i < N - 1)
{
    i += 2;
    Console.WriteLine(i);
}
Console.Write("All the even numbers");