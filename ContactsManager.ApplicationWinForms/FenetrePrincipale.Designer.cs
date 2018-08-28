namespace ContactsManager.ApplicationWinForms
{
    partial class FenetrePrincipale
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
            this.boutonNouveau = new System.Windows.Forms.Button();
            this.boutonSupprimer = new System.Windows.Forms.Button();
            this.grilleContacts = new System.Windows.Forms.DataGridView();
            this.Selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilleContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // boutonNouveau
            // 
            this.boutonNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonNouveau.Location = new System.Drawing.Point(675, 12);
            this.boutonNouveau.Name = "boutonNouveau";
            this.boutonNouveau.Size = new System.Drawing.Size(113, 23);
            this.boutonNouveau.TabIndex = 0;
            this.boutonNouveau.Text = "Nouveau contact";
            this.boutonNouveau.UseVisualStyleBackColor = true;
            this.boutonNouveau.Click += new System.EventHandler(this.boutonNouveau_Click);
            // 
            // boutonSupprimer
            // 
            this.boutonSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonSupprimer.Location = new System.Drawing.Point(675, 51);
            this.boutonSupprimer.Name = "boutonSupprimer";
            this.boutonSupprimer.Size = new System.Drawing.Size(113, 23);
            this.boutonSupprimer.TabIndex = 1;
            this.boutonSupprimer.Text = "Supprimer";
            this.boutonSupprimer.UseVisualStyleBackColor = true;
            // 
            // grilleContacts
            // 
            this.grilleContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grilleContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selection,
            this.Nom,
            this.Prenom,
            this.Telephone,
            this.Email,
            this.DateNaissance});
            this.grilleContacts.Location = new System.Drawing.Point(12, 12);
            this.grilleContacts.Name = "grilleContacts";
            this.grilleContacts.Size = new System.Drawing.Size(646, 426);
            this.grilleContacts.TabIndex = 2;
            // 
            // Selection
            // 
            this.Selection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Selection.HeaderText = "";
            this.Selection.Name = "Selection";
            this.Selection.Width = 21;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom";
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "Téléphone";
            this.Telephone.Name = "Telephone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // DateNaissance
            // 
            this.DateNaissance.DataPropertyName = "DateNaissance";
            this.DateNaissance.HeaderText = "Date de naissance";
            this.DateNaissance.Name = "DateNaissance";
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grilleContacts);
            this.Controls.Add(this.boutonSupprimer);
            this.Controls.Add(this.boutonNouveau);
            this.Name = "FenetrePrincipale";
            this.Text = "ContactsManager";
            this.Load += new System.EventHandler(this.FenetrePrincipale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilleContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boutonNouveau;
        private System.Windows.Forms.Button boutonSupprimer;
        private System.Windows.Forms.DataGridView grilleContacts;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissance;
    }
}