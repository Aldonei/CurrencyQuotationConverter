using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterApplication
{
    public partial class frmCurrencyConverter : Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
            txtQuotationDate.Value = System.DateTime.Now.Date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxLog.BeginUpdate();
            lbxLog.Items.Clear();
            lbxLog.Items.Add("Initiating Calculation");
            lbxLog.EndUpdate();

            QuotationUtil quotationUtil = new QuotationUtil();
            // Check if all fields are filled up and correct.
            List<string> messages = quotationUtil.ValidadteFiedls(cbxFrom.Text, cbxTo.Text, txtValue.Text, txtQuotationDate.Text);
            if (messages.Count > 0)
            {
                lbxLog.Items.Add("****************************************");
                lbxLog.Items.Add("    Unable to validate some fields      ");
                lbxLog.Items.Add("****************************************");

                for (int i = 0; i < messages.Count; i++)
                {
                    lbxLog.BeginUpdate();
                    lbxLog.Items.Add(messages.ElementAt(i));
                    lbxLog.EndUpdate();
                }
                return;
            }

            List<string> calculationMessages = quotationUtil.CalculateQuotation(cbxFrom.Text, cbxTo.Text, txtValue.Text, txtQuotationDate.Text);

            lbxLog.Items.Add("**********************************");
            lbxLog.Items.Add("           R E S U L T            ");
            lbxLog.Items.Add("**********************************");
            for (int i = 0; i < calculationMessages.Count; i++)
            {
                lbxLog.BeginUpdate();
                lbxLog.Items.Add(calculationMessages.ElementAt(i));
                lbxLog.EndUpdate();
            }
            lbxLog.Items.Add("End of Calculation");

        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals((char)8); // 8 = backspace
            if (e.KeyChar.Equals((char)13)) // 13 = Enter
                txtValue.Text = string.Format("{0:n0}", double.Parse(txtValue.Text));
        }

    }
}
