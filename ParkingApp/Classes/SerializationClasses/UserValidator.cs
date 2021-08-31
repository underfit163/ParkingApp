using System.Collections.Generic;

namespace ParkingApp
{
    class UserValidator
    {
        private FileWorkerWithUsers fileWorker = new FileWorkerWithUsers();

        //Проверяет существует ли в файл пользователь с переданными параметрами
        public bool isExisted(string login, string password, string type)
        {
            List<User> users = fileWorker.readUsers();
            if (users == null)
            {
                return false;
            }
            foreach (User u in users)
            {
                if(u.getLogin()!=null && u.getPassword()!=null && u.getType() != null)
                {
                    if (u.getLogin().Equals(login) && u.getPassword().Equals(password) && u.getType().Equals(type))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
