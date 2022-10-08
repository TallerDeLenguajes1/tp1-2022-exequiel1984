using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

namespace ProvinciasID
{
    partial class Program
    {
        static void Main(string[] args)
        {
            GetProvinciasArgentinas();
        }

        private static void GetProvinciasArgentinas()
        {
            var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "aplication/json";
            request.Accept = "aplication/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            ProvinciasArgentina ListProvincias = JsonSerializer.Deserialize<ProvinciasArgentina>(responseBody);
                            foreach (Provincia Prov in ListProvincias.Provincias)
                            {
                                Console.WriteLine($"Id: {0} Nombre: {1}", Prov.Id, Prov.Nombre);
                            }
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Problemas de acceso a la API");
                throw;
            }
        }
    }
}