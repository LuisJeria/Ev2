using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class Lectura 
    {
        private DateTime fecha;
        private string tipo;
        private int valor;
        private string unidadMedida;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Valor { get => valor; set => valor = value; }
        public string UnidadMedida { get => unidadMedida; set => unidadMedida = value; }

    }
}
