namespace Pronote
{
    partial class PronoteProfesseur
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
            this.labelTitre = new System.Windows.Forms.Label();
            this.buttonEleveAbsent = new System.Windows.Forms.Button();
            this.listBoxEtudiant = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(33, 9);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(661, 108);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Super Pronote";
            // 
            // buttonEleveAbsent
            // 
            this.buttonEleveAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEleveAbsent.Location = new System.Drawing.Point(444, 287);
            this.buttonEleveAbsent.Name = "buttonEleveAbsent";
            this.buttonEleveAbsent.Size = new System.Drawing.Size(119, 33);
            this.buttonEleveAbsent.TabIndex = 1;
            this.buttonEleveAbsent.Text = "Elève Absent";
            this.buttonEleveAbsent.UseVisualStyleBackColor = true;
            this.buttonEleveAbsent.Click += new System.EventHandler(this.buttonEleveAbsent_Click);
            // 
            // listBoxEtudiant
            // 
            this.listBoxEtudiant.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBoxEtudiant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEtudiant.FormattingEnabled = true;
            this.listBoxEtudiant.ItemHeight = 25;
            this.listBoxEtudiant.Location = new System.Drawing.Point(51, 200);
            this.listBoxEtudiant.Name = "listBoxEtudiant";
            this.listBoxEtudiant.Size = new System.Drawing.Size(371, 404);
            this.listBoxEtudiant.TabIndex = 2;
            this.listBoxEtudiant.SelectedIndexChanged += new System.EventHandler(this.listBoxEtudiant_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(444, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Elève Présent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonElevePresent_Click);
            // 
            // PronoteProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxEtudiant);
            this.Controls.Add(this.buttonEleveAbsent);
            this.Controls.Add(this.labelTitre);
            this.Name = "PronoteProfesseur";
            this.Text = "PronoteProfesseur";
            this.Load += new System.EventHandler(this.PronoteProfesseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button buttonEleveAbsent;
        private System.Windows.Forms.ListBox listBoxEtudiant;
        private System.Windows.Forms.Button button1;
    }
}