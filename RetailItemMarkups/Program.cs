using System;

namespace Week9Day2Quiz
{
     class Program
     {
          static void Main(string[] args)
          {
               double wholesalePrice;

               //Get user input
               Console.Write("Input wholesale item price: ");
               string input = Console.ReadLine();

               while (double.TryParse(input, out wholesalePrice) == false)
               {
                    Console.Write("Error! Price must be a valid number: ");
                    input = Console.ReadLine();
               }

               //Create an array of string labels for the data
               string[] labelArray = new string[7];
               labelArray[0] = "Wholesale Price: ";
               labelArray[1] = "5% Markup Price: ";
               labelArray[2] = "6% Markup Price: ";
               labelArray[3] = "7% Markup Price: ";
               labelArray[4] = "8% Markup Price: ";
               labelArray[5] = "9% Markup Price: ";
               labelArray[6] = "10% Markup Price: ";

               //Calculate and store the prices into another array
               double[] priceArray = new double[7];
               priceArray[0] = wholesalePrice;
               priceArray[1] = wholesalePrice + (wholesalePrice * 0.05);
               priceArray[2] = wholesalePrice + (wholesalePrice * 0.06);
               priceArray[3] = wholesalePrice + (wholesalePrice * 0.07);
               priceArray[4] = wholesalePrice + (wholesalePrice * 0.08);
               priceArray[5] = wholesalePrice + (wholesalePrice * 0.09);
               priceArray[6] = wholesalePrice + (wholesalePrice * 0.10);

               //Output the information for the user
               Console.WriteLine("\nPrice List\n--------------------------------\n");
               for (int i = 0; i < 7; i++)
               {
                    Console.WriteLine("{0}\t{1:C}", labelArray[i], priceArray[i]);
               }

               Console.WriteLine();
               Console.Read();
          }
     }
}
