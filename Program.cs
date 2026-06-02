using System;

namespace PiApproximation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of computational terms to process: ");
            
            // Validate user input to ensure it is a parseable integer
            if (int.TryParse(Console.ReadLine(), out int totalIterations))
            {
                CalculatePiApproximation(totalIterations);
            }
            else
            {
                Console.WriteLine("[Error] Invalid input. Please enter a valid integer.");
            }
        }

        /// <summary>
        /// Computes and displays the approximation of Pi using the Gregory-Leibniz infinite series.
        /// </summary>
        /// <param name="totalIterations">The number of terms to calculate in the series.</param>
        private static void CalculatePiApproximation(int totalIterations)
        {
            double numerator = 4.0;
            double denominator = 1.0;
            double approximatePi = 0.0;

            Console.WriteLine("\nTerm\t\tPi Value");
            Console.WriteLine("------------------------------------------------");

            for (int currentIteration = 1; currentIteration <= totalIterations; currentIteration++)
            {
                // The Gregory-Leibniz series alternates subtraction and addition for even/odd terms
                if (currentIteration % 2 == 0) 
                {
                    approximatePi -= numerator / denominator;
                }
                else     
                {
                    approximatePi += numerator / denominator; 
                }
               
                denominator += 2.0;

                // Output the current iteration step and the approximated value to 16 decimal places
                Console.WriteLine($"{currentIteration}\t\t{approximatePi:F16}");
            }
            
            Console.WriteLine("\n[Process Complete]");
        }
    }
}
