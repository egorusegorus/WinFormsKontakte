namespace WinFormsTelefonbuchNPoco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnKontaktÄndern = new Button();
            BtnKontaktHinzufügen = new Button();
            BtnKontaktLöschen = new Button();
            BtnBeenden = new Button();
            label1 = new Label();
            txtVorname = new TextBox();
            txtId = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            txtNachname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnKontaktÄndern
            // 
            BtnKontaktÄndern.Location = new Point(644, 47);
            BtnKontaktÄndern.Name = "BtnKontaktÄndern";
            BtnKontaktÄndern.Size = new Size(174, 23);
            BtnKontaktÄndern.TabIndex = 0;
            BtnKontaktÄndern.Text = "Kontakt ändern";
            BtnKontaktÄndern.UseVisualStyleBackColor = true;
            BtnKontaktÄndern.Click += BtnKontaktÄndern_Click;
            // 
            // BtnKontaktHinzufügen
            // 
            BtnKontaktHinzufügen.Location = new Point(644, 76);
            BtnKontaktHinzufügen.Name = "BtnKontaktHinzufügen";
            BtnKontaktHinzufügen.Size = new Size(174, 23);
            BtnKontaktHinzufügen.TabIndex = 1;
            BtnKontaktHinzufügen.Text = "Kontakt hinzufügen";
            BtnKontaktHinzufügen.UseVisualStyleBackColor = true;
            BtnKontaktHinzufügen.Click += BtnKontaktHinzufügen_Click;
            // 
            // BtnKontaktLöschen
            // 
            BtnKontaktLöschen.Location = new Point(644, 105);
            BtnKontaktLöschen.Name = "BtnKontaktLöschen";
            BtnKontaktLöschen.Size = new Size(174, 23);
            BtnKontaktLöschen.TabIndex = 2;
            BtnKontaktLöschen.Text = "Kontakt löschen";
            BtnKontaktLöschen.UseVisualStyleBackColor = true;
            BtnKontaktLöschen.Click += BtnKontaktLöschen_Click;
            // 
            // BtnBeenden
            // 
            BtnBeenden.Location = new Point(644, 134);
            BtnBeenden.Name = "BtnBeenden";
            BtnBeenden.Size = new Size(174, 23);
            BtnBeenden.TabIndex = 3;
            BtnBeenden.Text = "Beenden";
            BtnBeenden.UseVisualStyleBackColor = true;
            BtnBeenden.Click += BtnBeenden_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 60);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // txtVorname
            // 
            txtVorname.Location = new Point(112, 77);
            txtVorname.Name = "txtVorname";
            txtVorname.Size = new Size(114, 23);
            txtVorname.TabIndex = 5;
            txtVorname.Text = "Franz";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(74, 77);
            txtId.Name = "txtId";
            txtId.Size = new Size(31, 23);
            txtId.TabIndex = 6;
            txtId.Text = "0";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(469, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(151, 23);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "f.m@xyz.de";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(350, 77);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(114, 23);
            txtTelefon.TabIndex = 8;
            txtTelefon.Text = "089 12345";
            // 
            // txtNachname
            // 
            txtNachname.Location = new Point(231, 77);
            txtNachname.Name = "txtNachname";
            txtNachname.Size = new Size(114, 23);
            txtNachname.TabIndex = 9;
            txtNachname.Text = "Müller";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 60);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Vorname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 60);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 11;
            label3.Text = "Nachname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 60);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 12;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 59);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 13;
            label5.Text = "Email";
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnKontaktÄndern);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(BtnKontaktHinzufügen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BtnKontaktLöschen);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BtnBeenden);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNachname);
            panel1.Controls.Add(txtVorname);
            panel1.Controls.Add(txtTelefon);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtEmail);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 193);
            panel1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(872, 193);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 386);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinFormsKontakte";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnKontaktÄndern;
        private Button BtnKontaktHinzufügen;
        private Button BtnKontaktLöschen;
        private Button BtnBeenden;
        private Label label1;
        private TextBox txtVorname;
        private TextBox txtId;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private TextBox txtNachname;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}