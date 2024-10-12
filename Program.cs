namespace SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> students = new Dictionary<string, int>();

            while (true)
            {
                Console.WriteLine("Enter a studen name:");
                string studentName = Console.ReadLine() ?? throw new Exception("Student name cannot be empty.");

                if (string.IsNullOrWhiteSpace(studentName))
                {
                    break;

                } 

                Console.WriteLine("Enter student grade:");
                string studentGrade = Console.ReadLine() ?? throw new Exception(null);

                if (int.TryParse(studentGrade, out int grade))
                {
                    students[studentName] = grade;
                } else

                {
                    Console.WriteLine("Invalid input");
                }
            }

            var sortedDictionary = students.OrderBy(x => x.Key);

            foreach (var student in sortedDictionary)
            {
                Console.WriteLine($"Student name: {student.Key}, Student grade: {student.Value}");
            }
        }
    }
}

