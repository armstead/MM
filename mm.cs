/*
a. Have the program go through the numbers 1 to 100 (inclusive)
b. If the number is divisible by 3 only, output Modern
c. If the number is divisible by 5 only, output Medical
d. If the number is divisible by both 3 and 5, output ModernMedical
e. If the number is not divisible by either 3 or 5, only output the number itself.
*/

using System;

public class MM
{
   static public void Main ()
   {
      bool byThree = false;
      bool byFive = false;

      for (int i=1; i<=100; i++)
      {
         if (i%3 == 0)
            byThree = true;
         if (i%5 == 0)
            byFive = true;

         if (byThree && byFive)
            Console.WriteLine ("ModernMedical");
         if (byThree & !byFive)
            Console.WriteLine ("Modern");
         if (byFive & !byThree)
            Console.WriteLine("Medical");
         if (!byThree && !byFive)
            Console.WriteLine(i);

         byThree = false;
         byFive = false;
      }
   }
}
