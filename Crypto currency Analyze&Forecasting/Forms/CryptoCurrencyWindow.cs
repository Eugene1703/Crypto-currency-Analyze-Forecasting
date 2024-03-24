using Crypto_currency_Analyze_Forecasting.Classes;
using Crypto_currency_Analyze_Forecasting.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Crypto_currency_Analyze_Forecasting
{
    public partial class CryptoCurrencyWindow : Form
    {
        private List<ValidCurrencyData> currentValidCurrencyData;
        private CurrenciesApi currenciesApi;
        private List<IntervalCurrencyData> currencyDataList;
        private string currencyBlockchainExplorerUrl;
        string selectedInterval;
        public CryptoCurrencyWindow()
        {
            InitializeComponent();
            currenciesApi = new CurrenciesApi();
        }

        private void CryptoCurrencyWindow_Load(object sender, EventArgs e)
        {
            InitializeCurrencyComboBoxInfo();
            InitializeIntervalComboBoxInfo();
            currencyNameTextBox.Visible = false;
            chooseAnotherCurrencyButton.Visible = false;
            analyzeButton.Visible = false;
            currencyNameTextBox.KeyPress += CurrencyNameTextBox_KeyPress;
            infoPrintLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            explorerLinkLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            forecastingButton.Visible = false;
        }
         
       private void InitializeIntervalComboBoxInfo()
       {
            Dictionary<string, string> periodValues = new Dictionary<string, string>
            {
                {"Day", "m1"},
                {"Five Days", "m5"},
                {"Week", "m15"},
                {"Two Weeks", "m30"},
                {"Month", "h1"},
                {"Two Months", "h2"},
                {"Six Months", "h6"},
                {"Twelve Months", "h12"}
            };
            foreach (var pair in periodValues)
            {
                intervalComboBox.Items.Add(new ComboboxItem(pair.Key, pair.Value));
            }
        }
        private void InitializeCurrencyComboBoxInfo()
        {
            int width = 0;
            currentValidCurrencyData = currenciesApi.GetValidCurrencyData();
            foreach(var currency in currentValidCurrencyData)
            {
                chooseCurrentCurrency.Items.Add(currency.name);
                int txtLength = currency.name.ToString().Length;
                if (txtLength > width)
                {
                    width = txtLength;
                }
            }
            chooseCurrentCurrency.DropDownWidth = TextRenderer.MeasureText(new string('W', width / 2 + 2), chooseCurrentCurrency.Font).Width;
        }

        private void textBoxShow_Click(object sender, EventArgs e)
        {
            currencyNameTextBox.Visible = true;
        }
        private string GetIdFromName(string name)
        {
            ValidCurrencyData selectedCurrency = currentValidCurrencyData.FirstOrDefault(currency => currency.name == name);
            return selectedCurrency != null ? selectedCurrency.id : null;
        }
        private void PrintInfo(ValidCurrencyData selectedCurrency)
        {
            infoPrintLabel.Text= $"Name: {selectedCurrency.name}\n" +
                                 $"ID: {selectedCurrency.id}\n" +
                                 $"Price USD: {selectedCurrency.priceUsd}\n" +
                                 $"Change Percent 24Hr: {selectedCurrency.changePercent24Hr}\n" +
                                 $"Supply: {selectedCurrency.supply}\n" +
                                 $"Volume USD 24Hr: {selectedCurrency.volumeUsd24Hr}\n";
            explorerLinkLabel.Text = $"{selectedCurrency.name} Explorer";
            currencyBlockchainExplorerUrl = selectedCurrency.explorer;
        }
        private void CurrencyFromSelection(string id)
        {
            try
            {
                if (id!=null)
                {
                    ValidCurrencyData selectedCurrency = currentValidCurrencyData.FirstOrDefault(currency => currency.id == id);
                    if (selectedCurrency != null)
                    {
                        currencyDataList = currenciesApi.GetIntervalCurrencyData($"{selectedCurrency.id}", selectedInterval);
                        infoPrintLabel.Visible = true;
                        analyzeButton.Visible=true;
                        textBoxShow.Visible = false;
                        currencyNameTextBox.Visible = false;
                        chooseCurrentCurrency.Visible = false;
                        Title.Visible = false;
                        intervalComboBox.Visible = false;
                        intervalLabel.Visible = false;
                        chooseAnotherCurrencyButton.Visible = true;
                        forecastingButton.Visible = true;
                        PrintInfo(selectedCurrency);
                    }
                    else throw new Exception("There is no currency with such a name");
                }
                else throw new Exception("Please check the entered data");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void chooseCurrentCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedInterval != null)
            {
                CurrencyFromSelection(GetIdFromName(chooseCurrentCurrency.SelectedItem as string));
            }
            else { MessageBox.Show("Select the data validity period"); }
        }
        private void CurrencyNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CurrencyFromSelection(currencyNameTextBox.Text.ToLower());
            }
        }

        private void chooseAnotherCurrencyButton_Click(object sender, EventArgs e)
        {
            chooseAnotherCurrencyButton.Visible = false;
            infoPrintLabel.Visible=false;
            textBoxShow.Visible = true;
            currencyNameTextBox.Visible = false;
            chooseCurrentCurrency.Visible = true;
            Title.Visible = true;
            explorerLinkLabel.Visible = false;
            analyzeButton.Visible = false;
            chooseCurrentCurrency.SelectedIndexChanged -= chooseCurrentCurrency_SelectedIndexChanged;
            chooseCurrentCurrency.SelectedItem = null;
            chooseCurrentCurrency.SelectedIndexChanged += chooseCurrentCurrency_SelectedIndexChanged;
            intervalComboBox.SelectedIndexChanged -= intervalComboBox_SelectedIndexChanged;
            intervalComboBox.SelectedItem = null;
            intervalComboBox.SelectedIndexChanged += intervalComboBox_SelectedIndexChanged;
            intervalComboBox.Visible = true;
            intervalLabel.Visible = true;
            forecastingButton.Visible = false;
        }

        private void explorerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(currencyBlockchainExplorerUrl);
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            AnalyzeWindow analyzeWindow = new AnalyzeWindow();
            analyzeWindow.SetCurrencyData(currencyDataList);
            analyzeWindow.Show();
        }

        private void intervalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem selectedItem = (ComboboxItem)intervalComboBox.SelectedItem;
            selectedInterval = selectedItem.Value.ToString();
        }
    }
}

