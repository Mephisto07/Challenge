//https://projecteuler.net/problem=5
using System;

class MainClass {
  public static void Main (string[] args) {
    long res = 0;
    long num = 1;
    do{
      bool evenly = true;
      for(int i = 1; i<=20; i++){
        if(num %i != 0){
          evenly = false;
          break;
        }
      }
      if (evenly){
        res = num;
      }
      num++;
    }while(res == 0);
    Console.WriteLine(res);
  }
}
