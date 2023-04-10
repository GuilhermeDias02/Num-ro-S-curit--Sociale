namespace NumSs
{
    partial class Form1
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
            this.TxtNumSS = new System.Windows.Forms.TextBox();
            this.btnVerifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCle = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Erreur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNumSS
            // 
            this.TxtNumSS.Location = new System.Drawing.Point(190, 28);
            this.TxtNumSS.Name = "TxtNumSS";
            this.TxtNumSS.Size = new System.Drawing.Size(210, 22);
            this.TxtNumSS.TabIndex = 1;
            // 
            // btnVerifier
            // 
            this.btnVerifier.Location = new System.Drawing.Point(190, 69);
            this.btnVerifier.Name = "btnVerifier";
            this.btnVerifier.Size = new System.Drawing.Size(75, 23);
            this.btnVerifier.TabIndex = 2;
            this.btnVerifier.Text = "Valider";
            this.btnVerifier.UseVisualStyleBackColor = true;
            this.btnVerifier.Click += new System.EventHandler(this.btnVerifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numéro de sécurité sociale";
            // 
            // btnCle
            // 
            this.btnCle.Location = new System.Drawing.Point(15, 69);
            this.btnCle.Name = "btnCle";
            this.btnCle.Size = new System.Drawing.Size(75, 23);
            this.btnCle.TabIndex = 4;
            this.btnCle.Text = "Clé";
            this.btnCle.UseVisualStyleBackColor = true;
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(325, 69);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer.TabIndex = 5;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(456, 69);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(15, 397);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(129, 41);
            this.btnEnregistrer.TabIndex = 7;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(27, 210);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(135, 55);
            this.checkedListBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnCle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerifier);
            this.Controls.Add(this.TxtNumSS);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Analyse d\'un numéro de sécurité sociale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtNumSS;
        private System.Windows.Forms.Button btnVerifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCle;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
    }
}

