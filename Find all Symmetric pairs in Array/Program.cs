using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {

        public static void SymmetricPair(int[,] arr)
        {

       //List can accept only 1 parameter, so  ( int , int) converts to int
           
            List<(int, int)> pair = new List<(int, int)>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            // arr.GetLength(0) : use for 2D array to get the numbers of rows    , arr.GetLength(1) : gives column   
            for (int i = 0; i < arr.GetLength(0); i++) 
            {

             int first = arr[i, 0];// arrays i row , 0th index column = 1 column
             int second = arr[i, 1];// arrays i row ,1th index column = 2 column


                if (dict.ContainsKey(second) && dict[second] == first)
                {

                    pair.Add((second, first));
                }
                else
                {

                    if (!dict.ContainsKey(second))
                    {

                        dict[first] = second;
                    }
                }

            }

            Console.WriteLine("Symmetric pair in an array");
            foreach (var i in pair)
            {
                Console.WriteLine(" { " + i.Item1 + " : " + i.Item2 + " }");
            }
        }
        public static void Main(string[] args)
        {
            int[,] arr = {                  // Two dimensional array
                            { 1, 2 }, 
                            { 3, 5 }, 
                            { 2, 1 }, 
                            { 5, 3 }, 
                            { 2, 5 } 
                         };

            SymmetricPair(arr);

        }
    }
}


/*                              LOGIC                      
          
                if (dict.ContainsKey(second) && dict[second] == first)
                {

                    pair.Add((second, first));
                }


1)         dict.ContainsKey(second)

Ex . (1 ,2 ) ,( 3,5 ) , (2 ,1)

on a current third pair (2 , 1)  ,  second = 1 
so its check if 1 is present as a key in dict


2)      dict[second] == first)
Ex . (1 ,2 ) ,( 3,5 ) , (2 ,1)
on a current third pair (2 , 1)  ,  second = 1 
i.e  dict[1] == first  ,     
           
dict[1] means with key 1 and its corresponding value will be there  i.e  2
on a current third pair first = 2
dict[1] value is 2 
so 2 == 2 


It will get in List 
        pair.Add((second, first));

List can accept only one argument so its added as Tuple  ( (second, first) )



3)        if (!dict.ContainsKey(second)){
                dict[first] = second;

        key not contains
then add it in dict , 
         dict[first] = second

         dict first is key , and second is value


4)   Console.WriteLine(" { " + i.Item1 + " : " + i.Item2 + " }");

      while printing since it add as tuple in list  ,
                we have to access it using Item1 and Item2
*/