using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.ModelMap
{
    public class Currency
    {
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyType { get; set; }
        public string BuyCash { get; set; }
        public string BuyTransfer { get; set; }
        public string SaleCash { get; set; }
        public string SaleTransfer { get; set; }
        public DateTime Date { get; set; }
        public int EffCode { get; set; }
    }

    public class CurencyConvert
    {
        public string CurrencyCode { get; set; }
        public double ConvertCurrency { get; set; }
    }

    public class CurencyChart
    {
        public string CurrencyCode { get; set; }
        public decimal AvgCurrency { get; set; }
        public string StringDate { get; set; }
    }
}
