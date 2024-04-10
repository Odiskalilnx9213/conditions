using System;

class Program
{
   static void Main(string[] args)
   {
      Console.WriteLine("introduce the first limit:");
      int limit1 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("introduce the second limit:");
      int limit2 = Convert.ToInt32(Console.ReadLine());

      // Ensure limit1 is the minimum and limit2 is the maximum
      int min = Math.Min(limit1, limit2);
      int max = Math.Max(limit1, limit2);

      Console.WriteLine("introduce an integer to limit:");
      int number = Convert.ToInt32(Console.ReadLine());

      if (number > max)
      {
         Console.WriteLine($"You have entered {number} which is greater than {max} which is the maximum");
         number = max;
      }
      else if (number < min)
      {
         Console.WriteLine($"You have entered {number} which is lower than {min} which is the minimum");
         number = min;
      }

      Console.WriteLine($"Resulting integer: {number}");
   }
}

