using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudoWebService.Models
{
    public class Teste
    {
        public string Empresa { get; set; }
        public string Unidade { get; set; }
        public DateTime Data { get; set; }
        public decimal Temperatura { get; set; }
        public decimal Umidade { get; set; }
        public string Presentes { get; set; }
    }
}
