using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSellers(Seller seller)
        {
            Seller.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            // Soma as vendas entre as datas para cada vendedor
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
