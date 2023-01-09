using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hastane_Projesi
{
    internal class UserManager : UserService
        
    {
        UserDateAccess userDataAccess = new UserDateAccess();

        public UserManager(UserDateAccess userDataAccess)
        {
            this.userDataAccess = userDataAccess;

        }
        public User addUser(User user)
        {
            return userDataAccess.addUser(user);
        }
    }
}
