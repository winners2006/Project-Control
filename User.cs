using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Control
{
    class User
    {
        public int id { get; set; }
        private string login, email, pass, level, fio;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Level
        {
            get { return level; }
            set { level = value; }
        }
        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }

        public User() { }

        public User(string login, string pass, string email, string fio, string level)
        {
            this.login = login;
            this.pass = pass;
            this.email = email;
            this.fio = fio;
            this.level = level;
        }

        public override string ToString()
        {
            return FIO;
        }
    }
}
