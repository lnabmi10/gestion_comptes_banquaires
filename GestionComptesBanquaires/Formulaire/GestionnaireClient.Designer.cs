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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.Prenom,
            this.NumeroTel});
            this.dataGridView1.Location = new System.Drawing.Point(126, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 150);
            this.dataGridView1.TabIndex = 11;
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
            // GestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ajouterClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientId);
            this.Controls.Add(this.ClientTel);
            this.Controls.Add(this.ClientPrenom);
            this.Controls.Add(this.ClientNom);
            this.Name = "GestionClient";
            this.Text = "GestionClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTel;
    }
}