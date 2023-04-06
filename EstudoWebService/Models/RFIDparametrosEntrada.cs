using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudoWebService.Models
{
    public class RFIDparametrosEntrada
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Tag { get; set; }
        public decimal Temperatura { get; set; }
        public decimal Umidade { get; set; }
    }
}