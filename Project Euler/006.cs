//https://projecteuler.net/problem=6
using System;

class MainClass {
  public static void Main (string[] args) {
    double sum = 0, sumSqr = 0;
    for (long i = 1; i<=100;i++){
      sum +=(long)Math.Pow(i,2);
      sumSqr += i;
    }
    sumSqr = Math.Pow(sumSqr,2);
    Console.WriteLine(sumSqr-sum);
  }
}
