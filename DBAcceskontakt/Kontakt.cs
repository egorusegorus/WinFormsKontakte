namespace DBAcceskontakt
{
    public class Kontakt
    {
        // Attribute  
        // Wir verwenden public automatic properties
        // { get; set; } für eine einfache Darstellung
        // im DataGridView
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime Geandert { get; set; }
        public DateTime Erstellt { get; set; }

        // Konstruktor(en)
        public Kontakt(int id, string vorname, string nachname,
                       string telefon, string email)
        {
            Id = id;
            Vorname = vorname;
            Nachname = nachname;
            Telefon = telefon;
            Email = email;
            Geandert = DateTime.Now;
            Erstellt = DateTime.Now;
        }

        public Kontakt(int id, string vorname, string nachname,
                       string telefon, string email,
                       DateTime geaendert, DateTime erstellt)
        {
            Id = id;
            Vorname = vorname;
            Nachname = nachname;
            Telefon = telefon;
            Email = email;
            Geandert = geaendert;
            Erstellt = erstellt;
        }

        // Methoden
    }

}