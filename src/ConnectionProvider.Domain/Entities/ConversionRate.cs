using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionProvider.Core.Domain.Entity;
using System.Diagnostics.CodeAnalysis;

namespace ConnectionProvider.Domain.Entities
{
    public class ConversionRate : BaseEntity<int>
    {
        [AllowNull]
        public double? AED { get; set; } 
        [AllowNull]
        public double? ARS { get; set; } 
        [AllowNull]
        public double? AUD { get; set; } 
        [AllowNull]
        public double? BGN { get; set; } 
        [AllowNull]
        public double? BRL { get; set; } 
        [AllowNull]
        public double? BSD { get; set; } 
        [AllowNull]
        public double? CAD { get; set; } 
        [AllowNull]
        public double? CHF { get; set; } 
        [AllowNull]
        public double? CLP { get; set; } 
        [AllowNull]
        public double? CNY { get; set; } 
        [AllowNull]
        public double? COP { get; set; } 
        [AllowNull]
        public double? CZK { get; set; } 
        [AllowNull]
        public double? DKK { get; set; } 
        [AllowNull]
        public double? DOP { get; set; } 
        [AllowNull]
        public double? EGP { get; set; } 
        [AllowNull]
        public double? EUR { get; set; } 
        [AllowNull]
        public double? FJD { get; set; } 
        [AllowNull]
        public double? GBP { get; set; } 
        [AllowNull]
        public double? GTQ { get; set; } 
        [AllowNull]
        public double? HKD { get; set; } 
        [AllowNull]
        public double? HRK { get; set; } 
        [AllowNull]
        public double? HUF { get; set; } 
        [AllowNull]
        public double? IDR { get; set; } 
        [AllowNull]
        public double? ILS { get; set; } 
        [AllowNull]
        public double? INR { get; set; } 
        [AllowNull]
        public double? ISK { get; set; } 
        [AllowNull]
        public double? JPY { get; set; } 
        [AllowNull]
        public double? KRW { get; set; } 
        [AllowNull]
        public double? KZT { get; set; } 
        [AllowNull]
        public double? MXN { get; set; } 
        [AllowNull]
        public double? MYR { get; set; } 
        [AllowNull]
        public double? NOK { get; set; } 
        [AllowNull]
        public double? NZD { get; set; } 
        [AllowNull]
        public double? PAB { get; set; } 
        [AllowNull]
        public double? PEN { get; set; } 
        [AllowNull]
        public double? PHP { get; set; } 
        [AllowNull]
        public double? PKR { get; set; } 
        [AllowNull]
        public double? PLN { get; set; } 
        [AllowNull]
        public double? PYG { get; set; } 
        [AllowNull]
        public double? RON { get; set; } 
        [AllowNull]
        public double? RUB { get; set; } 
        [AllowNull]
        public double? SAR { get; set; } 
        [AllowNull]
        public double? SEK { get; set; } 
        [AllowNull]
        public double? SGD { get; set; } 
        [AllowNull]
        public double? THB { get; set; } 
        [AllowNull]
        public double? TRY { get; set; } 
        [AllowNull]
        public double? TWD { get; set; } 
        [AllowNull]
        public double? UAH { get; set; } 
        [AllowNull]
        public double? USD { get; set; } 
        [AllowNull]
        public double? UYU { get; set; } 
        [AllowNull]
        public double? ZAR { get; set; } 
        

        [ForeignKey("ExchangeRateData")]
        public int ExchangeRateDataId { get; set; } 
        public ExchangeRate ExchangeRateData { get; set; } 
    }
}
