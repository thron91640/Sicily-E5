namespace SicilyAPP
{
    /// <summary>
    /// class Form1 designer
    /// </summary>
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
            this.lBox = new System.Windows.Forms.ListBox();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CB1 = new System.Windows.Forms.ComboBox();
            this.CB2 = new System.Windows.Forms.ComboBox();
            this.TB4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBox
            // 
            this.lBox.FormattingEnabled = true;
            this.lBox.Location = new System.Drawing.Point(24, 66);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(837, 277);
            this.lBox.TabIndex = 1;
            this.lBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TB1
            // 
            this.TB1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB1.Enabled = false;
            this.TB1.Location = new System.Drawing.Point(24, 367);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(100, 20);
            this.TB1.TabIndex = 2;
            // 
            // TB2
            // 
            this.TB2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB2.Enabled = false;
            this.TB2.Location = new System.Drawing.Point(179, 367);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(100, 20);
            this.TB2.TabIndex = 3;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(347, 367);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(100, 20);
            this.TB3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "port d\'arrivé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "port de départ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "durée";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mettre à jour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CB1
            // 
            this.CB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB1.FormattingEnabled = true;
            this.CB1.Location = new System.Drawing.Point(24, 444);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(100, 21);
            this.CB1.TabIndex = 11;
            // 
            // CB2
            // 
            this.CB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB2.FormattingEnabled = true;
            this.CB2.Location = new System.Drawing.Point(179, 444);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(100, 21);
            this.CB2.TabIndex = 12;
            // 
            // TB4
            // 
            this.TB4.Location = new System.Drawing.Point(347, 445);
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(100, 20);
            this.TB4.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(511, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(756, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Afficher les tarifs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 508);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.CB2);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.lBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CB1;
        private System.Windows.Forms.ComboBox CB2;
        private System.Windows.Forms.TextBox TB4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

