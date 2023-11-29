using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Clases
{
    public static class Serializadora<T> 
    {
        public static void GuardarComoJSON(List<T> listaObjetos, string rutaArchivo)
        {
            if (listaObjetos == null)
                throw new ArgumentNullException(nameof(listaObjetos));

            try
            {
                string json = JsonConvert.SerializeObject(listaObjetos, Formatting.Indented);
                File.WriteAllText(rutaArchivo, json);
            }
            catch (IOException ex)
            {
                throw new InvalidOperationException($"No se pudo guardar el archivo JSON: {ex.Message}", ex);
            }
        }

        public static List<T> CargarDesdeJSON(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
                throw new ArgumentException("La ruta del archivo no puede ser nula o vacía.", nameof(rutaArchivo));

            if (!File.Exists(rutaArchivo))
            {
                Console.WriteLine("Usuario invalido o inexistente");
                return new List<T>();
            }

            try
            {
                string json = File.ReadAllText(rutaArchivo);
                return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
            }
            catch (IOException ex)
            {
                throw new InvalidOperationException($"No se pudo cargar el archivo JSON: {ex.Message}", ex);
            }
        }
        public static List<T> CargarDesdeXML(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
            {
                throw new ArgumentException("La ruta del archivo no puede ser nula o vacía.", nameof(rutaArchivo));
            }
            if (!File.Exists(rutaArchivo))
            {
                Console.WriteLine("Archivo inexistente");
                return new List<T>();
            }

            try
            {
                string contenido = File.ReadAllText(rutaArchivo);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                using (StringReader stringReader = new StringReader(contenido))
                {
                    return xmlSerializer.Deserialize(stringReader) as List<T> ?? new List<T>();
                }
            }
            catch (IOException ex)
            {
                throw new InvalidOperationException($"No se pudo cargar el archivo XML: {ex.Message}", ex);
            }
        }
        public static void GuardarComoXML(List<T> listaObjetos, string rutaArchivo, string tipo)
        {
            if (listaObjetos == null)
                throw new ArgumentNullException(nameof(listaObjetos));

            try
            {
                List<T> datosExistente = CargarDesdeXML(rutaArchivo).ToList();

                // Agregar nuevos datos a la lista existente
                datosExistente.AddRange(listaObjetos);


                using (TextWriter writer = new StreamWriter(rutaArchivo))
                {
                    if (tipo == "administrador")
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Administrador>));
                        xmlSerializer.Serialize(writer, datosExistente);
                    }
                    if (tipo == "Inquilino")
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Inquilino>));
                        xmlSerializer.Serialize(writer, datosExistente);
                    }
                    
                }
            }
            catch (IOException ex)
            {
                throw new InvalidOperationException($"No se pudo guardar el archivo XML: {ex.Message}", ex);
            }
        }
    }
       
   
}
