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

        [Required(ErrorMessage = "Campo obbligatorio!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Il nome deve essere compreso tra 3 e 50 caratteri")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio!")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "La descrizione deve essere compresa tra 10 e 100 caratteri")]
        public string Descrizione { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Il nome dell'immagine deve essere compreso tra 5 e 100 caratteri")]
        public string Img { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio!")]
        [Range(1, 9999.99, ErrorMessage ="Il prezzo deve essere compreso tra 1 e 9999.99")]
        public double Prezzo { get; set; }

        public Pizza(string nome, string descrizione, string img, double prezzo)
        {
            Nome = nome;
            Descrizione = descrizione;
            Img = img;
            Prezzo = prezzo;
        }

        public Pizza() { }
    }
}
