using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface ILecturaDAL
    {
        void RegistrarLectura(Medidor m);
        List<MedidorTrafico> ObtenerLecturasTrafico();
        List<MedidorConsumo> ObtenerLecturaConsumo();
    }
}
