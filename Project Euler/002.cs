//https://projecteuler.net/problem=2
using System;

class MainClass {
  public static void Main (string[] args) {
    long sum = 0;
    long i = 0;
    do{
      long elem = FibonacciEven(i);
      sum += elem;
      i++;
    }while(sum<4000000);
    
    Console.WriteLine(sum);
  }
  
  public static long FibonacciEven(long n)
  {
    int a = 0;
    int b = 1;
    for (int i = 0; i < n; i++)
    {
        int temp = a;
        a = b;
        b = temp + b;
    }
    return a%2==0? a : 0;
  }
}
