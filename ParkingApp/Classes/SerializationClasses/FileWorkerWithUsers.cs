using System;
using System.Collections.Generic;
using System.IO;

namespace ParkingApp
{
    class FileWorkerWithUsers
    {
        private List<User> users = null;
        
        private String filePath = "";
        private String fileName = "users.parking";

        public FileWorkerWithUsers()
        {
            filePath = Globals.directory + "\\" + fileName;
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }

        //Добавляем пользователя в список пользователей
        public void addUserToFile(User user)
        {
            if (readUsers() == null)
            {
                users = new List<User>();
                users.Add(user);
            }
            else
            {
                users.Add(user);
            }
            //Перезаписываем файл
            writeUsers();
        }

        //Считываем всех пользователей из файла
        public List<User> readUsers()
        {
            SerializeClass ser = new SerializeClass(filePath, users);
            if (ser.isCorrectFile())
            {
                try
                {
                    users = (List<User>)ser.Deserialize();
                    ser.Close();
                    return users;
                } catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
            else
            {
                return null;
            }
            
        }

        //Записываем всех пользователей
        public void writeUsers()
        {
            SerializeClass ser = new SerializeClass(filePath, users);
            ser.Serialize();
            ser.Close();
        }
    }
}
