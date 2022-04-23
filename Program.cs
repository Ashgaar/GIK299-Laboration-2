using System;
using System.Diagnostics;
using System.Linq;

namespace Laboration_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            if (2<3){
                Console.WriteLine("hej");
            }
            bool showMenu = true;
            while (showMenu){
                showMenu = mainMenu();
            }
        }
        private static bool mainMenu(){
            //Skriver ut de olika alternativen.
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Gångertabellen");
            Console.WriteLine("2. Summa, medelvärde, högsta och lägsta");
            Console.WriteLine("3. RNG");
            Console.WriteLine("4. Avsluta");

            Console.Write("Välj ett alternativ: ");

            switch (Console.ReadLine())
            {
                case "1":
                multiplicationTable();
                return true;
                case "2":
                totalAverageHighestLowest();
                return true;
                case "3":
                randomNumberGenerator();
                return true;
                case "4":
                return false;
                //Eftersom att default är true så om man inte skriver inte nummer kommer den att returnera true vilket går tillbaks till menyn.
                default:
                return true;
            }
        }
        private static void multiplicationTable() {
            //Loopar igenom och skriver ut multiplikationstabellen.
            for(int i = 1; i <= 9; i++){
                for(int j = 1; j <= 9; j++){
                    int result = i*j;
                    Console.Write("{0} * {1} = {2}\t", i, j, result);
                }
                Console.WriteLine("");
            }
        }
        private static void totalAverageHighestLowest(){
            //Frågar hur många tal man vill ha.
            Console.Write("Skriv in hur många tal du vill ha: ");
            int lengthArray = Int32.Parse(Console.ReadLine());

            //Sätter längden på arrayen.
            int [] numbers = new int[lengthArray];

            //Frågar efter nummer.
            for(int i = 0; i < numbers.Length; i++){
                Console.Write("Fyll i nummer: ");
                int numbersArray = Int32.Parse(Console.ReadLine());
                numbers[i] = numbersArray;
            }

            //Beräkningar.
            int biggest = numbers.Max();
            int smallest = numbers.Min();
            int total = numbers.Sum();
            float average = (numbers.Sum()/(float)lengthArray);

            //Skriver ut beräkningarna
            Console.WriteLine("{0} är störst och {1} är minst. Medelvärdet är {2} och summan är {3}.", biggest, smallest, average, total);
        }

        private static void randomNumberGenerator(){
            //Frågar hur många tal som arrayen skall inkludera.
            Console.Write("Hur många tal vill du ha: ");
            int lengthArray = Int32.Parse(Console.ReadLine());
            
            //Deklarerar max och min värdet.
            int Min = 0;
            int Max = int.MaxValue;

            //Sätter längden på arrayen.
            int [] randomNumbers = new int[lengthArray];

            //Randomizing the numbers hells yeah brothers.
            Random randNum = new Random();
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = randNum.Next(Min, Max);
            }

            //Sorterar arrayen.
            Array.Sort(randomNumbers);

            //Skriver ut arrayen.
            Console.WriteLine("[{0}]", string.Join(", ", randomNumbers));
        }
    }
}
