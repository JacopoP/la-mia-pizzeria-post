using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace project.Models
{
    [Table("pizze")]
    public class Pizza
    {
        [Key]
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Img { get; set; }
        public double Prezzo { get; set; }

        public Pizza(string nome, string descrizione, string img, double prezzo)
        {
            Nome = nome;
            Descrizione = descrizione;
            Img = img;
            Prezzo = prezzo;
        }
    }
}
