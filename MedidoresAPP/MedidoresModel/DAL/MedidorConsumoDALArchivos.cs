using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresModel.DTO;

namespace MedidoresModel.DAL
{
    public class MedidorConsumoDALArchivos : IMedidorConsumoDAL
    {
        private string archivo = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "consumo.txt";

        private MedidorConsumoDALArchivos()
        {

        }

        private static IMedidorConsumoDAL instancia;

        public static IMedidorConsumoDAL GetInstance()
        {
            if (instancia == null)
                instancia = new MedidorConsumoDALArchivos();
            return instancia;
        }

        public List<MedidorConsumo> ObtenerLecturaConsumo()
        {
            List<MedidorConsumo> lista = new List<MedidorConsumo>();
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    string linea = null;
                    do
                    {
                        string[] textoArray = linea.Split('|');
                        MedidorConsumo l = new MedidorConsumo()
                        {
                            Id = Int32.Parse(textoArray[0]),
                            Fecha = DateTime.Parse(textoArray[1]),
                            Tipo = textoArray[2],
                            Valor = Int32.Parse(textoArray[3]),
                            Estado = Int32.Parse(textoArray[4])
                        };
                        lista.Add(l);
                    } while (linea != null);
                }

            }
            catch (IOException ex)
            {
                lista = null;
            }
            return lista;
        }

        public List<MedidorTrafico> ObtenerLecturasTrafico()
        {
            throw new NotImplementedException();
        }

        public int[] ObtenerMedidores()
        {
            throw new NotImplementedException();
        }

        public void RegistrarLectura(Medidor m)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine(m);
                    writer.Flush();
                }

            }
            catch (IOException ex)
            {

            }
        }
    }
}
