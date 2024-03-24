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
using LiveCharts.WinForms;
using LiveCharts.Wpf.Charts.Base;
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Markup;
using System.Xml.Linq;
using LiveCharts.Definitions.Charts;

namespace Crypto_currency_Analyze_Forecasting.Forms
{
    public partial class AnalyzeWindow : Form
    {
        public List<IntervalCurrencyData> currencyData;
        public AnalyzeWindow()
        {
            InitializeComponent();
        }
        private void BuildChart()
        {

            var dates = new List<string>();
            var prices = new ChartValues<double>();

            foreach (var item in currencyData)
            {
                DateTime dateTime = DateTime.Parse(item.date);
                string formattedDateTime = dateTime.ToString("HH:mm dd.MM.yyyy");
                dates.Add(formattedDateTime);
                prices.Add(Convert.ToDouble(item.priceUsd));
            }

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = dates
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Price (USD)"
            });

            // Добавление серии данных на график
            cartesianChart1.Series.Add(new LineSeries
            {
                Title = "Price (USD)",
                Values = prices
            });


        }

        private void AnalyzeWindow_Load(object sender, EventArgs e)
        {
            BuildChart();
            panel1.Dock= DockStyle.Fill;
            panel1.Controls.Add(cartesianChart1);
            cartesianChart1.Dock = DockStyle.Fill;
        }
        public void SetCurrencyData(List<IntervalCurrencyData> data)
        {
            currencyData = data;
        }

    }
}
