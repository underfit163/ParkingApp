using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ParkingApp
{
    public class SerializeClass
    {
        private object CurrentObject = null;
        private string CurrentFile = "";
        private FileStream FS;

        public SerializeClass(string fileName, object objType)
        {
            CurrentObject = objType;
            CurrentFile = fileName;
        }

        public void Serialize()
        {
            FS = new FileStream(CurrentFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(FS, CurrentObject);
            FS.Close();
        }

        public bool isCorrectFile()
        {
            object obj = null;
            FS = new FileStream(CurrentFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter bf = new BinaryFormatter();
            if (FS.Length > 0)
            {
                try
                {
                    obj = bf.Deserialize(FS);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
            FS.Close();
            return true;
        }

        public object Deserialize()
        {
            object obj = null;
            FS = new FileStream(CurrentFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter bf = new BinaryFormatter();
            if (FS.Length > 0)
            {            
                obj = bf.Deserialize(FS);               
            }
            FS.Close();
            return obj;
        }

        public void Close()
        {
            CurrentObject = null;
            CurrentFile = "";
        }
    }
}
