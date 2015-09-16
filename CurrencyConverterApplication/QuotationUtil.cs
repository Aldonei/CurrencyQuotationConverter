using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterApplication
{
    public class QuotationUtil
    {
        #region Read Content from CSV file from Banco Central
        public StringBuilder ReadContentFromUrl(string url) 
        {
            StringBuilder sb = new StringBuilder();
            try
            {   
                WebRequest request = WebRequest.Create(url);
                WebResponse result = request.GetResponse();
                Stream stream = result.GetResponseStream();
                byte[] read = new byte[512];
                int bytes = stream.Read(read, 0, 512);

                while (bytes > 0)
                {
                    Encoding enconding = Encoding.GetEncoding("ISO-8859-1");
                    sb.Append(enconding.GetString(read, 0, bytes));
                    bytes = stream.Read(read, 0, 512);
                }
            }
            catch (WebException  e) {
                // 404 - File not found.
                Console.WriteLine(e.Message);
            }

            return sb;
        }
        #endregion

        #region Fields Validation
        public List<string> ValidadteFiedls(string from, string to, string value, string quotationDate)
        {
            List<string> messages = new List<string>();
            decimal valueToCheck;
            bool convertDecimal = decimal.TryParse(value, out valueToCheck);

            DateTime dateToCheck;
            bool convertDate = DateTime.TryParse(quotationDate, out dateToCheck);

            if (string.IsNullOrEmpty(from))
                messages.Add("The field From must have a value.");
                
            if (string.IsNullOrEmpty(to))
                messages.Add("The field To must have a value.");

            if (convertDecimal)
            { 
                if (valueToCheck < 0)
                    messages.Add("The field Value must have a value greater than zero.");
            }
            else
                messages.Add(string.Format("Unable to convert value '{0}'", value));

            if (!convertDate || dateToCheck.Date > System.DateTime.Now.Date)
                messages.Add(string.Format("Invalid Date or Date is greater than current date. '{0}' - '{1}'", dateToCheck.Date.ToShortDateString(), System.DateTime.Now.Date.ToShortDateString()));

            return messages;
        }
        #endregion

        #region Calculate Quotation
        public List<string> CalculateQuotation(string from, string to, string value, string quotationDate)
        {
            string fromUser = from;
            string toUser = to;
            string fromCsv = string.Empty;
            string toCsv = string.Empty;
            decimal valueCsv = Convert.ToDecimal(value);
            decimal rateFrom = 0;
            decimal rateTo = 0;
            List<string> message = new List<string>();
            
            // Check correct date.
            DateTime dateToCheck;
            bool convertDate = DateTime.TryParse(quotationDate, out dateToCheck);
            dateToCheck = VerifyWeekend(dateToCheck);

            string url = string.Empty;
            // Get the CSV file name (20150910.csv) - Banco Central format.
            string csvFileName = string.Empty;
            if (convertDate) {
                csvFileName = string.Concat(dateToCheck.Year.ToString(), dateToCheck.Month.ToString().PadLeft(2, '0'), dateToCheck.Day.ToString().PadLeft(2, '0'), ".csv");
                url = string.Concat("http://www4.bcb.gov.br/Download/fechamento/", csvFileName);
            }

            // Get the content from de file 'url'.
            string contentCsv = ReadContentFromUrl(url).ToString();
            // If any problem has occurred with the url, the message will appear.
            if (string.IsNullOrEmpty(contentCsv)) {
                message.Add(string.Concat("Unable to get file CSV from ", url));
                return message;
            }

            // Split up by "Enter".
            string[] lines = contentCsv.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            // Split up each line by ';'. (-1 -> last line from file is empty)
            for (int i = 0; i < lines.Length - 1; i++)
            {
                // col[4] = Taxa Compra and col[3] = Moeda (EUR, USD, THA...)
                string[] col = lines[i].ToString().Split(';');
                if (fromUser.Equals(col[3].ToString())) { 
                    rateFrom = Convert.ToDecimal(col[4].ToString());
                    message.Add(string.Concat(col[0], " - ", col[1], " - ", col[2], " - ", col[3], " - ", col[4]));
                }

                if (toUser.Equals(col[3].ToString()))
                {
                    rateTo = Convert.ToDecimal(col[4].ToString());
                    message.Add(string.Concat(col[0], " - ", col[1], " - ", col[2], " - ", col[3], " - ", col[4]));
                }
            }

            try {
                decimal taxRate = (rateFrom / rateTo) * valueCsv;
                message.Add(string.Concat("Calculation ", "(", rateFrom.ToString(), " / ", rateTo.ToString(), ")", " * ", valueCsv.ToString()));
                message.Add(string.Concat("Currency Quotation = ", string.Format("{0:0,0.00}", taxRate)));
            }
            catch (Exception e) 
            {
                message.Add(e.Message); 
            }
            return message;
        }
        #endregion

        #region Vefify Weekend.
        private DateTime VerifyWeekend(DateTime dateToCheck)
        {
            DateTime weekDate = dateToCheck;
            // Get the currency from Friday, because currency from Monday will not be availabe yet by Banco Central.
            if (dateToCheck.DayOfWeek == DayOfWeek.Saturday)
                return weekDate = dateToCheck.AddDays(-1);

            if (dateToCheck.DayOfWeek == DayOfWeek.Sunday)
                return weekDate = dateToCheck.AddDays(-2);

            return weekDate;
        }
        #endregion
    }
}
        