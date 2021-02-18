using DBLibrary.DAO;
using DBLibrary.Utilities;
using System;
using System.Data.Entity;
using System.Linq;

namespace DBLibrary.DAOImpl
{
    public class UserActionsImpl : UserActions
    {
        private static readonly log4net.ILog log =
log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bool createUser(string fname, string lname, string email, string password)
        {
            try
            {
                using (var db = new Model1Container())
                {
                    User u = new User
                    {
                        FirstName = fname,
                        LastName = lname,
                        Email = email,
                        Password = GlobalFun.Hashpass(password),
                        CreateTime = GlobalFun.getCurrentimestamp(),
                        UpdateTime = GlobalFun.getCurrentimestamp()
                    };
                    if (GlobalFun.validaEmail(email) && GlobalFun.validatePass(password)) {//pass
                        db.Users.Add(u);
                        log.Info(GlobalResrouces.userCreated);
                        db.SaveChanges();
                        return true;
                    }
                    log.Info(GlobalResrouces.userNameInvalid);
                    return false;
                }
            }
            catch (Exception e) {
                log.Error(e.Message);
                return false;
            }
            return true;
        }

        public bool isUserExist(string email)
        {
            try
            {
                using (var db = new Model1Container()) {
                    var q = db.Users.Where(u => u.Email.ToLower().Equals(email.ToLower())).ToList();
                    return (q.Count > 0);
                }
            }
            catch (Exception e) {
                log.Error(e.Message);
            }
            return false;
        }

        public bool isUserValidate(string email, string password)
        {
            try
            {
                var hash = GlobalFun.Hashpass(password);
                using (var db = new Model1Container()) {
                    var q = db.Users.Where(u => u.Email.ToLower().Equals(email.ToLower()) && u.Password.Equals(hash)).ToList();
                    return (q.Count > 0);
                }
            }
            catch (Exception e) {
                log.Error(e.Message);
            }
            return false;
        }

        public bool updateUserProfile(User u)
        {
            try
            {
                using (var db = new Model1Container()) {
                    User o = getUserByEmail(u.Email);
                    if (o != null) {
                        db.Entry(o).State = EntityState.Modified;
                        o.FirstName = u.FirstName;
                        o.LastName = u.LastName;
                        o.Address = u.Address;
                        if (u.Password.Length > 0) o.Password = GlobalFun.Hashpass(u.Password);
                        o.Address = u.Address;
                        //Put a validation on postcal code here
                        if (!GlobalFun.validatePcode(u.PostalCode)) { return false; }
                        o.PostalCode = u.PostalCode;
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception e) {
                log.Error(e.Message);
            }
            return false;
        }

        public User getUserByEmail(string email) {
            try
            {
                using (var db = new Model1Container())
                {
                    var q = db.Users.Where(u => u.Email.ToLower().Equals(email.ToLower())).FirstOrDefault();
                    return q;
                }
            }
            catch (Exception e) {
                log.Error(e.Message);
            }
            return null;
        }
    }
}
