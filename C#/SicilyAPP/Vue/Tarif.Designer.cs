namespace SicilyAPP.Vue
{
    partial class Tarif
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
            this.LB1 = new System.Windows.Forms.ListBox();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.Location = new System.Drawing.Point(41, 29);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(592, 290);
            this.LB1.TabIndex = 0;
            this.LB1.SelectedIndexChanged += new System.EventHandler(this.LB1_SelectedIndexChanged);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(41, 344);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(100, 20);
            this.TB1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarif";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mettre à jour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.LB1);
            this.Name = "Tarif";
            this.Text = "Tarif";
            this.Load += new System.EventHandler(this.Tarif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}