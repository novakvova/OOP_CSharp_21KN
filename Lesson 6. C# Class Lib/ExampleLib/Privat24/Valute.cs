using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat24;

public class CurrencyRate
{
    public string? Ccy { get; set; }        // Валюта (наприклад, "USD")
    public string? BaseCcy { get; set; }    // Базова валюта (наприклад, "UAH")
    public string? Buy { get; set; }        // Купівля
    public string? Sale { get; set; }       // Продаж
}

