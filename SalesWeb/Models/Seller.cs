using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        internal static void Add(Seller seller)
        {
            throw new NotImplementedException();
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Adicionar uma venda
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);  // Adiciona
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);  // Remove
        }

        public double TotalSales(DateTime initial, DateTime final)  // Total de vendas entre datas
        {
            // filtrar vendas e depois somar
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
