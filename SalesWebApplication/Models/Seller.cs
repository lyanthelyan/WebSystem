using System.Linq;
namespace SalesWebApplication.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSallary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller(){}

        public Seller(int id, string name, string email, DateTime birthDate, double baseSallary, Department department, ICollection<SalesRecord> sales)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSallary = baseSallary;
            Department = department;
            Sales = sales;
        }

        public void AddSales(SalesRecord sr){Sales.Add(sr);}
        public void RemoveSales(SalesRecord sr) { Sales.Remove(sr); }

        public double TotalSales(DateTime inital, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= inital && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
