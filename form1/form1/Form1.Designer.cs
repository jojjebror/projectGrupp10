﻿namespace form1
{
    partial class Form1
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
            this.btnKategorierTaBort = new System.Windows.Forms.Button();
            this.btnKategorierLaggTill = new System.Windows.Forms.Button();
            this.tbKategorier = new System.Windows.Forms.TextBox();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnSok = new System.Windows.Forms.Button();
            this.lblKategori = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblFrekvens = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbKategorier = new System.Windows.Forms.ListBox();
            this.lblNyKategori = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategorierTaBort
            // 
            this.btnKategorierTaBort.Location = new System.Drawing.Point(1392, 468);
            this.btnKategorierTaBort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKategorierTaBort.Name = "btnKategorierTaBort";
            this.btnKategorierTaBort.Size = new System.Drawing.Size(117, 35);
            this.btnKategorierTaBort.TabIndex = 40;
            this.btnKategorierTaBort.Text = "Ta Bort..";
            this.btnKategorierTaBort.UseVisualStyleBackColor = true;
            this.btnKategorierTaBort.Click += new System.EventHandler(this.btnKategorierTaBort_Click);
            // 
            // btnKategorierLaggTill
            // 
            this.btnKategorierLaggTill.Location = new System.Drawing.Point(1254, 468);
            this.btnKategorierLaggTill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKategorierLaggTill.Name = "btnKategorierLaggTill";
            this.btnKategorierLaggTill.Size = new System.Drawing.Size(112, 35);
            this.btnKategorierLaggTill.TabIndex = 39;
            this.btnKategorierLaggTill.Text = "Lägg Till";
            this.btnKategorierLaggTill.UseVisualStyleBackColor = true;
            this.btnKategorierLaggTill.Click += new System.EventHandler(this.btnKategorierLaggTill_Click);
            // 
            // tbKategorier
            // 
            this.tbKategorier.Location = new System.Drawing.Point(1074, 472);
            this.tbKategorier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbKategorier.Name = "tbKategorier";
            this.tbKategorier.Size = new System.Drawing.Size(133, 26);
            this.tbKategorier.TabIndex = 36;
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Location = new System.Drawing.Point(972, 9);
            this.lblKategorier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(82, 20);
            this.lblKategorier.TabIndex = 35;
            this.lblKategorier.Text = "Kategorier";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(972, 597);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(535, 236);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Location = new System.Drawing.Point(20, 568);
            this.lblAvsnitt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(57, 20);
            this.lblAvsnitt.TabIndex = 32;
            this.lblAvsnitt.Text = "Avsnitt";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(20, 597);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(894, 236);
            this.listView2.TabIndex = 31;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(801, 472);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(112, 35);
            this.btnTaBort.TabIndex = 30;
            this.btnTaBort.Text = "Ta Bort...";
            this.btnTaBort.UseVisualStyleBackColor = true;
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(632, 474);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(112, 35);
            this.btnSpara.TabIndex = 29;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(468, 474);
            this.btnSok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(112, 35);
            this.btnSok.TabIndex = 28;
            this.btnSok.Text = "Sök";
            this.btnSok.UseVisualStyleBackColor = true;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(454, 349);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(72, 20);
            this.lblKategori.TabIndex = 27;
            this.lblKategori.Text = "Kategori:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Mode"});
            this.comboBox2.Location = new System.Drawing.Point(459, 374);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 28);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblFrekvens
            // 
            this.lblFrekvens.AutoSize = true;
            this.lblFrekvens.Location = new System.Drawing.Point(264, 348);
            this.lblFrekvens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrekvens.Name = "lblFrekvens";
            this.lblFrekvens.Size = new System.Drawing.Size(169, 20);
            this.lblFrekvens.TabIndex = 25;
            this.lblFrekvens.Text = "Uppdateringsfrekvens:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 374);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 24;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(15, 351);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(46, 20);
            this.lblUrl.TabIndex = 23;
            this.lblUrl.Text = "URL:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 374);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 26);
            this.textBox1.TabIndex = 22;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(18, 18);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(895, 293);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Namn";
            this.columnHeader1.Width = 183;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Frekvens";
            this.columnHeader2.Width = 203;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.Width = 193;
            // 
            // lbKategorier
            // 
            this.lbKategorier.FormattingEnabled = true;
            this.lbKategorier.ItemHeight = 20;
            this.lbKategorier.Location = new System.Drawing.Point(976, 60);
            this.lbKategorier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbKategorier.Name = "lbKategorier";
            this.lbKategorier.Size = new System.Drawing.Size(530, 384);
            this.lbKategorier.TabIndex = 41;
            // 
            // lblNyKategori
            // 
            this.lblNyKategori.AutoSize = true;
            this.lblNyKategori.Location = new System.Drawing.Point(976, 482);
            this.lblNyKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNyKategori.Name = "lblNyKategori";
            this.lblNyKategori.Size = new System.Drawing.Size(92, 20);
            this.lblNyKategori.TabIndex = 42;
            this.lblNyKategori.Text = "Ny kategori:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 922);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNyKategori);
            this.Controls.Add(this.lbKategorier);
            this.Controls.Add(this.btnKategorierTaBort);
            this.Controls.Add(this.btnKategorierLaggTill);
            this.Controls.Add(this.tbKategorier);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnSok);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblFrekvens);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKategorierTaBort;
        private System.Windows.Forms.Button btnKategorierLaggTill;
        private System.Windows.Forms.TextBox tbKategorier;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button btnSok;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblFrekvens;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListBox lbKategorier;
        private System.Windows.Forms.Label lblNyKategori;
        private System.Windows.Forms.Button button1;
    }
}

