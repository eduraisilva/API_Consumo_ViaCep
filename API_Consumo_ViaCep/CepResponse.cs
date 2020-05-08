using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Consumo_ViaCep
{
    public class CepResponse
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("Logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("Complemento")]
        public string Complemento { get; set; }
        [JsonProperty("Bairro")]
        public string Bairro { get; set; }
        [JsonProperty("Localidade")]
        public string Localidade { get; set; }
        [JsonProperty("Uf")]
        public string Uf { get; set; }
        [JsonProperty("Unidade")]
        public string Unidade { get; set; }
        [JsonProperty("Ibge")]
        public string Ibge { get; set; }
        [JsonProperty("Gia")]
        public string Gia { get; set; }
    }
}
