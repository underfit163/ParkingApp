using System;

namespace ParkingApp
{
    [Serializable]
    class User
    {
        private String login;
        private String password;
        private String type;

        public User(String login, String password, String type)
        {
            this.login = login;
            this.password = password;
            this.type = type;
        }

        public String getLogin()
        {
            return this.login;
        }

        public String getPassword()
        {
            return this.password;
        }

        public void setLogin(String newLogin)
        {
            this.login = newLogin;
        }

        public void setPassword(String newPassword)
        {
            this.password = newPassword;
        }

        public String getType()
        {
            return this.type;
        }

        public void setType(String newType)
        {
            this.type = newType;
        }
    }
}
