using MySqlConnector;
using NPoco;
using System.Configuration;
using System.Diagnostics;

namespace DBAcceskontakt
{
    public class DbAccess : IDbAcces
    {
      public  string ConnectionString { get; init; } =
            ConfigurationManager.ConnectionStrings["mariadb"].ConnectionString;
        public List<Kontakt> KontakteLaden()
        {
            List<Kontakt> lst = new();
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                connection.Open(); // hier Verbindung zum DB Server aufbauen
                string sql = "select * from kontakt order by nachname, vorname";
                // Daten von DB nach Ausführung von sql holen
                // und in generischer Liste lst speichern
                // Jeder Datensatz ergibt ein Kontakt-Objekt
                lst = db.Fetch<Kontakt>(sql);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return lst;
        }

        public void KontaktHinzufügen(Kontakt k)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                db.Connection.Open();
                db.Insert(k);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }


        public void KontaktÄndern(Kontakt k)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                db.Connection.Open();
                db.Update(k);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
     
        public void KontaktLöschen(Kontakt k)
        {
            try
            {
                using MySqlConnection connection = new MySqlConnection(ConnectionString);
                using IDatabase db = new Database(connection);
                db.Connection.Open();
                db.Delete(k);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }

}


