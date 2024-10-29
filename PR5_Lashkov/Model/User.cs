using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_Lashkov.Model
{
    internal class User
    {
        private int id;
        private string login;
        private string password;
        private int roleId;

        public User(int id, string login, string password, int roleId)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.roleId = roleId;
        }

        public int Id {  get { return id; } }
        public string Login { get { return login; } }
        public string Password { get { return password; } }
        public int RoleId { get { return roleId; } }
    }
}
