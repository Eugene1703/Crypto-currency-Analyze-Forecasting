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
            this.chooseCurrentCurrency = new System.Windows.Forms.ComboBox();
            this.textBoxShow = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.currencyNameTextBox = new System.Windows.Forms.TextBox();
            this.infoPrintLabel = new System.Windows.Forms.Label();
            this.chooseAnotherCurrencyButton = new System.Windows.Forms.Button();
            this.explorerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // chooseCurrentCurrency
            // 
            this.chooseCurrentCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseCurrentCurrency.FormattingEnabled = true;
            this.chooseCurrentCurrency.Location = new System.Drawing.Point(12, 60);
            this.chooseCurrentCurrency.Name = "chooseCurrentCurrency";
            this.chooseCurrentCurrency.Size = new System.Drawing.Size(121, 21);
            this.chooseCurrentCurrency.TabIndex = 0;
            this.chooseCurrentCurrency.SelectedIndexChanged += new System.EventHandler(this.chooseCurrentCurrency_SelectedIndexChanged);
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(12, 120);
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
            this.Title.Location = new System.Drawing.Point(13, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(154, 13);
            this.Title.TabIndex = 2;
            this.Title.Text = "Choose availabe or enter name";
            // 
            // currencyNameTextBox
            // 
            this.currencyNameTextBox.Location = new System.Drawing.Point(12, 189);
            this.currencyNameTextBox.Name = "currencyNameTextBox";
            this.currencyNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.currencyNameTextBox.TabIndex = 3;
            // 
            // infoPrintLabel
            // 
            this.infoPrintLabel.AutoSize = true;
            this.infoPrintLabel.Location = new System.Drawing.Point(13, 13);
            this.infoPrintLabel.Name = "infoPrintLabel";
            this.infoPrintLabel.Size = new System.Drawing.Size(0, 13);
            this.infoPrintLabel.TabIndex = 4;
            // 
            // chooseAnotherCurrencyButton
            // 
            this.chooseAnotherCurrencyButton.Location = new System.Drawing.Point(631, 351);
            this.chooseAnotherCurrencyButton.Name = "chooseAnotherCurrencyButton";
            this.chooseAnotherCurrencyButton.Size = new System.Drawing.Size(75, 52);
            this.chooseAnotherCurrencyButton.TabIndex = 5;
            this.chooseAnotherCurrencyButton.Text = "Choose Another Currency";
            this.chooseAnotherCurrencyButton.UseVisualStyleBackColor = true;
            this.chooseAnotherCurrencyButton.Click += new System.EventHandler(this.chooseAnotherCurrencyButton_Click);
            // 
            // explorerLinkLabel
            // 
            this.explorerLinkLabel.AutoSize = true;
            this.explorerLinkLabel.Location = new System.Drawing.Point(13, 173);
            this.explorerLinkLabel.Name = "explorerLinkLabel";
            this.explorerLinkLabel.Size = new System.Drawing.Size(0, 13);
            this.explorerLinkLabel.TabIndex = 6;
            this.explorerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.explorerLinkLabel_LinkClicked);
            // 
            // CryptoCurrencyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}