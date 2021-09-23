using DocumentFormat.OpenXml.Vml.Office;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace API_TestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrenciesController : ControllerBase
    {
        private readonly ILogger<CurrenciesController> _logger;
        WebClient client;
        Currencies1 c1;

        public CurrenciesController(ILogger<CurrenciesController> logger)
        {
            _logger = logger;
            client = new WebClient();
            string str = client.DownloadString("https://www.cbr-xml-daily.ru/daily_json.js");
            c1 = JsonSerializer.Deserialize<Currencies1>(str);

        }

        [HttpGet("{id}")]
        public string Currency(string id)
        {
            var get = c1.Valute.GetCurr().Where(x => x.ID == id);
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize<Currencies> (get.FirstOrDefault(), options);
            return json;
        }

        [HttpGet]
        public List<Currencies> Currencies()
        {
            var get = c1.Valute.GetCurr();           
            return get;
        }



    }
}
