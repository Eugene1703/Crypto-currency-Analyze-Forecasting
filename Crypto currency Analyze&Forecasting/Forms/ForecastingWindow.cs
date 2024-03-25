using Crypto_currency_Analyze_Forecasting.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_currency_Analyze_Forecasting.Forms
{
    public partial class ForecastingWindow : Form
    {
        List<IntervalCurrencyData> currencyDataList;
        int periodNumbers;
        public ForecastingWindow(List<IntervalCurrencyData> data)
        {
            InitializeComponent();
            this.currencyDataList = data;
        }

        private void ForecastingWindow_Load(object sender, EventArgs e)
        {
            periodNumbersLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            forecastPrintLabel.Font = new Font("Arial", 16, FontStyle.Bold);
        }

        private void makeForecastButton_Click(object sender, EventArgs e)
        {
            periodNumbers = Convert.ToInt32(periodNumbersTextBox.Text);
            ArimaModel arimaModel = new ArimaModel();
            double[] forecast = arimaModel.MakeForecast(currencyDataList, periodNumbers);

            forecastPrintLabel.Text = "Forecast value:\n";
            for (int i = 0; i < forecast.Length; i++)
            {
                forecastPrintLabel.Text += $"Period {i + 1}: PriceUSD {forecast[i]}\n";
            }
            if (arimaModel.recFlag)
            {
                forecastPrintLabel.Text += "We do not recommend investing in this currency.";
            }
            else forecastPrintLabel.Text += "We recommend investing in this currency.";
        }
    }
}
