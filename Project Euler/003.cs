using System;

class MainClass {
  public static void Main (string[] args) {
    long a, b;
    a = 600851475143; 
    for (b = 2; a > 1; b++){
      if (a % b == 0)
      {
        int x = 0;
        while (a % b == 0)
        {
            a /= b;
            x++;
        }
        Console.WriteLine("{0} is a prime factor {1} times!", b, x);
      }
    }
  }
}
