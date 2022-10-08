using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

namespace ProvinciasID
{
    

    private static void GetProvinciasID()
    {
        var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
        var request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";
        request.ContentType = "aplication/json";
        request.Accept = "aplication/json";
        try
        {
            using (WebResponse response = request.GetResponse());
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return;
                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        
                    }
                }
            }
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
}