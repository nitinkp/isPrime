using System;
class CodingTest{
  static void Main() {

  Console.WriteLine("Enter an positive integer to check: ");
  int number = Convert.ToInt32(Console.ReadLine());

   if (isPrime(number))
        Console.WriteLine("True");
    else
        Console.WriteLine("False");
  }
 static bool isPrime(int n)
    {
        if (n <= 1)
            return false;
        
        var sqr_root = Math.Sqrt(n); 
        for (int i = 2; i <= sqr_root; i++)
            if (n % i == 0)
                return false;
 
        return true;
    }
}