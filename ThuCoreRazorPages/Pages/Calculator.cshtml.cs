using System;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ThuCoreRazorPages.Pages
{
    public class CalculatorModel : PageModel
    {
        public Decimal Pounds { get; set; }

        public Decimal Euros { get; set; }

        public CultureInfo Portugal = new CultureInfo("pt-PT");

        public string currencyFormat = "C2";

        public void OnGet()
        {
            Pounds = 0m;
            Euros = 0m;
        }


        public void OnPost()
        {
            string value = Request.Form["Pounds"];
            Pounds = Convert.ToDecimal(value);

            Euros = Pounds * 1.12m;
        }
    }
}