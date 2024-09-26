using DBAcceskontakt;
using MySqlConnector;
using NPoco;
using System.Configuration;
using System.Diagnostics;

namespace WinFormsTelefonbuchNPoco
{
    public partial class Form1 : Form
    {
        //string ConnectionString { get; init; } =
        //    ConfigurationManager.ConnectionStrings["mariadb"].ConnectionString;
        DbAccess DbAccess=new DbAccess();   
        public Form1()
        {
            InitializeComponent();
            GridInitialisieren();
        }

        private void GridInitialisieren()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
        private List<Kontakt> KontakteLaden()
        {
            List<Kontakt> lst = new();
            try
            {
                using MySqlConnection connection = new MySqlConnection(DbAccess.ConnectionString);
                using IDatabase db = new Database(connection);
                connection.Open(); // hier Verbindung zum DB Server aufbauen
                string sql = "select * from kontakt order by nachname, vorname";
                // Daten von DB nach Ausf�hrung von sql holen
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // gleich beim Start (Ereignis Load) 
            // Kontakte Laden und Anzeigen
            List<Kontakt> lst = DbAccess.KontakteLaden();
            
            KontakteAnzeigen(lst);
        }

        private void KontakteAnzeigen(List<Kontakt> lst)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lst;
        }

        private void BtnBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // aktuell markiertes Objekt / Kontakt in Textfeldern darstellen
            Kontakt? k = dataGridView1.CurrentRow.DataBoundItem as Kontakt;
            if (k == null) return;
            KontaktAnzeigen(k);
        }

        private void KontaktAnzeigen(Kontakt k)
        {
            if (k == null)
                return;

            txtId.Text = k.Id.ToString();
            txtVorname.Text = k.Vorname;
            txtNachname.Text = k.Nachname;
            txtTelefon.Text = k.Telefon;
            txtEmail.Text = k.Email;
        }

        private void BtnKontaktHinzuf�gen_Click(object sender, EventArgs e)
        {
            Kontakt k = new Kontakt(0, txtVorname.Text, txtNachname.Text,
                                    txtTelefon.Text, txtEmail.Text);
            DbAccess.
            KontaktHinzuf�gen(k);
            List<Kontakt> lst = DbAccess.KontakteLaden();
            KontakteAnzeigen(lst);

        }

        private void BtnKontakt�ndern_Click(object sender, EventArgs e)
        {
            // Aktuell markiertes Objekt im DataGridView holen
            Kontakt? k1 = dataGridView1.CurrentRow.DataBoundItem as Kontakt;
            if (k1 == null) return;
            Kontakt k2 = new Kontakt(k1.Id, txtVorname.Text, txtNachname.Text,
                                    txtTelefon.Text, txtEmail.Text, 
                                    DateTime.Now, k1.Erstellt);
            DbAccess.
            Kontakt�ndern(k2);
            List<Kontakt> lst = KontakteLaden();
            KontakteAnzeigen(lst);
        }

        private void BtnKontaktL�schen_Click(object sender, EventArgs e)
        {
            Kontakt? k = dataGridView1.CurrentRow.DataBoundItem as Kontakt;
            if (k == null) return;
            DbAccess.
            KontaktL�schen(k);
            List<Kontakt> lst = KontakteLaden();
            KontakteAnzeigen(lst);
        }

        //private void KontaktHinzuf�gen(Kontakt k)
        //{
        //    try
        //    {
        //        using MySqlConnection connection = new MySqlConnection(DbAccess.ConnectionString);
        //        using IDatabase db = new Database(connection);
        //        db.Connection.Open();
        //        db.Insert(k);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //    }
        //}


        //private void Kontakt�ndern(Kontakt k)
        //{
        //    try
        //    {
        //        using MySqlConnection connection = new MySqlConnection(DbAccess.ConnectionString);
        //        using IDatabase db = new Database(connection);
        //        db.Connection.Open();
        //        db.Update(k);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //    }
        //}

        //private void KontaktL�schen(Kontakt k)
        //{
        //    try
        //    {
        //        using MySqlConnection connection = new MySqlConnection(DbAccess.ConnectionString);
        //        using IDatabase db = new Database(connection);
        //        db.Connection.Open();
        //        db.Delete(k);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //    }
        //}
    }

}