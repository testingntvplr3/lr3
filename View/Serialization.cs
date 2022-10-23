using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

using Model;


namespace View
{
    internal class Serialization
    {
        /// <summary>
        /// Метод реализации сериализатора.
        /// </summary>
        /// <param name="path_to_file">путь к файлу</param>
        /// <param name="lst_data">список объектов</param>
        public static void Serializer(string path_to_file, List<Calc> lst_data)
        {
            var serializar = new XmlSerializer(typeof(List<Calc>));

            using (TextWriter writer = new StreamWriter(path_to_file))
            {
                serializar.Serialize(writer, lst_data);
                writer.Close();
            }
        }


        /// <summary>
        /// Метод реализация десериализатора.
        /// </summary>
        /// <param name="file_path">путь к файлу</param>
        /// <returns>список объектов</returns>
        public static List<Calc> Deserializer(string file_path)
        {
            var serializar = new XmlSerializer(typeof(List<Calc>));

            using (TextReader reader = new StreamReader(file_path))
            {
                var settings = (List<Calc>)serializar.Deserialize(reader);
                reader.Close();

                return settings;
            }
        }
    }
}
