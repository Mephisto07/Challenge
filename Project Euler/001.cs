//https://projecteuler.net/problem=1
using System;

class MainClass {
  public static void Main (string[] args) {
    long sum = 0;
    for (int i = 2; i<1000; i++){
      if (IsMultiple(i,3) || IsMultiple(i,5)){
        sum += i;
      };
    }
    
    Console.WriteLine(sum);
  }
  public static bool IsMultiple(int n, int m){
    return n % m == 0;
  }
}
