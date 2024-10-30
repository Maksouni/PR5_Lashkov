using PR5_Lashkov.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_Lashkov
{
    internal class Helper
    {
        private static DrinkFactoryEntities _context;

        public static DrinkFactoryEntities GetContext()
        {
            if(_context == null) 
                _context = new DrinkFactoryEntities();
            return _context;
        }

        public static void CreateUser(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
