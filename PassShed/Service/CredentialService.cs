using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using PassShed.DataAccess;

namespace PassShed.Service
{
    static class CredentialService
    {
        public static List<Credential> GetCredentialsByAccountId(int accountId)
        {
            var credentialsInCategory = new List<Credential>();

            using (var context = new ShedEntities())
            {
                credentialsInCategory.AddRange(context.Credentials.Where(c => c.AccountId == accountId));
            }

            return credentialsInCategory;
        }

        public static Credential GetCredential(int credentialId)
        {
            using (var context = new ShedEntities())
            {
                return context.Credentials.SingleOrDefault(c => c.Id == credentialId);
            }
        }

        public static void AddNew(ShedEntities context, List<Credential> credentials)
        {
            context.Credentials.InsertAllOnSubmit(credentials);
        }

        public static void Update(int id, string value)
        {
            using (var context = new ShedEntities())
            {
                var credential = context.Credentials.SingleOrDefault(c => c.Id == id);
                credential.Value = value.Trim();
                credential.Modified = DateTime.Now;
                context.SubmitChanges();
            }
        }

        public static void Update(int accountId, int fieldId, string value)
        {
            using (var context = new ShedEntities())
            {
                var credential = context.Credentials.SingleOrDefault(c => c.AccountId == accountId && c.FieldId == fieldId);
                credential.Value = value.Trim();
                credential.Modified = DateTime.Now;
                context.SubmitChanges();
            }
        }

        public static void DeleteByAccountId(ShedEntities context, int accountId)
        {
            var credentials = context.Credentials.Where(c => c.AccountId == accountId);

            context.Credentials.DeleteAllOnSubmit(credentials);
        }

        public static void DeleteByCategoryId(ShedEntities context, int categoryId)
        {
            var credentials = from c in context.Credentials
                              join a in context.Accounts on c.AccountId equals a.Id
                              where a.CategoryId == categoryId
                              select c;

            context.Credentials.DeleteAllOnSubmit(credentials);
        }

        public static void DeleteByFieldId(ShedEntities context, int fieldId)
        {
            var credentials = context.Credentials.Where(c => c.FieldId == fieldId);

            context.Credentials.DeleteAllOnSubmit(credentials);
            context.SubmitChanges();
        }
    }
}
