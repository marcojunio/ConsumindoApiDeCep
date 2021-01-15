using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsumindoApiCep
{
    public class CepResponse
    {   
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("rua")]
        public string Rua { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("ibge")]
        public string Ibge { get; set; }
        [JsonProperty("complemento")]
        public string Complemento  { get; set; }
        [JsonProperty("uf")]
        public string Uf { get; set; }

    }
}
