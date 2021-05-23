using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresModel.DTO;

namespace MedidoresModel.DAL
{
    public class MedidorTraficoDALArchivos : IMedidorTraficoDAL
    {

        private string archivo = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "trafico.txt";

        private MedidorTraficoDALArchivos()
        {

        }

        private static IMedidorTraficoDAL instancia;

        public static IMedidorTraficoDAL GetInstance()
        {
            if (instancia == null)
                instancia = new MedidorTraficoDALArchivos();
            return instancia;
        }

        public List<MedidorConsumo> ObtenerLecturaConsumo()
        {
            throw new NotImplementedException();
        }

        public List<MedidorTrafico> ObtenerLecturasTrafico()
        {
            List<MedidorTrafico> lista = new List<MedidorTrafico>();
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    string linea = null;
                    do
                    {
                        string[] textoArray = linea.Split('|');
                        MedidorTrafico l = new MedidorTrafico()
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

            }catch(IOException ex)
            {
                lista = null;
            }
            return lista;
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

            }catch(IOException ex)
            {

            }
        }
    }
}
