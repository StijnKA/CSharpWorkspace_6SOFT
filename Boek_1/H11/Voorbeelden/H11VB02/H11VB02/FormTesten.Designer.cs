namespace H11VB02
{
    partial class FormTesten
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
            this.buttonControle = new System.Windows.Forms.Button();
            this.buttonSluiten = new System.Windows.Forms.Button();
            this.textBoxNederlands = new System.Windows.Forms.TextBox();
            this.textBoxEngels = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelJuistFout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonControle
            // 
            this.buttonControle.Location = new System.Drawing.Point(36, 107);
            this.buttonControle.Name = "buttonControle";
            this.buttonControle.Size = new System.Drawing.Size(75, 23);
            this.buttonControle.TabIndex = 0;
            this.buttonControle.Text = "Controle";
            this.buttonControle.UseVisualStyleBackColor = true;
            this.buttonControle.Click += new System.EventHandler(this.buttonControle_Click);
            // 
            // buttonSluiten
            // 
            this.buttonSluiten.Location = new System.Drawing.Point(117, 107);
            this.buttonSluiten.Name = "buttonSluiten";
            this.buttonSluiten.Size = new System.Drawing.Size(75, 23);
            this.buttonSluiten.TabIndex = 1;
            this.buttonSluiten.Text = "Sluiten";
            this.buttonSluiten.UseVisualStyleBackColor = true;
            this.buttonSluiten.Click += new System.EventHandler(this.buttonSluiten_Click);
            // 
            // textBoxNederlands
            // 
            this.textBoxNederlands.Location = new System.Drawing.Point(92, 21);
            this.textBoxNederlands.Name = "textBoxNederlands";
            this.textBoxNederlands.ReadOnly = true;
            this.textBoxNederlands.Size = new System.Drawing.Size(100, 20);
            this.textBoxNederlands.TabIndex = 2;
            // 
            // textBoxEngels
            // 
            this.textBoxEngels.Location = new System.Drawing.Point(92, 47);
            this.textBoxEngels.Name = "textBoxEngels";
            this.textBoxEngels.Size = new System.Drawing.Size(100, 20);
            this.textBoxEngels.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nederlands:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Engels:";
            // 
            // labelJuistFout
            // 
            this.labelJuistFout.AutoSize = true;
            this.labelJuistFout.Location = new System.Drawing.Point(71, 79);
            this.labelJuistFout.Name = "labelJuistFout";
            this.labelJuistFout.Size = new System.Drawing.Size(0, 13);
            this.labelJuistFout.TabIndex = 6;
            // 
            // FormTesten
            // 
            this.AcceptButton = this.buttonControle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 139);
            this.Controls.Add(this.labelJuistFout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEngels);
            this.Controls.Add(this.textBoxNederlands);
            this.Controls.Add(this.buttonSluiten);
            this.Controls.Add(this.buttonControle);
            this.Name = "FormTesten";
            this.Text = "Testen...";
            this.Load += new System.EventHandler(this.FormTesten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonControle;
        private System.Windows.Forms.Button buttonSluiten;
        private System.Windows.Forms.TextBox textBoxNederlands;
        private System.Windows.Forms.TextBox textBoxEngels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelJuistFout;
    }
}