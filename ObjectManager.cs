using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace CompetencyGrid {
    //class used for saving and loading objects from xml files
    public static class ObjectManager {

        //saving the object
        public static void SaveObject<T>(T serializableObject, string filePath) {
            var serializer = new DataContractSerializer(typeof(T));
            var settings = new XmlWriterSettings() {
                Indent = true,
                IndentChars = "\t",
            };
            var writer = XmlWriter.Create(filePath, settings);
            serializer.WriteObject(writer, serializableObject);
            writer.Close();
        }

        //loading the object
        public static T LoadObject<T>(string filePath) {
            var fileStream = new FileStream(filePath, FileMode.Open);
            var reader = XmlDictionaryReader.CreateTextReader(fileStream, new XmlDictionaryReaderQuotas());
            var serializer = new DataContractSerializer(typeof(T));
            T serializableObject = (T) serializer.ReadObject(reader, true);
            reader.Close();
            fileStream.Close();
            return serializableObject;
        }
    }
}
