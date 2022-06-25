using System.ComponentModel;

namespace dot_net_lab4_mvc.Models
{
    public class HelloModel
    {
        [DisplayName("Imię studenta")]
        public string? Imie { get; set; }
        
        [DisplayName("Nazwisko studenta")]
        public string? Nazwisko { get; set; }
        
        [DisplayName("Numer indeksu")]
        public string? Indeks { get; set; }

    }
}
