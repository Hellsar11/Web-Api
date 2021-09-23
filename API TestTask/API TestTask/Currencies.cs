using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TestTask
{
    public class Currencies
    {
        public string ID { get; set; }
        public string NumCode { get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public double Previous { get; set; }
    }
    public class Valute
    {
        public Currencies AUD { get; set; }
        public Currencies AZN { get; set; }
        public Currencies GBP { get; set; }
        public Currencies AMD { get; set; }
        public Currencies BYN { get; set; }
        public Currencies BGN { get; set; }
        public Currencies HUF { get; set; }
        public Currencies HKD { get; set; }
        public Currencies DKK { get; set; }
        public Currencies USD { get; set; }
        public Currencies EUR { get; set; }
        public Currencies INR { get; set; }
        public Currencies KZT { get; set; }
        public Currencies CAD { get; set; }
        public Currencies KGS { get; set; }
        public Currencies CNY { get; set; }
        public Currencies MDL { get; set; }
        public Currencies NOK { get; set; }
        public Currencies PLN { get; set; }
        public Currencies RON { get; set; }
        public Currencies XDR { get; set; }
        public Currencies SGD { get; set; }
        public Currencies TJS { get; set; }
        public Currencies TRY { get; set; }
        public Currencies TMT { get; set; }
        public Currencies UZS { get; set; }
        public Currencies UAH { get; set; }
        public Currencies CZK { get; set; }
        public Currencies SEK { get; set; }
        public Currencies CHF { get; set; }
        public Currencies ZAR { get; set; }
        public Currencies KRW { get; set; }
        public Currencies JPY { get; set; }

        public List<Currencies> GetCurr()
        {
            return new List<Currencies> { AMD, AZN, GBP, AMD, BYN, BGN, HUF, HKD, DKK, USD, EUR, INR, KZT, CAD, KGS, CNY, MDL, NOK, PLN, RON, XDR, SGD, TJS, TRY, TMT, UZS, UAH, CZK, SEK, CHF, ZAR, KRW, JPY };
        }
    }
    public class Currencies1
    {
        public string Date { get; set; }
        public string PreviousDate { get; set; }
        public string PreviousURL { get; set; }
        public string Timestamp { get; set; }
        public Valute Valute { get; set; }
    }
}
