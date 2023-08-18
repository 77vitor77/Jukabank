using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAula1.Properties.clases
{
    internal class conta_cliente
    {
        public int idconta { get; set; }
        public int idcliente { get; set; }
        public double saldo { get; set; }
        public string status { get; set; }
        public double limite { get; set; }
        public string tipodeconta { get; set; }
        public DateTime diadeabertura { get; set; }
        public DateTime diadefechamento { get; set; }



    }
}
