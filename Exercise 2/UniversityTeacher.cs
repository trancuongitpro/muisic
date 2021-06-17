namespace Exercise_2
{
    public class UniversityTeacher : AbstractTeacher
    {
        public string  UniversityCode { get; set; }

        public int EnglishLevel { get; set; }
        public string IdentityNumber { get; set; }
        public int Bouns { get; set; }

        public override double CalculateSalary()
        {
            if (Bonus > 1000)
            {
                throw new AmountException("Bonus is more than 10,000", Name);
            }

            var salary = BaseSalary  Level + ((BaseSalary/10)  EnglishLevel) + Bonus;
            if (IsSenior && salary < 60000)
            {
                throw new AmountException("Senior Lecturer get less than 60,000 salary", Name);
            }

            return salary;
        }
    }
}