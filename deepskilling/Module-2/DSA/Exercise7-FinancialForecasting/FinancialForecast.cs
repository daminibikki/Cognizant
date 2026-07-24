namespace FinancialForecasting
{
    public class FinancialForecast
    {
        public static double Forecast(double amount, double rate, int years)
        {
            if (years == 0)
                return amount;

            return Forecast(amount * (1 + rate), rate, years - 1);
        }
    }
}