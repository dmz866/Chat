using FileHelpers;
using System;

namespace Chat.Core.Entities
{
    [DelimitedRecord(",")]
    [IgnoreFirst]
    public class Stock
    {
        public string Symbol { get; set; }
        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd")]
        public DateTime Date { get; set; }
        [FieldConverter(ConverterKind.Date, "HH:mm:ss")] 
        public DateTime Time { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
    }
}
