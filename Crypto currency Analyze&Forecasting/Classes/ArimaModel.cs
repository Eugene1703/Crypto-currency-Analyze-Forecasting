using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_currency_Analyze_Forecasting.Classes
{
    public class ArimaModel
    {
        public bool recFlag=true;
        public double[] MakeForecast(List<IntervalCurrencyData> intervalCurrencyData, int periodNumbers)
        {
            const int n = 1440;
            double[] timeSeries = intervalCurrencyData.Select(data=> (double)data.priceUsd).ToArray();
            double[] forecast = new double[n];

            double alpha = 0.1;
            for (int i = 1; i < n; i++)
            {
                forecast[i] = alpha * timeSeries[i - 1] + (1 - alpha) * forecast[i - 1];
            }
            double[] periodForecast = new double[periodNumbers];
            for (int i = n - 10, a = 0; i < n; a++, i++)
            {
                periodForecast[a] = forecast[i];
            }
            double realSum=0, forecastSum=0;
            for (int i = 0; i < periodNumbers; i++)
            {
                forecastSum += periodForecast[i];
                realSum +=timeSeries[n - periodNumbers + i];
            }
            if(forecastSum< realSum) { recFlag = false; }
            return periodForecast;
        }
    }
}
