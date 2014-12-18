using System.Configuration;
using System.Linq;
using PassShed.DataAccess;

namespace PassShed.Service
{
    static class PasswordService
    {
        public static void AddNew(MasterPassword password)
        {
            using (var context = new ShedEntities())
            {
                context.MasterPasswords.InsertOnSubmit(password);
                context.SubmitChanges();
            }
        }

        public static string GetPasswordHash()
        {
            using (var context = new ShedEntities())
            {
                var password = context.MasterPasswords.FirstOrDefault();

                if (password != null)
                {
                    return password.PasswordHash;
                }

                return "";
            }
        }
    }
}
