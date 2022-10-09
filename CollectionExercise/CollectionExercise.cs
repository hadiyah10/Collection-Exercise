using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExercise
{
    public class CollectionExercise
    {
       
        //Collection Exercise 
        public void CollectionTrainingExercise(int exitNumber)
        {
            try
            {
                int inputNum;
                bool parsedSuccessfully = false;

                //declaring queue
                Queue<int> queueOfNum = new Queue<int>();

                //declaring dictionary 
                Dictionary<int, int> dictionaryOfNum = new Dictionary<int, int>();

                //prompting user to input numbers 
                Console.WriteLine("Enter numbers");
                do
                {
                    parsedSuccessfully = int.TryParse(Console.ReadLine(), out inputNum);
                    if (parsedSuccessfully)
                    {
                        //inputting numbers in queue 
                        queueOfNum.Enqueue(inputNum);
                    }

                } while (inputNum != exitNumber);

                //declaring array 
                int[] intArr = new int[queueOfNum.Count];

                //declaring list
                List<int> intList = new List<int>(queueOfNum);

                int count = 0;
                foreach (int i in queueOfNum)
                {
                    //intArr.Append(i);
                    intArr[count] = i;
                    //intList.Add(i);
                    dictionaryOfNum.Add(count, i);
                    count++;
                }

                Console.WriteLine("====Elements in array===");
                foreach (int i in intArr)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("====Elements in List===");
                foreach (int i in intList)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("====Elements in Dictionary===");
                foreach (KeyValuePair<int, int> number in dictionaryOfNum)
                {
                    Console.WriteLine(number.Key + " " + number.Value);
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occured" + e);
            }
        }

        public static int SumOfEven(List<int> arr, bool onlyEven)
        {
            int total = 0;

            for (var i = 0; i < arr.Count; i++)
            {
                if (onlyEven || arr[i] % 2 == 0)
                {
                    total += arr[i];
                }
            }
            return total;
        }

        //displaying sum of all multiples of five 
        public static int SumOfMultipleFive(List<int> arr, bool multipleFive)
        {
            int total = 0;

            for (var i = 0; i < arr.Count; i++)
            {
                if (multipleFive || (arr[i] % 5 == 0))
                {

                    total += arr[i];
                }
            }
            return total;
        }

        //Displaying sum of even number  
        public void SumOfEvenNumbers()
        {

            int sum = 0;
            var inputs = new List<int>() { 2, 3, 5, 6, 7, 9, 10 };

            foreach (var i in inputs)
            {
                if (inputs[i] % 2 == 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine("The sum is " + sum);
        }

    }
}
