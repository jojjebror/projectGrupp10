namespace form1
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
            this.rtInfo = new System.Windows.Forms.RichTextBox();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnSok = new System.Windows.Forms.Button();
            this.lblKategori = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblFrekvens = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.lbKategorier = new System.Windows.Forms.ListBox();
            this.lblNyKategori = new System.Windows.Forms.Label();
            this.lkLank = new System.Windows.Forms.LinkLabel();
            this.lbFeed = new System.Windows.Forms.ListBox();
            this.lbBox = new System.Windows.Forms.ListBox();
            this.lbAvsnitt = new System.Windows.Forms.ListBox();
            this.labelAvsnitt = new System.Windows.Forms.Label();
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
            this.lblKategorier.Location = new System.Drawing.Point(968, 251);
            this.lblKategorier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(82, 20);
            this.lblKategorier.TabIndex = 35;
            this.lblKategorier.Text = "Kategorier";
            // 
            // rtInfo
            // 
            this.rtInfo.Location = new System.Drawing.Point(972, 597);
            this.rtInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtInfo.Name = "rtInfo";
            this.rtInfo.Size = new System.Drawing.Size(535, 236);
            this.rtInfo.TabIndex = 33;
            this.rtInfo.Text = "";
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Location = new System.Drawing.Point(59, 502);
            this.lblAvsnitt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(0, 20);
            this.lblAvsnitt.TabIndex = 32;
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
            this.btnSok.Click += new System.EventHandler(this.btnSok_Click_1);
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
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(18, 374);
            this.txbUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(240, 26);
            this.txbUrl.TabIndex = 22;
            // 
            // lbKategorier
            // 
            this.lbKategorier.FormattingEnabled = true;
            this.lbKategorier.ItemHeight = 20;
            this.lbKategorier.Location = new System.Drawing.Point(972, 288);
            this.lbKategorier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbKategorier.Name = "lbKategorier";
            this.lbKategorier.Size = new System.Drawing.Size(530, 144);
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
            // lkLank
            // 
            this.lkLank.AutoSize = true;
            this.lkLank.Location = new System.Drawing.Point(26, 871);
            this.lkLank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkLank.Name = "lkLank";
            this.lkLank.Size = new System.Drawing.Size(80, 20);
            this.lkLank.TabIndex = 44;
            this.lkLank.TabStop = true;
            this.lkLank.Text = "linkLabel1";
            this.lkLank.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLank_LinkClicked_1);
            // 
            // lbFeed
            // 
            this.lbFeed.FormattingEnabled = true;
            this.lbFeed.ItemHeight = 20;
            this.lbFeed.Location = new System.Drawing.Point(18, 38);
            this.lbFeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbFeed.Name = "lbFeed";
            this.lbFeed.Size = new System.Drawing.Size(366, 224);
            this.lbFeed.TabIndex = 45;
            this.lbFeed.SelectedIndexChanged += new System.EventHandler(this.lbFeed_SelectedIndexChanged);
            // 
            // lbBox
            // 
            this.lbBox.FormattingEnabled = true;
            this.lbBox.ItemHeight = 20;
            this.lbBox.Location = new System.Drawing.Point(412, 38);
            this.lbBox.Name = "lbBox";
            this.lbBox.Size = new System.Drawing.Size(465, 224);
            this.lbBox.TabIndex = 46;
            // 
            // lbAvsnitt
            // 
            this.lbAvsnitt.FormattingEnabled = true;
            this.lbAvsnitt.ItemHeight = 20;
            this.lbAvsnitt.Location = new System.Drawing.Point(12, 535);
            this.lbAvsnitt.Name = "lbAvsnitt";
            this.lbAvsnitt.Size = new System.Drawing.Size(506, 224);
            this.lbAvsnitt.TabIndex = 47;
            this.lbAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lbAvsnitt_SelectedIndexChanged);
            // 
            // labelAvsnitt
            // 
            this.labelAvsnitt.AutoSize = true;
            this.labelAvsnitt.Location = new System.Drawing.Point(12, 502);
            this.labelAvsnitt.Name = "labelAvsnitt";
            this.labelAvsnitt.Size = new System.Drawing.Size(51, 20);
            this.labelAvsnitt.TabIndex = 48;
            this.labelAvsnitt.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 900);
            this.Controls.Add(this.labelAvsnitt);
            this.Controls.Add(this.lbAvsnitt);
            this.Controls.Add(this.lbBox);
            this.Controls.Add(this.lbFeed);
            this.Controls.Add(this.lkLank);
            this.Controls.Add(this.lblNyKategori);
            this.Controls.Add(this.lbKategorier);
            this.Controls.Add(this.btnKategorierTaBort);
            this.Controls.Add(this.btnKategorierLaggTill);
            this.Controls.Add(this.tbKategorier);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.rtInfo);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnSok);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblFrekvens);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txbUrl);
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
        private System.Windows.Forms.RichTextBox rtInfo;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button btnSok;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblFrekvens;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.ListBox lbKategorier;
        private System.Windows.Forms.Label lblNyKategori;
        private System.Windows.Forms.LinkLabel lkLank;
        private System.Windows.Forms.ListBox lbFeed;
        private System.Windows.Forms.ListBox lbBox;
        private System.Windows.Forms.ListBox lbAvsnitt;
        private System.Windows.Forms.Label labelAvsnitt;
    }
}

