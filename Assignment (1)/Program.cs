using Assignment__1_;

// 1
Book b = new Book();
b.Title = "C#";
b.Pages = 464;

object obj = b;
Console.WriteLine(obj);

//2

Console.WriteLine(b.ToString());
Console.WriteLine(b.Equals(b));
Console.WriteLine(b.GetHashCode());
Console.WriteLine(b.GetType());

//3
int pages = 464;

//4
try
{
    int x = 10 / 0;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}
