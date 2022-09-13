using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); //Conexão com a class Seller

        //Construtores
        public Department()
        {
        }

        //OBS: NÃO INCLUIR OS ATRIBUTOS QUE POSSUI COLLECTION
        public Department(int id, string name)
        {
            Id = id;
            Name = name;            
        }

        //Métodos
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
