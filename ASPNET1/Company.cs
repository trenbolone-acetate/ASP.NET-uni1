namespace ASPNET1
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int NumberOfEmployees { get; set; }
        public DateTime FoundedDate { get; set; }

        public Company(string name, string address, int numberOfEmployees, DateTime foundedDate)
        {
            Name = name;
            Address = address;
            NumberOfEmployees = numberOfEmployees;
            FoundedDate = foundedDate;
        }

        public string GetCompanyInfo()
        {
            return $"Company Name: {Name}; Address: {Address}; Number of Employees: {NumberOfEmployees}; " +
                   $"Date of foundation: {FoundedDate.ToShortDateString()}";
        }

    }
}