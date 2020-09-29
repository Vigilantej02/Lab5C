using System;

class MainClass {
  public static void Main (string[] args) {
    /*hey, i finally get to use my name as variables :D
    this took me way longer than it should have, I couldnt get the math quite right. think I nailed it though.*/
    int j, a, y;
    y = 0;
    Console.WriteLine("Enter a whole number");
    j = Convert.ToInt32(Console.ReadLine());
    for (a = 1; a <= j; a++)
    {
      if (j % a == 0)
      {
        y++;
      }
    }
      if (y == 2)
      {
        Console.WriteLine(j + " is a prime number");
      }
      else 
      {
        Console.WriteLine(j + " is not a prime number");
      }
      }
    }