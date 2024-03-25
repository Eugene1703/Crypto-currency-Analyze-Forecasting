namespace Crypto_currency_Analyze_Forecasting
{
    partial class CryptoCurrencyWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chooseCurrentCurrency = new System.Windows.Forms.ComboBox();
            this.textBoxShow = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.currencyNameTextBox = new System.Windows.Forms.TextBox();
            this.infoPrintLabel = new System.Windows.Forms.Label();
            this.chooseAnotherCurrencyButton = new System.Windows.Forms.Button();
            this.explorerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalComboBox = new System.Windows.Forms.ComboBox();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.forecastingButton = new System.Windows.Forms.Button();
            this.minMaxChangeCurrency = new System.Windows.Forms.ListBox();
            this.getDataFromDatabaseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chooseCurrentCurrency
            // 
            this.chooseCurrentCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseCurrentCurrency.FormattingEnabled = true;
            this.chooseCurrentCurrency.Location = new System.Drawing.Point(186, 60);
            this.chooseCurrentCurrency.Name = "chooseCurrentCurrency";
            this.chooseCurrentCurrency.Size = new System.Drawing.Size(121, 21);
            this.chooseCurrentCurrency.TabIndex = 0;
            this.chooseCurrentCurrency.SelectedIndexChanged += new System.EventHandler(this.chooseCurrentCurrency_SelectedIndexChanged);
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(186, 120);
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(121, 40);
            this.textBoxShow.TabIndex = 1;
            this.textBoxShow.Text = "Enter name";
            this.textBoxShow.UseVisualStyleBackColor = true;
            this.textBoxShow.Click += new System.EventHandler(this.textBoxShow_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(183, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(154, 13);
            this.Title.TabIndex = 2;
            this.Title.Text = "Choose availabe or enter name";
            // 
            // currencyNameTextBox
            // 
            this.currencyNameTextBox.Location = new System.Drawing.Point(186, 189);
            this.currencyNameTextBox.Name = "currencyNameTextBox";
            this.currencyNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.currencyNameTextBox.TabIndex = 3;
            // 
            // infoPrintLabel
            // 
            this.infoPrintLabel.AutoSize = true;
            this.infoPrintLabel.Location = new System.Drawing.Point(21, 13);
            this.infoPrintLabel.Name = "infoPrintLabel";
            this.infoPrintLabel.Size = new System.Drawing.Size(0, 13);
            this.infoPrintLabel.TabIndex = 4;
            // 
            // chooseAnotherCurrencyButton
            // 
            this.chooseAnotherCurrencyButton.Location = new System.Drawing.Point(631, 351);
            this.chooseAnotherCurrencyButton.Name = "chooseAnotherCurrencyButton";
            this.chooseAnotherCurrencyButton.Size = new System.Drawing.Size(112, 68);
            this.chooseAnotherCurrencyButton.TabIndex = 5;
            this.chooseAnotherCurrencyButton.Text = "Choose Another Currency or Interval";
            this.chooseAnotherCurrencyButton.UseVisualStyleBackColor = true;
            this.chooseAnotherCurrencyButton.Click += new System.EventHandler(this.chooseAnotherCurrencyButton_Click);
            // 
            // explorerLinkLabel
            // 
            this.explorerLinkLabel.AutoSize = true;
            this.explorerLinkLabel.Location = new System.Drawing.Point(21, 172);
            this.explorerLinkLabel.Name = "explorerLinkLabel";
            this.explorerLinkLabel.Size = new System.Drawing.Size(0, 13);
            this.explorerLinkLabel.TabIndex = 6;
            this.explorerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.explorerLinkLabel_LinkClicked);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(21, 13);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(146, 13);
            this.intervalLabel.TabIndex = 8;
            this.intervalLabel.Text = "Select the data validity period";
            // 
            // intervalComboBox
            // 
            this.intervalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalComboBox.FormattingEnabled = true;
            this.intervalComboBox.Location = new System.Drawing.Point(24, 60);
            this.intervalComboBox.Name = "intervalComboBox";
            this.intervalComboBox.Size = new System.Drawing.Size(121, 21);
            this.intervalComboBox.TabIndex = 9;
            this.intervalComboBox.SelectedIndexChanged += new System.EventHandler(this.intervalComboBox_SelectedIndexChanged);
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(421, 351);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(99, 68);
            this.analyzeButton.TabIndex = 7;
            this.analyzeButton.Text = "Analyze\r\n";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // forecastingButton
            // 
            this.forecastingButton.Location = new System.Drawing.Point(526, 351);
            this.forecastingButton.Name = "forecastingButton";
            this.forecastingButton.Size = new System.Drawing.Size(99, 68);
            this.forecastingButton.TabIndex = 10;
            this.forecastingButton.Text = "Forecasting";
            this.forecastingButton.UseVisualStyleBackColor = true;
            this.forecastingButton.Click += new System.EventHandler(this.forecastingButton_Click);
            // 
            // minMaxChangeCurrency
            // 
            this.minMaxChangeCurrency.FormattingEnabled = true;
            this.minMaxChangeCurrency.Location = new System.Drawing.Point(381, 13);
            this.minMaxChangeCurrency.Name = "minMaxChangeCurrency";
            this.minMaxChangeCurrency.Size = new System.Drawing.Size(407, 160);
            this.minMaxChangeCurrency.TabIndex = 11;
            // 
            // getDataFromDatabaseButton
            // 
            this.getDataFromDatabaseButton.Location = new System.Drawing.Point(631, 215);
            this.getDataFromDatabaseButton.Name = "getDataFromDatabaseButton";
            this.getDataFromDatabaseButton.Size = new System.Drawing.Size(112, 68);
            this.getDataFromDatabaseButton.TabIndex = 13;
            this.getDataFromDatabaseButton.Text = "Get data from Database";
            this.getDataFromDatabaseButton.UseVisualStyleBackColor = true;
            this.getDataFromDatabaseButton.Click += new System.EventHandler(this.getDataFromDatabaseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CryptoCurrencyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getDataFromDatabaseButton);
            this.Controls.Add(this.minMaxChangeCurrency);
            this.Controls.Add(this.forecastingButton);
            this.Controls.Add(this.intervalComboBox);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.explorerLinkLabel);
            this.Controls.Add(this.chooseAnotherCurrencyButton);
            this.Controls.Add(this.infoPrintLabel);
            this.Controls.Add(this.currencyNameTextBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.textBoxShow);
            this.Controls.Add(this.chooseCurrentCurrency);
            this.Name = "CryptoCurrencyWindow";
            this.Text = "CryproCurrencyWindow";
            this.Load += new System.EventHandler(this.CryptoCurrencyWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chooseCurrentCurrency;
        private System.Windows.Forms.Button textBoxShow;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox currencyNameTextBox;
        private System.Windows.Forms.Label infoPrintLabel;
        private System.Windows.Forms.Button chooseAnotherCurrencyButton;
        private System.Windows.Forms.LinkLabel explorerLinkLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.ComboBox intervalComboBox;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Button forecastingButton;
        private System.Windows.Forms.ListBox minMaxChangeCurrency;
        private System.Windows.Forms.Button getDataFromDatabaseButton;
        private System.Windows.Forms.Timer timer1;
    }
}