using Crypto_currency_Analyze_Forecasting.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_currency_Analyze_Forecasting
{
    public partial class CryptoCurrencyWindow : Form
    {
        private List<ValidCurrencyData> currentValidCurrencyData;
        private CurrenciesApi currenciesApi;
        private List<IntervalCurrencyData> currencyDataList;
        private string currencyBlockchainExplorerUrl;
        public CryptoCurrencyWindow()
        {
            InitializeComponent();
            currenciesApi = new CurrenciesApi();
        }

        private void CryptoCurrencyWindow_Load(object sender, EventArgs e)
        {
            InitializeComboBoxInfo();
            currencyNameTextBox.Visible = false;
            chooseAnotherCurrencyButton.Visible = false;
            currencyNameTextBox.KeyPress += CurrencyNameTextBox_KeyPress;
            infoPrintLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            explorerLinkLabel.Font = new Font("Arial", 16, FontStyle.Bold);
        }

       

        private void InitializeComboBoxInfo()
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
                        currencyDataList = currenciesApi.GetIntervalCurrencyData($"{selectedCurrency.id}", "m1");
                        infoPrintLabel.Visible = true;

                        textBoxShow.Visible = false;
                        currencyNameTextBox.Visible = false;
                        chooseCurrentCurrency.Visible = false;
                        Title.Visible = false;
                        chooseAnotherCurrencyButton.Visible = true;
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
            CurrencyFromSelection(GetIdFromName(chooseCurrentCurrency.SelectedItem as string));
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
            currencyNameTextBox.Visible = true;
            chooseCurrentCurrency.Visible = true;
            Title.Visible = true;
            explorerLinkLabel.Visible = false;
            chooseCurrentCurrency.SelectedIndexChanged -= chooseCurrentCurrency_SelectedIndexChanged;
            chooseCurrentCurrency.SelectedItem = null;
            chooseCurrentCurrency.SelectedIndexChanged += chooseCurrentCurrency_SelectedIndexChanged;
        }

        private void explorerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(currencyBlockchainExplorerUrl);
        }
    }
}

