using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace WebScraper
{
    class Program
    {
        static void Main(String[] args)
        {
            // Send get request to gismeteo.lt
            String url = "https://www.gismeteo.lt";
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url).Result;
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            // Get the temparature

            // Get the conditions

            // Get the location
        }
    }
}
