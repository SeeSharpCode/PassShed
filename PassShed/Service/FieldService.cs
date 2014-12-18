using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using PassShed.DataAccess;

namespace PassShed.Service
{
    static class FieldService
    {
        public static List<Field> GetFieldsByCategoryId(int categoryId)
        {
            var fields = new List<Field>();

            using (var context = new ShedEntities())
            {
                fields.AddRange(context.Fields.Where(f => f.CategoryId == categoryId));
            }

            return fields;
        }

        public static Field GetFieldByName(int categoryId, string name)
        {
            using (var context = new ShedEntities())
            {
                return context.Fields.SingleOrDefault(f => f.CategoryId == categoryId && f.Label == name);
            }
        }

        public static void AddNew(Field field)
        {
            using (var context = new ShedEntities())
            {
                field.Label = field.Label.Trim();

                if (!NameInUse(context, field.CategoryId, field.Label))
                {
                    context.Fields.InsertOnSubmit(field);
                    context.SubmitChanges();

                    var credentials = new List<Credential>();

                    foreach (Account account in AccountService.GetAccountsByCategoryId(field.CategoryId))
                    {
                        credentials.Add
                            (new Credential { AccountId = account.Id, Created = DateTime.Now, FieldId = field.Id });
                    }

                    CredentialService.AddNew(context, credentials);

                    context.SubmitChanges();
                }
                else
                {
                    throw new ArgumentException("A field with this name already exists.");
                }
            }
        }

        public static void Update(int id, string name)
        {
            using (var context = new ShedEntities())
            {
                name = name.Trim();

                var field = context.Fields.SingleOrDefault(f => f.Id == id);

                if (!NameInUse(context, field.CategoryId, name))
                {
                    field.Label = name;
                    context.SubmitChanges();
                }
                else
                {
                    throw new ArgumentException("A field with this name already exists.");
                }
            }
        }

        public static void Update(int id, int displayIndex)
        {
            using (var context = new ShedEntities())
            {
                var field = context.Fields.SingleOrDefault(f => f.Id == id);

                field.DisplayIndex = displayIndex;
                context.SubmitChanges();
            }
        }

        public static void Delete(int id)
        {
            using (var context = new ShedEntities())
            {
                var field = context.Fields.SingleOrDefault(f => f.Id == id);

                context.Fields.DeleteOnSubmit(field);
                CredentialService.DeleteByFieldId(context, id);
                AccountService.DeleteAccountsWithoutCredentials(context);
                context.SubmitChanges();
            }
        }

        public static void DeleteByCategoryId(ShedEntities context, int categoryId)
        {
            var fields = context.Fields.Where(f => f.CategoryId == categoryId);

            context.Fields.DeleteAllOnSubmit(fields);
        }

        private static bool NameInUse(ShedEntities context, int categoryId, string name)
        {
            return context.Fields.Any(f => f.Label == name && f.CategoryId == categoryId);
        }
    }
}
