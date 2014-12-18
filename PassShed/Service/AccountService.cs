using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using PassShed.DataAccess;

namespace PassShed.Service
{
    static class AccountService
    {
        public static List<Account> GetAccountsByCategoryId(int categoryId)
        {
            var accountsInCategory = new List<Account>();

            using (var context = new ShedEntities())
            {
                accountsInCategory.AddRange(context.Accounts.Where(a => a.CategoryId == categoryId));
            }

            return accountsInCategory;
        }

        public static int AddNewWithBlankCredentials(Account account)
        {
            using (var context = new ShedEntities())
            {
                context.Accounts.InsertOnSubmit(account);
                context.SubmitChanges();

                var credentials = new List<Credential>();

                foreach (var field in context.Fields.Where(f => f.CategoryId == account.CategoryId))
                {
                    credentials.Add(new Credential {AccountId = account.Id, FieldId = field.Id, Created = DateTime.Now});
                }

                CredentialService.AddNew(context, credentials);
                context.SubmitChanges();
            }

            return account.Id;
        }

        public static void Delete(int accountId)
        {
            using (var context = new ShedEntities())
            {
                var account = context.Accounts.SingleOrDefault(a => a.Id == accountId);

                context.Accounts.DeleteOnSubmit(account);
                CredentialService.DeleteByAccountId(context, accountId);
                context.SubmitChanges();
            }
        }

        public static void DeleteByCategoryId(ShedEntities context, int categoryId)
        {
            var accounts = context.Accounts.Where(a => a.CategoryId == categoryId);

            context.Accounts.DeleteAllOnSubmit(accounts);
        }

        public static void DeleteAccountsWithoutCredentials(ShedEntities context)
        {
            foreach (Account account in context.Accounts)
            {
                if (!context.Credentials.Any(c => c.AccountId == account.Id))
                {
                    context.Accounts.DeleteOnSubmit(account);
                    context.SubmitChanges();
                }
            }
        }
    }
}
