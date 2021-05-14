using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.RecaptchaValidator
{
    public class Recaptcha
    {
        [JsonProperty("success")]
        public bool Success { get; set; }


        [JsonProperty("error-codes")]
        public List<string> ErrorMessage { get; set; }

        public static bool Validate(string encodedResponse)
        {
            if (string.IsNullOrEmpty(encodedResponse)) return false;

            var client = new System.Net.WebClient();
            var secretPrivateKey = "6LdcU9QaAAAAAJ_3AEH58FearqJTGXsqp0bwpZrb";

            if (string.IsNullOrEmpty(secretPrivateKey)) return false;

            var googleReply = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretPrivateKey, encodedResponse));

            var captchaResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<Recaptcha>(googleReply);

            return captchaResponse.Success;


        }

    }
}