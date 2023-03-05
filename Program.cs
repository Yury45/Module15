namespace Module15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
                new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
                new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
                new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static List<string> GetAllStudents(Classroom[] classes)
        {
            var students = (from c in classes
                where c != null && c.Students != null
                from student in c.Students
                where student != null
                select student).ToList();

            return students;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}