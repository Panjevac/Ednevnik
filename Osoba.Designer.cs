namespace EDnevnik
{
    partial class Osoba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_jmbg = new System.Windows.Forms.TextBox();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_uloga = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_jmbg = new System.Windows.Forms.Label();
            this.lbl_adresa = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_uloga = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_prezime
            // 
            this.txt_prezime.Location = new System.Drawing.Point(150, 45);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(100, 20);
            this.txt_prezime.TabIndex = 0;
            // 
            // txt_jmbg
            // 
            this.txt_jmbg.Location = new System.Drawing.Point(150, 90);
            this.txt_jmbg.Name = "txt_jmbg";
            this.txt_jmbg.Size = new System.Drawing.Size(100, 20);
            this.txt_jmbg.TabIndex = 1;
            // 
            // txt_adresa
            // 
            this.txt_adresa.Location = new System.Drawing.Point(150, 137);
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.Size = new System.Drawing.Size(100, 20);
            this.txt_adresa.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(150, 189);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(150, 244);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 4;
            // 
            // txt_uloga
            // 
            this.txt_uloga.Location = new System.Drawing.Point(150, 298);
            this.txt_uloga.Name = "txt_uloga";
            this.txt_uloga.Size = new System.Drawing.Size(100, 20);
            this.txt_uloga.TabIndex = 5;
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(150, 2);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(100, 20);
            this.txt_ime.TabIndex = 6;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(150, 351);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 7;
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Location = new System.Drawing.Point(333, 2);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(24, 13);
            this.lbl_ime.TabIndex = 8;
            this.lbl_ime.Text = "Ime";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Location = new System.Drawing.Point(336, 51);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(44, 13);
            this.lbl_prezime.TabIndex = 9;
            this.lbl_prezime.Text = "Prezime";
            // 
            // lbl_jmbg
            // 
            this.lbl_jmbg.AutoSize = true;
            this.lbl_jmbg.Location = new System.Drawing.Point(336, 96);
            this.lbl_jmbg.Name = "lbl_jmbg";
            this.lbl_jmbg.Size = new System.Drawing.Size(36, 13);
            this.lbl_jmbg.TabIndex = 10;
            this.lbl_jmbg.Text = "JMBG";
            // 
            // lbl_adresa
            // 
            this.lbl_adresa.AutoSize = true;
            this.lbl_adresa.Location = new System.Drawing.Point(339, 143);
            this.lbl_adresa.Name = "lbl_adresa";
            this.lbl_adresa.Size = new System.Drawing.Size(40, 13);
            this.lbl_adresa.TabIndex = 11;
            this.lbl_adresa.Text = "Adresa";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(336, 195);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 12;
            this.lbl_email.Text = "Email";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(336, 250);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "Password";
            // 
            // lbl_uloga
            // 
            this.lbl_uloga.AutoSize = true;
            this.lbl_uloga.Location = new System.Drawing.Point(336, 304);
            this.lbl_uloga.Name = "lbl_uloga";
            this.lbl_uloga.Size = new System.Drawing.Size(35, 13);
            this.lbl_uloga.TabIndex = 14;
            this.lbl_uloga.Text = "Uloga";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(336, 357);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 15;
            this.lbl_id.Text = "ID";
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(420, 133);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 23);
            this.btn_first.TabIndex = 16;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(520, 133);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 23);
            this.btn_previous.TabIndex = 17;
            this.btn_previous.Text = "<";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(622, 134);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 18;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Location = new System.Drawing.Point(458, 195);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(75, 23);
            this.btn_izmeni.TabIndex = 19;
            this.btn_izmeni.Text = "IZMENI";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(568, 195);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(75, 23);
            this.btn_dodaj.TabIndex = 20;
            this.btn_dodaj.Text = "DODAJ";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Location = new System.Drawing.Point(683, 195);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(75, 23);
            this.btn_obrisi.TabIndex = 21;
            this.btn_obrisi.Text = "OBRISI";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(720, 135);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 23);
            this.btn_last.TabIndex = 22;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 383);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_uloga);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_adresa);
            this.Controls.Add(this.lbl_jmbg);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.txt_uloga);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_adresa);
            this.Controls.Add(this.txt_jmbg);
            this.Controls.Add(this.txt_prezime);
            this.Name = "Osoba";
            this.Text = "Osoba";
            this.Load += new System.EventHandler(this.Osoba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_jmbg;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_uloga;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_jmbg;
        private System.Windows.Forms.Label lbl_adresa;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_uloga;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_last;
    }
}

