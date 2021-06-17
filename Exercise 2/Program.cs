

namespace Exercise_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchoolTeacher = new HighSchoolTeacher
            {
                IdentityNumber = "ID001",
                Name = "Sping Hero",
                BaseSalary = 100,
                Level = 1,
                Bouns = 100,
                IsSenior = false,
                HighSchoolCode = "HS001"
            };
            Console.WriteLine(highSchoolTeacher.CalculateSalary());
            var universityTeacher = new UniversityTeacher()
            {
                IdentityNumber = "ID002",
                Name = "Dao Xuan",
                BaseSalary = 60000,
                Level = 1,
                Bouns = 9000,
                IsSenior = true,
                EnglishLevel = 2,
                UniversityCode = "UN001"
            };
            Console.WriteLine(universityTeacher.CalculateSalary());
        }
    }

    internal class Console
    {
        public static void WriteLine(double calculateSalary)
        {
            throw new System.NotImplementedException();
        }

        public class Error
        {
        }
    }
}