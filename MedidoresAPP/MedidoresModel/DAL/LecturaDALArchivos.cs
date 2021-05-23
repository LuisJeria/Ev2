using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresModel.DTO;

namespace MedidoresModel.DAL
{
    public class LecturaDALArchivos : ILecturaDAL
    {

        private LecturaDALArchivos()
        {

        }

        private static ILecturaDAL instancia;

        public static ILecturaDAL GetInstance()
        {
            if (instancia == null)
                instancia = new LecturaDALArchivos();
            return instancia;
        }

        public List<MedidorConsumo> ObtenerLecturaConsumo()
        {
            throw new NotImplementedException();
        }

        public List<MedidorTrafico> ObtenerLecturasTrafico()
        {
            throw new NotImplementedException();
        }

        public void RegistrarLectura(Medidor m)
        {
            throw new NotImplementedException();
        }
    }
}
