namespace GestionComptesBanquaires.Formulaire
{
    partial class GestionnaireCompte
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
            this.vider = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.dataComptes = new System.Windows.Forms.DataGridView();
            this.modifierCompte = new System.Windows.Forms.Button();
            this.supprimerCompte = new System.Windows.Forms.Button();
            this.ajouterCompte = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CompteIdtext = new System.Windows.Forms.TextBox();
            this.CompteType = new System.Windows.Forms.TextBox();
            this.CompteSolde = new System.Windows.Forms.TextBox();
            this.CompteClientId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CompteDateOuverture = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataComptes)).BeginInit();
            this.SuspendLayout();
            // 
            // vider
            // 
            this.vider.Location = new System.Drawing.Point(466, 211);
            this.vider.Name = "vider";
            this.vider.Size = new System.Drawing.Size(75, 23);
            this.vider.TabIndex = 27;
            this.vider.Text = "vider";
            this.vider.UseVisualStyleBackColor = true;
            this.vider.Click += new System.EventHandler(this.vider_Click);
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(603, 211);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 26;
            this.fermer.Text = "fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click_1);
            // 
            // dataComptes
            // 
            this.dataComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataComptes.Location = new System.Drawing.Point(99, 279);
            this.dataComptes.Name = "dataComptes";
            this.dataComptes.Size = new System.Drawing.Size(602, 150);
            this.dataComptes.TabIndex = 25;
            this.dataComptes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataComptes_CellContentClick);
            // 
            // modifierCompte
            // 
            this.modifierCompte.Location = new System.Drawing.Point(362, 211);
            this.modifierCompte.Name = "modifierCompte";
            this.modifierCompte.Size = new System.Drawing.Size(75, 23);
            this.modifierCompte.TabIndex = 24;
            this.modifierCompte.Text = "modifier";
            this.modifierCompte.UseVisualStyleBackColor = true;
            this.modifierCompte.Click += new System.EventHandler(this.modifierCompte_Click_1);
            // 
            // supprimerCompte
            // 
            this.supprimerCompte.Location = new System.Drawing.Point(244, 211);
            this.supprimerCompte.Name = "supprimerCompte";
            this.supprimerCompte.Size = new System.Drawing.Size(75, 23);
            this.supprimerCompte.TabIndex = 23;
            this.supprimerCompte.Text = "supprimer";
            this.supprimerCompte.UseVisualStyleBackColor = true;
            this.supprimerCompte.Click += new System.EventHandler(this.supprimerCompte_Click_1);
            // 
            // ajouterCompte
            // 
            this.ajouterCompte.Location = new System.Drawing.Point(119, 211);
            this.ajouterCompte.Name = "ajouterCompte";
            this.ajouterCompte.Size = new System.Drawing.Size(75, 23);
            this.ajouterCompte.TabIndex = 22;
            this.ajouterCompte.Text = "Ajouter";
            this.ajouterCompte.UseVisualStyleBackColor = true;
            this.ajouterCompte.Click += new System.EventHandler(this.ajouterCompte_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "CompteId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "DateOuverture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "TypeCompte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Solde";
            // 
            // CompteIdtext
            // 
            this.CompteIdtext.Location = new System.Drawing.Point(441, 22);
            this.CompteIdtext.Name = "CompteIdtext";
            this.CompteIdtext.Size = new System.Drawing.Size(100, 20);
            this.CompteIdtext.TabIndex = 17;
            // 
            // CompteType
            // 
            this.CompteType.Location = new System.Drawing.Point(441, 114);
            this.CompteType.Name = "CompteType";
            this.CompteType.Size = new System.Drawing.Size(100, 20);
            this.CompteType.TabIndex = 15;
            // 
            // CompteSolde
            // 
            this.CompteSolde.Location = new System.Drawing.Point(441, 77);
            this.CompteSolde.Name = "CompteSolde";
            this.CompteSolde.Size = new System.Drawing.Size(100, 20);
            this.CompteSolde.TabIndex = 14;
            // 
            // CompteClientId
            // 
            this.CompteClientId.Location = new System.Drawing.Point(441, 51);
            this.CompteClientId.Name = "CompteClientId";
            this.CompteClientId.Size = new System.Drawing.Size(100, 20);
            this.CompteClientId.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "ClientId";
            // 
            // CompteDateOuverture
            // 
            this.CompteDateOuverture.Location = new System.Drawing.Point(441, 157);
            this.CompteDateOuverture.Name = "CompteDateOuverture";
            this.CompteDateOuverture.Size = new System.Drawing.Size(200, 20);
            this.CompteDateOuverture.TabIndex = 30;
            // 
            // GestionnaireCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CompteDateOuverture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CompteClientId);
            this.Controls.Add(this.vider);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.dataComptes);
            this.Controls.Add(this.modifierCompte);
            this.Controls.Add(this.supprimerCompte);
            this.Controls.Add(this.ajouterCompte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompteIdtext);
            this.Controls.Add(this.CompteType);
            this.Controls.Add(this.CompteSolde);
            this.Name = "GestionnaireCompte";
            this.Text = "GestionCompte";
            this.Load += new System.EventHandler(this.GestionnaireCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataComptes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vider;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.DataGridView dataComptes;
        private System.Windows.Forms.Button modifierCompte;
        private System.Windows.Forms.Button supprimerCompte;
        private System.Windows.Forms.Button ajouterCompte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CompteIdtext;
        private System.Windows.Forms.TextBox CompteType;
        private System.Windows.Forms.TextBox CompteSolde;
        private System.Windows.Forms.TextBox CompteClientId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker CompteDateOuverture;
    }
}