using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.DAO
{
    public interface UserActions
    {
        bool isUserExist(string email);

        bool isUserValidate(string email, string password);

        bool createUser(string fname, string lname, string email, string password);

        //Will do a serach based on email and update applicable info
        bool updateUserProfile(User u);

        User getUserByEmail(string email);
    }
}
