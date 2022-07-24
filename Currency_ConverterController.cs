using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Currency_Converter.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Currency_Converter.Controllers
{
    public class Currency_ConverterController : ApiController
    {
        Currency Currency = new Currency();
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(string from, int amount, string to)
        {
            //double USDtoINR;
            //double conversion;
            //if (from == "USD" && to=="INR")
            //{
            //    double oneUSDtoINR = 79.85;
                
            //    conversion = amount * oneUSDtoINR;
            //}
            //else if (from == "EUR" && to == "USD")
            //{
            //    double oneEURtoUSD = 1.02;

            //    conversion = amount * oneEURtoUSD;
            //}
            return "Success";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        
        public void Delete(int id)
        {
        }

        [HttpGet]
        public float convert(string fromCurrency,float amount,string toCurrency)
        {
            //string fromCurrency = "EUR";
            //string toCurrency = "USD";
            //int amount = 1;

            
            string[] availableCurrency = Currency.GetCurrencyTags();
           
            
            float exchangeRate = Currency.GetExchangeRate(fromCurrency, toCurrency, amount);

            return exchangeRate;
        }
    }
}