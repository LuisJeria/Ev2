using MedidoresModel.DAL;
using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresAPP
{
    class Program
    {
        static IMedidorConsumoDAL dalMC = MedidorConsumoDALFactory.CreateDAL();
        static IMedidorTraficoDAL dalMT = MedidorTraficoDALFactory.CreateDAL();

        static void Main(string[] args)
        {
            MedidorConsumo mc = new MedidorConsumo()
            {
                Tipo = "Consumo"
            };

            dalMC.RegistrarLectura(mc);

            MedidorTrafico mt = new MedidorTrafico()
            {
                Tipo = "Trafico"
            };
            dalMT.RegistrarLectura(mt);
        }
    }
}
