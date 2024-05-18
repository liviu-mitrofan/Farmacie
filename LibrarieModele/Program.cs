using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Medicament
    {
        private static readonly Random random = new Random();

        public int Id { get; private set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }

        public Medicament(string titlu, string descriere)
        {
            Id = random.Next(1, 10000);
            Titlu = titlu;
            Descriere = descriere;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Titlu: {Titlu}, Descriere: {Descriere}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
