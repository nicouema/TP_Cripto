using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Criptomonedas.Entidades.Criptomonedas;

namespace Criptomonedas
{
    internal class AutoCotiz
    {

        public static void agregarCotizaciones(int iteraciones, int codCripto, double valorInicial)
        {
            for (int i = 0; i < iteraciones; i++)
            {
                Cotizacion cotizacion = new Cotizacion();
                cotizacion.CodCripto = codCripto;
                cotizacion.FechaHora = DateTime.Now;
                cotizacion.Valor = generarValor(valorInicial);
                valorInicial = cotizacion.Valor;

                AgregarCotizacionBD(cotizacion);
                
                Thread.Sleep(1000);
            }
        }

        private static float generarValor(double valorInicial)
        {
            List<double> posibilidades = new List<double>();
            posibilidades.Add(0.90);
            posibilidades.Add(0.50);
            posibilidades.Add(0.91);
            posibilidades.Add(0.91);
            posibilidades.Add(0.92);
            posibilidades.Add(0.93);
            posibilidades.Add(0.94);
            posibilidades.Add(0.95);
            posibilidades.Add(0.80);
            posibilidades.Add(0.70);
            posibilidades.Add(1.10);
            posibilidades.Add(1.11);
            posibilidades.Add(1.12);
            posibilidades.Add(1.13);
            posibilidades.Add(1.14);
            posibilidades.Add(1.14);
            posibilidades.Add(1.30);
            posibilidades.Add(1.40);
            posibilidades.Add(1.70);

            var random = new Random();
            double multiplicador = posibilidades[random.Next(posibilidades.Count)];

            Console.WriteLine(valorInicial.ToString() + " * " + multiplicador.ToString() + " = " + (valorInicial * multiplicador).ToString());

            return (float)(valorInicial * multiplicador);
        }

        private static bool AgregarCotizacionBD(Cotizacion c)
        {
            bool result = false;
            DateTime fecha = (DateTime)c.FechaHora;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Cotizaciones_por_monedas (codigo_cripto, fecha, hora, valor) VALUES (@codCripto, @fecha, @hora, @valorCotizacion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@valorCotizacion", c.Valor);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@hora", fecha.TimeOfDay);
                cmd.Parameters.AddWithValue("@codCripto", c.CodCripto);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cn.Close(); }

            return result;
        }
    }
}
