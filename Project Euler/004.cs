//https://projecteuler.net/problem=4
using System;

class MainClass {
  public static void Main (string[] args) {
    long max = 0;
    int n = 1000;
    for (long i = 100; i<n; i++){
      for (long j = 100; j<n;j++){
        string mul = (i*j).ToString();
        string rev = Reverse(mul);
        if (mul == rev){
          long res = Convert.ToInt32(mul);
          max = res > max ? res : max;
        }
      }
    }
    Console.WriteLine(max);
  }
  
  public static string Reverse( string s )
  {
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
  }
}
