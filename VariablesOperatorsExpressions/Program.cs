using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Stacey";
            Console.WriteLine(name);
            // case matters when naming variables
            name = "Dave";
            Console.WriteLine(name);
            
            string birthMonth = "June";
            Console.WriteLine(birthMonth);
            // integers
            int birthMonthNumber = 14;
            int age = 22;
            int populatioin = 33333;
            // floating type variables
            float number = 2.164403304897294383961032f;
            double someNumber = 2.164403304897294383961032d;
            decimal partialNumber = 2.164403304897294383961032m;

            //Console.WriteLine(number);
            //Console.WriteLine(someNumber);
            //Console.WriteLine(partialNumber);


            //Boolean
            bool isPresent = true;
            bool seatTaken = false;

            //Character
            char lastLetter = 's';


            int jessicaAge = 23;
            int samAge = 47;
            Console.WriteLine(jessicaAge > samAge);

            int mike = 13;
            int friend1 = 13;
            int friend2 = 13;
            int friend3 = 13;
            Console.WriteLine(mike + friend1 + friend2 + friend3);

            int friends = 4;
            int billEven = 13;
            int total = billEven * friends;
            Console.WriteLine(total);

            int cups = 7;
            int cupsHave = 2;
            Console.WriteLine(cups - cupsHave);

            // When dealing with money use float because of deciamls
            int money = 40;
            int cost = 8;
            Console.WriteLine(money / cost);

            int moneyHad = 29;
            int allMoney = 41;
            Console.WriteLine(allMoney + moneyHad);

            int juliaMiles = 47;
            Console.WriteLine(juliaMiles - 30);

            
            int totalMoney = 12;
            int envelopeCost = 3;
            int envelopes = totalMoney / envelopeCost;
             Console.WriteLine(envelopes);

            float saladPrice = 5.12f;
            float endOfBalance = 27.10f;
            //Console.WriteLine(saladPrice + endOfBalance);

            int totalStudents = 331;
            int totalBusStudents = totalStudents - 7;
            int studentsPerBus = totalBusStudents / 6;
            Console.WriteLine(totalBusStudents / 6);

            float aliyahMoney = 24f;
            float aliyahMoneyLeft = 10f;
            float pencils = 7;
            Console.WriteLine((aliyahMoney - aliyahMoneyLeft) / pencils);
            

            int sum = 72;
            int smallestx = (sum - 3) / 3;
            Console.WriteLine((sum-3) / 3);

            int totalNumber = 72;
            int middleNumber = totalNumber / 3;
            int maxNumber = middleNumber + 1;
            int smallNumber = middleNumber - 1;
            Console.WriteLine(smallNumber);

            int evenSum = 48;
            int smallestEvenx = (evenSum - 3) / 3;
            Console.WriteLine((evenSum - 3 / 3));

            int summ = 48;
            int numofNumbers = 3;
            int average = summ / numofNumbers;
            int smallestNumbers = average - 2;
            Console.WriteLine("This smallest number is" + smallestNumbers);

            int total1 = 48;
            int number1 = ((total1-6) / 3);
            Console.WriteLine(number1);

            int sumOfEvenNumbers = 48;
            int evenOne = sumOfEvenNumbers / 3;
            int evenTwo = evenOne - 2;
            int evenThree = evenOne + 2;
            Console.WriteLine(evenTwo);

             
            int boxesLeft = 22;
            int boxesBought = 7;
            int boxesStart = boxesLeft * 2;
            Console.WriteLine(boxesStart);
                 





            






            


            
            


            
            










       





        }
    }
}
