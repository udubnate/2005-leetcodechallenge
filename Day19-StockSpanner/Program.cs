using System;
using System.Collections.Generic;

namespace Day19_StockSpanner
{
    class Program
    {
        static void Main(string[] args)
        {
             StockSpanner obj = new StockSpanner();
            int param_1 = obj.Next(100);
            int param_2 = obj.Next(80);
            int param_3 = obj.Next(60);
            int param_4 = obj.Next(70);
            int param_5 = obj.Next(60);
            int param_6 = obj.Next(75);
            int param_7 = obj.Next(85);

            Console.WriteLine("Hello World!");
        }
    }

    public class StockSpanner {
    List<int> intlist;
    public StockSpanner() {
       intlist = new List<int>();
    }
    
    public int Next(int price) {
        int count = 0;
        intlist.Add(price);

        for (int i = intlist.Count - 1; i >= 0; i--)
        {
            if (intlist[i] <= price){
                count++;
            }
            else {
                break;
            }
        }
        return count;
    }
}

}
