using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{


    public class Medidor : Lectura
    {
        private int id;
        private DateTime fechaInstalacion;
        private int estado;

        public int Id { get => id; set => id = value; }
        public DateTime FechaInstalacion { get => fechaInstalacion; set => fechaInstalacion = value; }
        public int Estado { get => estado; set => estado = value; }

        public override string ToString()
        {
            return Id + "|" + Fecha + "|" + Tipo + "|" + Valor +"|"+ Estado + "|UPDATE";
        }

        public void EnviarLectura(Lectura l)
        {

        }
    }
}
