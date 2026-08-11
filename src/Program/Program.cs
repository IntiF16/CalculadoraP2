public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Addition.Add(1, 2));
        Console.WriteLine(Subtraction.Subtract(3, 4));
        // Console.WriteLine(Multiplication.Multiply(5, 6));
        Console.WriteLine(Division.Divide(7, 8));
    }
}
    
public class Division
{
   public static double Divide(int a, int b)
   {
       return (double)a / b;
   }
}

// Esta clase implementa la operación suma
public class Addition
{
   public static int Add(int a, int b)
   {
       return 0;//a + b;
   }
}

// Esta clase implementa la operación resta
public class Subtraction
{
   public static int Subtract(int a, int b)
   {
       return a - b;
   }
}
