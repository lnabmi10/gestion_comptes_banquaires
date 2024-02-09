namespace GestionComptesBanquaires.Formulaire
{
    partial class GestionnaireClient
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
            this.ClientNom = new System.Windows.Forms.TextBox();
            this.ClientPrenom = new System.Windows.Forms.TextBox();
            this.ClientTel = new System.Windows.Forms.TextBox();
            this.ClientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ajouterClient = new System.Windows.Forms.Button();
            this.supprimerClient = new System.Windows.Forms.Button();
            this.modifierClient = new System.Windows.Forms.Button();
            this.dataClients = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fermer = new System.Windows.Forms.Button();
            this.vider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientNom
            // 
            this.ClientNom.Location = new System.Drawing.Point(468, 88);
            this.ClientNom.Name = "ClientNom";
            this.ClientNom.Size = new System.Drawing.Size(100, 20);
            this.ClientNom.TabIndex = 0;
            // 
            // ClientPrenom
            // 
            this.ClientPrenom.Location = new System.Drawing.Point(468, 132);
            this.ClientPrenom.Name = "ClientPrenom";
            this.ClientPrenom.Size = new System.Drawing.Size(100, 20);
            this.ClientPrenom.TabIndex = 1;
            // 
            // ClientTel
            // 
            this.ClientTel.Location = new System.Drawing.Point(468, 182);
            this.ClientTel.Name = "ClientTel";
            this.ClientTel.Size = new System.Drawing.Size(100, 20);
            this.ClientTel.TabIndex = 2;
            // 
            // ClientId
            // 
            this.ClientId.Location = new System.Drawing.Point(468, 40);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(100, 20);
            this.ClientId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numerotel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "id ";
            // 
            // ajouterClient
            // 
            this.ajouterClient.Location = new System.Drawing.Point(146, 229);
            this.ajouterClient.Name = "ajouterClient";
            this.ajouterClient.Size = new System.Drawing.Size(75, 23);
            this.ajouterClient.TabIndex = 8;
            this.ajouterClient.Text = "Ajouter";
            this.ajouterClient.UseVisualStyleBackColor = true;
            this.ajouterClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // supprimerClient
            // 
            this.supprimerClient.Location = new System.Drawing.Point(271, 229);
            this.supprimerClient.Name = "supprimerClient";
            this.supprimerClient.Size = new System.Drawing.Size(75, 23);
            this.supprimerClient.TabIndex = 9;
            this.supprimerClient.Text = "supprimer";
            this.supprimerClient.UseVisualStyleBackColor = true;
            this.supprimerClient.Click += new System.EventHandler(this.supprimerClient_Click);
            // 
            // modifierClient
            // 
            this.modifierClient.Location = new System.Drawing.Point(389, 229);
            this.modifierClient.Name = "modifierClient";
            this.modifierClient.Size = new System.Drawing.Size(75, 23);
            this.modifierClient.TabIndex = 10;
            this.modifierClient.Text = "modifier";
            this.modifierClient.UseVisualStyleBackColor = true;
            this.modifierClient.Click += new System.EventHandler(this.modifierClient_Click);
            // 
            // dataClients
            // 
            this.dataClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.Prenom,
            this.NumeroTel});
            this.dataClients.Location = new System.Drawing.Point(126, 297);
            this.dataClients.Name = "dataClients";
            this.dataClients.Size = new System.Drawing.Size(602, 150);
            this.dataClients.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // NumeroTel
            // 
            this.NumeroTel.HeaderText = "NumeroTel";
            this.NumeroTel.Name = "NumeroTel";
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(630, 229);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 12;
            this.fermer.Text = "fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // vider
            // 
            this.vider.Location = new System.Drawing.Point(493, 229);
            this.vider.Name = "vider";
            this.vider.Size = new System.Drawing.Size(75, 23);
            this.vider.TabIndex = 13;
            this.vider.Text = "vider";
            this.vider.UseVisualStyleBackColor = true;
            this.vider.Click += new System.EventHandler(this.vider_Click);
            // 
            // GestionnaireClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vider);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.dataClients);
            this.Controls.Add(this.modifierClient);
            this.Controls.Add(this.supprimerClient);
            this.Controls.Add(this.ajouterClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientId);
            this.Controls.Add(this.ClientTel);
            this.Controls.Add(this.ClientPrenom);
            this.Controls.Add(this.ClientNom);
            this.Name = "GestionnaireClient";
            this.Text = "GestionClient";
            this.Load += new System.EventHandler(this.GestionnaireClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClientNom;
        private System.Windows.Forms.TextBox ClientPrenom;
        private System.Windows.Forms.TextBox ClientTel;
        private System.Windows.Forms.TextBox ClientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ajouterClient;
        private System.Windows.Forms.Button supprimerClient;
        private System.Windows.Forms.Button modifierClient;
        private System.Windows.Forms.DataGridView dataClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTel;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button vider;
    }
}