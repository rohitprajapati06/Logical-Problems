using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Time_to_Buy_and_Sell_Stocks
{
    internal class Program
    {
        public int MaxProfit(int[] prices) {

            if (prices.Length == 0 || prices == null) { 
                return 0; 
            }

            int minprice = int.MaxValue;    // Initially min price will be Maximum value
            int maxprofit = 0;              // Profit will be 0 

            foreach(int price in prices)
            {
                if(price < minprice)
                {
                    minprice = price;
                }
                else if( price - minprice > maxprofit)
                {
                    maxprofit = price - minprice;
                }
            }
            return maxprofit;
        }
        static void Main(string[] args)
        {
            int[] prices = { 7, 2, 5, 1,4 };
            Program program = new Program();
            int Profit = program.MaxProfit(prices);
            Console.WriteLine("Maximum Profit after Selling stocks : "+Profit);

            Console.ReadKey();
        }
    }
}   /*                  LOGIC                               
     
                if(price < minprice)
                {
                    minprice = price;
                }

        if price will be less than minprice , then minprice willbe updated to price
        Ex . 4 < int.MaxValue
            minprice = 4        , 

If the above condition is false move to another
         else if( price - minprice > maxprofit)
         {
             maxprofit = price - minprice;
         }
        Ex.   price - updated minprice > maxprofit initially 0
              maxprofit = price - minprice

               5 - 2 > 0
                maxprofit = 5 - 2 = 3


    */
