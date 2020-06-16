namespace Pronote
{
    partial class Page_Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNomUtilisateur = new System.Windows.Forms.TextBox();
            this.textBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelMotDePasse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bouttonConnexion);
            // 
            // textBoxNomUtilisateur
            // 
            this.textBoxNomUtilisateur.Location = new System.Drawing.Point(90, 79);
            this.textBoxNomUtilisateur.Name = "textBoxNomUtilisateur";
            this.textBoxNomUtilisateur.Size = new System.Drawing.Size(98, 20);
            this.textBoxNomUtilisateur.TabIndex = 1;
            // 
            // textBoxMotDePasse
            // 
            this.textBoxMotDePasse.Location = new System.Drawing.Point(90, 179);
            this.textBoxMotDePasse.Name = "textBoxMotDePasse";
            this.textBoxMotDePasse.PasswordChar = '*';
            this.textBoxMotDePasse.Size = new System.Drawing.Size(100, 20);
            this.textBoxMotDePasse.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(90, 60);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(84, 13);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Nom Utilisateur :";
            // 
            // labelMotDePasse
            // 
            this.labelMotDePasse.AutoSize = true;
            this.labelMotDePasse.Location = new System.Drawing.Point(90, 160);
            this.labelMotDePasse.Name = "labelMotDePasse";
            this.labelMotDePasse.Size = new System.Drawing.Size(77, 13);
            this.labelMotDePasse.TabIndex = 4;
            this.labelMotDePasse.Text = "Mot de passe :";
            // 
            // Page_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 338);
            this.Controls.Add(this.labelMotDePasse);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxMotDePasse);
            this.Controls.Add(this.textBoxNomUtilisateur);
            this.Controls.Add(this.button1);
            this.Name = "Page_Connexion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Page_Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNomUtilisateur;
        private System.Windows.Forms.TextBox textBoxMotDePasse;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelMotDePasse;
    }
}

