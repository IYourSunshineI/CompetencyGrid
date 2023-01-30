using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace CompetencyGrid {
    //class used for saving and loading objects from xml files
    public static class ObjectManager {

        //saving the object
        public static void SaveObject<T>(T serializableObject, string folderName, string fileName) {
            var serializer = new DataContractSerializer(typeof(T));
            var settings = new XmlWriterSettings() {
                Indent = true,
                IndentChars = "\t",
            };

            if (!Directory.Exists(folderName)) {
                Directory.CreateDirectory(folderName);
            }
            var writer = XmlWriter.Create(folderName + "/" + fileName, settings);
            serializer.WriteObject(writer, serializableObject);
            writer.Close();
        }

        //loading the object
        public static T LoadObject<T>(string folderName, string fileName) {
            var fileStream = new FileStream(folderName + "/" + fileName, FileMode.Open);
            var reader = XmlDictionaryReader.CreateTextReader(fileStream, new XmlDictionaryReaderQuotas());
            var serializer = new DataContractSerializer(typeof(T));
            T serializableObject = (T) serializer.ReadObject(reader, true);
            reader.Close();
            fileStream.Close();
            return serializableObject;
        }

        //loads object of whole folder
        public static T[] LoadObjects<T>(string folderName) {
            try {
                string[] names = Directory.GetFiles(folderName);
                T[] files = new T[names.Length];
                for (int i = 0; i < names.Length; i++) {
                    files[i] = LoadObject<T>(folderName, Path.GetFileName(names[i]));
                }
                return files;
            } catch (DirectoryNotFoundException e) {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
