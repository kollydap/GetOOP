using System;
using System.Collections.Generic;
using System.Linq;

namespace BetterOOP
{
    class Program
    {
        private static IPainter FindCheapestPainter(double sqMeters, IEnumerable<IPainter> painters)
        {
            double bestPrice = 0;
            IPainter cheapest = null;

            foreach(IPainter painter in painters)
            {
                if (painter.IsAvailable)
                {
                    double price = painter.EstimateCompensation(sqMeters);
                    if (cheapest == null || price < bestPrice)
                    {
                        cheapest = painter;
                    }
                }
            }
            return cheapest;
        }

        private static IPainter FindCheapestPainter2(double sqMeters, IEnumerable<IPainter> painters)
        {
            return
                painters
                //returns a collection of Available painters
                    .Where(painter => painter.IsAvailable)
                    //then aranges them based on price 
                    .OrderBy(painter => painter.EstimateCompensation(sqMeters))
                   //returns the first which is the cheapest
                    .FirstOrDefault();

        }

        private static IPainter FindCheapestPainter3(double sqMeters, IEnumerable<IPainter> painters)
        {
            return
                painters
                    .Where(painter => painter.IsAvailable)
                    .OrderBy(painter => painter.EstimateCompensation(sqMeters))
                    .FirstOrDefault();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
