//https://projecteuler.net/problem=7
using System;

class MainClass {
  public static void Main (string[] args) {
    int count = 0, i = 2;
    do{
      if (IsPrime(i)){
        count++;
      }
      i++;
    }while(count<10001);
    i--;
    Console.WriteLine("res "+ i+ " count "+ count);
  }
  
  public static bool IsPrime(int num){
    int sumDiv = 0;
    for (int i = 1; i <= num; i++) {
      if (num % i == 0) { 
       sumDiv++;
      }
    }
    if (sumDiv == 2) return true;
    return false;
  }
}
