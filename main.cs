using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write ("Enter your weight in pounds: ");
    string input = Console.ReadLine();
    double userWeightEarth;
    if (double.TryParse (input, out userWeightEarth))
    { 
      Console.WriteLine ("Your weight on Earth is "+userWeightEarth+" pounds.");
    }
    else
    {
     Console.WriteLine ("Please enter a valid value."); 
    }
    //double userWeightEarth = Convert.ToDouble(Console.ReadLine());
    double userWeightMoon = userWeightEarth * 0.165;
    Console.WriteLine ("Your weight on the moon would be "+userWeightMoon+" pounds.");
  }
}