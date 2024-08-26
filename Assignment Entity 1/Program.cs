namespace Assignment_Entity_1
{
    class Program
    {
        static void Main()
        {
            #region Create 

            using (var context = new itiDbContext()
            {

            })
            {
                var student = new Student { FName = "John", LName = "Doe", Address = "123 Main St", Age = 20, Dep_Id = 1 };
                context.Students.Add(student);
                context.SaveChanges();
            }

            #endregion

            #region Read 

            using (var context = new itiDbContext())
            {
                var student = context.Students.FirstOrDefault(s => s.ID == 1);
                Console.WriteLine(student.FName);
            }

            #endregion

            #region Update

            using (var context = new itiDbContext())
            {
                var student = context.Students.FirstOrDefault(s => s.ID == 1);
                student.Age = 21;
                context.SaveChanges();
            }


            #endregion

            #region Delete

            using (var context = new itiDbContext())
            {
                var student = context.Students.FirstOrDefault(s => s.ID == 1);
                context.Students.Remove(student);
                context.SaveChanges();
            }


            #endregion









        }
    }
}