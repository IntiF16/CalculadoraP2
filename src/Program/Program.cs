public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Addition.Add(1, 2));
        Console.WriteLine(Subtraction.Subtract(3, 4));
        Console.WriteLine(Multiplication.Multiply(5, 6));
        Console.WriteLine(Division.Divide(7, 8));
    }
<<<<<<< HEAD
    }
    
public class Division
{
   public static double Divide(int a, int b)
   {
       return (double)a / b;
   }
}
=======
}

// Esta clase implementa la operación <nombre-operación>
public class Addition
{
   public static int Add(int a, int b)
   {
       return a + b;
   }
}
>>>>>>> 1b5fb21ef5927fb483971a8b14b02c6933a29a5a
