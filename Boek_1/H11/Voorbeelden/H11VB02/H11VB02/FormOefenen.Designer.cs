namespace H11VB02
{
    partial class FormOefenen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opslaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opslaanAlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oefeningenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nederlandsEngelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engelsNederlandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxEngels = new System.Windows.Forms.TextBox();
            this.textBoxNederlands = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonToevoegen = new System.Windows.Forms.Button();
            this.buttonVerwijderen = new System.Windows.Forms.Button();
            this.listBoxWoorden = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.oefeningenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(353, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwToolStripMenuItem,
            this.openenToolStripMenuItem,
            this.opslaanToolStripMenuItem,
            this.opslaanAlsToolStripMenuItem,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // nieuwToolStripMenuItem
            // 
            this.nieuwToolStripMenuItem.Name = "nieuwToolStripMenuItem";
            this.nieuwToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nieuwToolStripMenuItem.Text = "Nieuw";
            this.nieuwToolStripMenuItem.Click += new System.EventHandler(this.nieuwToolStripMenuItem_Click);
            // 
            // openenToolStripMenuItem
            // 
            this.openenToolStripMenuItem.Name = "openenToolStripMenuItem";
            this.openenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openenToolStripMenuItem.Text = "Openen";
            this.openenToolStripMenuItem.Click += new System.EventHandler(this.openenToolStripMenuItem_Click);
            // 
            // opslaanToolStripMenuItem
            // 
            this.opslaanToolStripMenuItem.Name = "opslaanToolStripMenuItem";
            this.opslaanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.opslaanToolStripMenuItem.Text = "Opslaan";
            this.opslaanToolStripMenuItem.Click += new System.EventHandler(this.opslaanToolStripMenuItem_Click);
            // 
            // opslaanAlsToolStripMenuItem
            // 
            this.opslaanAlsToolStripMenuItem.Name = "opslaanAlsToolStripMenuItem";
            this.opslaanAlsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.opslaanAlsToolStripMenuItem.Text = "Opslaan als";
            this.opslaanAlsToolStripMenuItem.Click += new System.EventHandler(this.opslaanAlsToolStripMenuItem_Click);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // oefeningenToolStripMenuItem
            // 
            this.oefeningenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nederlandsEngelsToolStripMenuItem,
            this.engelsNederlandsToolStripMenuItem});
            this.oefeningenToolStripMenuItem.Name = "oefeningenToolStripMenuItem";
            this.oefeningenToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.oefeningenToolStripMenuItem.Text = "Oefeningen";
            // 
            // nederlandsEngelsToolStripMenuItem
            // 
            this.nederlandsEngelsToolStripMenuItem.Name = "nederlandsEngelsToolStripMenuItem";
            this.nederlandsEngelsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.nederlandsEngelsToolStripMenuItem.Text = "Nederlands - engels";
            this.nederlandsEngelsToolStripMenuItem.Click += new System.EventHandler(this.nederlandsEngelsToolStripMenuItem_Click);
            // 
            // engelsNederlandsToolStripMenuItem
            // 
            this.engelsNederlandsToolStripMenuItem.Name = "engelsNederlandsToolStripMenuItem";
            this.engelsNederlandsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.engelsNederlandsToolStripMenuItem.Text = "Engels - nederlands";
            // 
            // textBoxEngels
            // 
            this.textBoxEngels.Location = new System.Drawing.Point(102, 66);
            this.textBoxEngels.Name = "textBoxEngels";
            this.textBoxEngels.Size = new System.Drawing.Size(100, 20);
            this.textBoxEngels.TabIndex = 1;
            // 
            // textBoxNederlands
            // 
            this.textBoxNederlands.Location = new System.Drawing.Point(102, 40);
            this.textBoxNederlands.Name = "textBoxNederlands";
            this.textBoxNederlands.Size = new System.Drawing.Size(100, 20);
            this.textBoxNederlands.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nederlands:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Engels:";
            // 
            // buttonToevoegen
            // 
            this.buttonToevoegen.Location = new System.Drawing.Point(224, 37);
            this.buttonToevoegen.Name = "buttonToevoegen";
            this.buttonToevoegen.Size = new System.Drawing.Size(97, 23);
            this.buttonToevoegen.TabIndex = 5;
            this.buttonToevoegen.Text = "Toevoegen";
            this.buttonToevoegen.UseVisualStyleBackColor = true;
            this.buttonToevoegen.Click += new System.EventHandler(this.buttonToevoegen_Click);
            // 
            // buttonVerwijderen
            // 
            this.buttonVerwijderen.Location = new System.Drawing.Point(224, 64);
            this.buttonVerwijderen.Name = "buttonVerwijderen";
            this.buttonVerwijderen.Size = new System.Drawing.Size(97, 23);
            this.buttonVerwijderen.TabIndex = 6;
            this.buttonVerwijderen.Text = "Verwijderen";
            this.buttonVerwijderen.UseVisualStyleBackColor = true;
            this.buttonVerwijderen.Click += new System.EventHandler(this.buttonVerwijderen_Click);
            // 
            // listBoxWoorden
            // 
            this.listBoxWoorden.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWoorden.FormattingEnabled = true;
            this.listBoxWoorden.ItemHeight = 14;
            this.listBoxWoorden.Location = new System.Drawing.Point(35, 98);
            this.listBoxWoorden.Name = "listBoxWoorden";
            this.listBoxWoorden.Size = new System.Drawing.Size(286, 270);
            this.listBoxWoorden.TabIndex = 7;
            // 
            // FormOefenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 387);
            this.Controls.Add(this.listBoxWoorden);
            this.Controls.Add(this.buttonVerwijderen);
            this.Controls.Add(this.buttonToevoegen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNederlands);
            this.Controls.Add(this.textBoxEngels);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOefenen";
            this.Text = "Woorden oefenen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opslaanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opslaanAlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oefeningenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nederlandsEngelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engelsNederlandsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxEngels;
        private System.Windows.Forms.TextBox textBoxNederlands;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonToevoegen;
        private System.Windows.Forms.Button buttonVerwijderen;
        private System.Windows.Forms.ListBox listBoxWoorden;
    }
}

