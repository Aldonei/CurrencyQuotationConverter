namespace CurrencyConverterApplication
{
    partial class frmCurrencyConverter
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
            this.btnGetQuotation = new System.Windows.Forms.Button();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cbxFrom = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbxTo = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuotationDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetQuotation
            // 
            this.btnGetQuotation.Location = new System.Drawing.Point(54, 91);
            this.btnGetQuotation.Name = "btnGetQuotation";
            this.btnGetQuotation.Size = new System.Drawing.Size(148, 33);
            this.btnGetQuotation.TabIndex = 0;
            this.btnGetQuotation.Text = "Get Quotation";
            this.btnGetQuotation.UseVisualStyleBackColor = true;
            this.btnGetQuotation.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxLog
            // 
            this.lbxLog.FormattingEnabled = true;
            this.lbxLog.ItemHeight = 16;
            this.lbxLog.Location = new System.Drawing.Point(54, 130);
            this.lbxLog.Name = "lbxLog";
            this.lbxLog.Size = new System.Drawing.Size(607, 244);
            this.lbxLog.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(9, 14);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 17);
            this.lblFrom.TabIndex = 5;
            this.lblFrom.Text = "From";
            // 
            // cbxFrom
            // 
            this.cbxFrom.FormattingEnabled = true;
            this.cbxFrom.Items.AddRange(new object[] {
            "AFN",
            "ETB",
            "THB",
            "PAB",
            "VEF",
            "BOB",
            "GHS",
            "CRC",
            "SVC",
            "NIO",
            "DKK",
            "ISK",
            "NOK",
            "SEK",
            "CZK",
            "GMD",
            "DZD",
            "KWD",
            "BHD",
            "IQD",
            "JOD",
            "LYD",
            "MKD",
            "RSD",
            "SDG",
            "TND",
            "SSP",
            "SDR",
            "MAD",
            "AED",
            "STD",
            "AUD",
            "BSD",
            "BMD",
            "CAD",
            "GYD",
            "NAD",
            "BBD",
            "BZD",
            "BND",
            "KYD",
            "SGD",
            "CLF",
            "FJD",
            "HKD",
            "TTD",
            "XCD",
            "USD",
            "JMD",
            "LRD",
            "NZD",
            "SBD",
            "SRD",
            "VND",
            "AMD",
            "CVE",
            "ANG",
            "AWG",
            "HUF",
            "CDF",
            "BIF",
            "KMF",
            "XAF",
            "XOF",
            "XPF",
            "DJF",
            "GNF",
            "MGA",
            "RWF",
            "CHF",
            "HTG",
            "PYG",
            "UAH",
            "JPY",
            "GEL",
            "ALL",
            "HNL",
            "SLL",
            "MDL",
            "RON",
            "BGN",
            "GIP",
            "EGP",
            "GBP",
            "FKP",
            "LBP",
            "SHP",
            "SYP",
            "SZL",
            "LSL",
            "TMT",
            "MZN",
            "ERN",
            "NGN",
            "AOA",
            "TWD",
            "TRY",
            "PEN",
            "BTN",
            "MRO",
            "TOP",
            "MOP",
            "ARS",
            "CLP",
            "COP",
            "CUP",
            "DOP",
            "PHP",
            "MXN",
            "UYU",
            "BWP",
            "MWK",
            "ZMW",
            "GTQ",
            "MMK",
            "PGK",
            "HRK",
            "LAK",
            "ZAR",
            "CNY",
            "CNH",
            "QAR",
            "OMR",
            "YER",
            "IRR",
            "SAR",
            "KHR",
            "MYR",
            "BYR",
            "RUB",
            "TJS",
            "MUR",
            "NPR",
            "SCR",
            "LKR",
            "INR",
            "IDR",
            "MVR",
            "PKR",
            "ILS",
            "KGS",
            "UZS",
            "BDT",
            "WST",
            "KZT",
            "MNT",
            "VUV",
            "KRW",
            "TZS",
            "KES",
            "UGX",
            "SOS",
            "PLN",
            "EUR",
            "XAU"});
            this.cbxFrom.Location = new System.Drawing.Point(54, 12);
            this.cbxFrom.Name = "cbxFrom";
            this.cbxFrom.Size = new System.Drawing.Size(60, 24);
            this.cbxFrom.TabIndex = 4;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(116, 15);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 17);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To";
            // 
            // cbxTo
            // 
            this.cbxTo.FormattingEnabled = true;
            this.cbxTo.Items.AddRange(new object[] {
            "AFN",
            "ETB",
            "THB",
            "PAB",
            "VEF",
            "BOB",
            "GHS",
            "CRC",
            "SVC",
            "NIO",
            "DKK",
            "ISK",
            "NOK",
            "SEK",
            "CZK",
            "GMD",
            "DZD",
            "KWD",
            "BHD",
            "IQD",
            "JOD",
            "LYD",
            "MKD",
            "RSD",
            "SDG",
            "TND",
            "SSP",
            "SDR",
            "MAD",
            "AED",
            "STD",
            "AUD",
            "BSD",
            "BMD",
            "CAD",
            "GYD",
            "NAD",
            "BBD",
            "BZD",
            "BND",
            "KYD",
            "SGD",
            "CLF",
            "FJD",
            "HKD",
            "TTD",
            "XCD",
            "USD",
            "JMD",
            "LRD",
            "NZD",
            "SBD",
            "SRD",
            "VND",
            "AMD",
            "CVE",
            "ANG",
            "AWG",
            "HUF",
            "CDF",
            "BIF",
            "KMF",
            "XAF",
            "XOF",
            "XPF",
            "DJF",
            "GNF",
            "MGA",
            "RWF",
            "CHF",
            "HTG",
            "PYG",
            "UAH",
            "JPY",
            "GEL",
            "ALL",
            "HNL",
            "SLL",
            "MDL",
            "RON",
            "BGN",
            "GIP",
            "EGP",
            "GBP",
            "FKP",
            "LBP",
            "SHP",
            "SYP",
            "SZL",
            "LSL",
            "TMT",
            "MZN",
            "ERN",
            "NGN",
            "AOA",
            "TWD",
            "TRY",
            "PEN",
            "BTN",
            "MRO",
            "TOP",
            "MOP",
            "ARS",
            "CLP",
            "COP",
            "CUP",
            "DOP",
            "PHP",
            "MXN",
            "UYU",
            "BWP",
            "MWK",
            "ZMW",
            "GTQ",
            "MMK",
            "PGK",
            "HRK",
            "LAK",
            "ZAR",
            "CNY",
            "CNH",
            "QAR",
            "OMR",
            "YER",
            "IRR",
            "SAR",
            "KHR",
            "MYR",
            "BYR",
            "RUB",
            "TJS",
            "MUR",
            "NPR",
            "SCR",
            "LKR",
            "INR",
            "IDR",
            "MVR",
            "PKR",
            "ILS",
            "KGS",
            "UZS",
            "BDT",
            "WST",
            "KZT",
            "MNT",
            "VUV",
            "KRW",
            "TZS",
            "KES",
            "UGX",
            "SOS",
            "PLN",
            "EUR",
            "XAU"});
            this.cbxTo.Location = new System.Drawing.Point(139, 12);
            this.cbxTo.Name = "cbxTo";
            this.cbxTo.Size = new System.Drawing.Size(63, 24);
            this.cbxTo.TabIndex = 6;
            // 
            // txtValue
            // 
            this.txtValue.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.txtValue.Location = new System.Drawing.Point(54, 39);
            this.txtValue.MaxLength = 18;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(148, 22);
            this.txtValue.TabIndex = 11;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Value";
            // 
            // txtQuotationDate
            // 
            this.txtQuotationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtQuotationDate.Location = new System.Drawing.Point(54, 63);
            this.txtQuotationDate.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.txtQuotationDate.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.txtQuotationDate.Name = "txtQuotationDate";
            this.txtQuotationDate.Size = new System.Drawing.Size(148, 22);
            this.txtQuotationDate.TabIndex = 16;
            this.txtQuotationDate.Value = new System.DateTime(2015, 9, 15, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(9, 64);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(9, 130);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(32, 17);
            this.lblLog.TabIndex = 17;
            this.lblLog.Text = "Log";
            // 
            // frmCurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 386);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtQuotationDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.cbxTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cbxFrom);
            this.Controls.Add(this.lbxLog);
            this.Controls.Add(this.btnGetQuotation);
            this.Name = "frmCurrencyConverter";
            this.Text = "Currency Converter 2015";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetQuotation;
        private System.Windows.Forms.ListBox lbxLog;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cbxFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cbxTo;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtQuotationDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLog;
    }
}

