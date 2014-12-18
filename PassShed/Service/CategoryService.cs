using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using PassShed.DataAccess;

namespace PassShed.Service
{
    static class CategoryService
    {
        public static List<Category> GetAllCategories()
        {
            var allCategories = new List<Category>();

            using (var context = new ShedEntities())
            {
                allCategories.AddRange(context.Categories);
            }

            return allCategories;
        }

        public static void AddNew(Category category)
        {
            using (var context = new ShedEntities())
            {
                category.Label = category.Label.Trim();

                if (!NameInUse(context, category.Label))
                {
                    context.Categories.InsertOnSubmit(category);
                    context.SubmitChanges();
                }
                else
                {
                    throw new ArgumentException("A category with this name already exists.");
                }
            }
        }

        public static void Update(int id, string name)
        {
            using (var context = new ShedEntities())
            {
                name = name.Trim();

                if (!NameInUse(context, name))
                {
                    var category = context.Categories.SingleOrDefault(c => c.Id == id);
                    category.Label = name;
                    context.SubmitChanges();
                }
                else
                {
                    throw new ArgumentException("A category with this name already exists.");
                }
            }
        }

        public static void Delete(int id)
        {
            using (var context = new ShedEntities())
            {
                context.Categories.DeleteOnSubmit(context.Categories.SingleOrDefault(c => c.Id == id));
                AccountService.DeleteByCategoryId(context, id);
                FieldService.DeleteByCategoryId(context, id);
                CredentialService.DeleteByCategoryId(context, id);
                context.SubmitChanges();
            }
        }

        private static bool NameInUse(ShedEntities context, string name)
        {
            return context.Categories.Any(c => c.Label == name);
        }
    }
}
