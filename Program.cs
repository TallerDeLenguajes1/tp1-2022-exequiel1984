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
                                Console.WriteLine("Id: {0} Nombre: {1}", Prov.Id, Prov.Nombre);
                            }
                        }
                    }
                }
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Excepción que se produce cuando un método invocado no es compatible o cuando se intenta leer, buscar o escribir en una secuencia que no es compatible con las funciones invocadas.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Inicializa una nueva instancia de la clase ArgumentNullException.");
            }
            catch(System.Security.SecurityException)
            {
                Console.WriteLine("Se produce una SecurityException excepción cuando un autor de la llamada no tiene los permisos necesarios para acceder a un recurso.");
            }
            catch(UriFormatException)
            {
                Console.WriteLine("Excepción que se produce cuando se detecta un identificador de recursos uniformes (URI) no válido.");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.");
            }
            catch(ProtocolViolationException)
            {
                Console.WriteLine("Excepción que se produce cuando se produce un error mientras se utiliza un protocolo de red.");
            }
            catch (WebException)
            {
                Console.WriteLine("Problemas de acceso a la API - Excepción que se produce cuando ocurre un error al acceder a la red mediante un protocolo acoplable.");
                throw;
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("Excepción que se produce cuando una llamada a un método no es válida para el estado actual del objeto.");
            }
            catch(OutOfMemoryException)
            {
                Console.WriteLine("Excepción que se produce cuando no hay suficiente memoria para continuar con la ejecución de un programa.");
            }
            catch(IOException)
            {
                Console.WriteLine("Excepción que se produce cuando hay un error de E/S.");
            }
            catch(JsonException)
            {
                Console.WriteLine("Define un objeto de excepción personalizado que se produce cuando se encuentra texto JSON no válido, se pasa la profundidad máxima definida o el texto JSON no es compatible con el tipo de una propiedad en un objeto.");
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Excepción que se produce cuando se intenta desreferenciar un objeto null.");
            }
        }
    }
}