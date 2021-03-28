using System;

namespace ScaffoldindwithORM
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FluentApiLessonContext())
            {
                context.Add(new Order { Date = DateTime.Now, IsPaid = false });
            }
            context.SaveChanges();
        }
    }
}
