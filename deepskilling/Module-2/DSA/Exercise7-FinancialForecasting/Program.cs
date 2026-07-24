using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialAmount = 10000;
            double growthRate = 0.10;
            int years = 5;

            double futureValue = FinancialForecast.Forecast(
                initialAmount,
                growthRate,
                years
            );

            Console.WriteLine($"Future Value after {years} years: {futureValue:F2}");
        }
    }
}