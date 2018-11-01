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
            this.components = new System.ComponentModel.Container();
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
            this.cbKategori = new System.Windows.Forms.ComboBox();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRensa = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnKategorierTaBort
            // 
            this.btnKategorierTaBort.Location = new System.Drawing.Point(928, 304);
            this.btnKategorierTaBort.Name = "btnKategorierTaBort";
            this.btnKategorierTaBort.Size = new System.Drawing.Size(78, 23);
            this.btnKategorierTaBort.TabIndex = 40;
            this.btnKategorierTaBort.Text = "Ta Bort..";
            this.btnKategorierTaBort.UseVisualStyleBackColor = true;
            this.btnKategorierTaBort.Click += new System.EventHandler(this.btnKategorierTaBort_Click);
            // 
            // btnKategorierLaggTill
            // 
            this.btnKategorierLaggTill.Location = new System.Drawing.Point(836, 304);
            this.btnKategorierLaggTill.Name = "btnKategorierLaggTill";
            this.btnKategorierLaggTill.Size = new System.Drawing.Size(75, 23);
            this.btnKategorierLaggTill.TabIndex = 39;
            this.btnKategorierLaggTill.Text = "Lägg Till";
            this.btnKategorierLaggTill.UseVisualStyleBackColor = true;
            this.btnKategorierLaggTill.Click += new System.EventHandler(this.btnKategorierLaggTill_Click);
            // 
            // tbKategorier
            // 
            this.tbKategorier.Location = new System.Drawing.Point(716, 307);
            this.tbKategorier.Name = "tbKategorier";
            this.tbKategorier.Size = new System.Drawing.Size(90, 20);
            this.tbKategorier.TabIndex = 36;
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Location = new System.Drawing.Point(645, 163);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(55, 13);
            this.lblKategorier.TabIndex = 35;
            this.lblKategorier.Text = "Kategorier";
            // 
            // rtInfo
            // 
            this.rtInfo.Location = new System.Drawing.Point(648, 388);
            this.rtInfo.Name = "rtInfo";
            this.rtInfo.Size = new System.Drawing.Size(358, 155);
            this.rtInfo.TabIndex = 33;
            this.rtInfo.Text = "";
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Location = new System.Drawing.Point(39, 326);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(0, 13);
            this.lblAvsnitt.TabIndex = 32;
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(534, 307);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(75, 23);
            this.btnTaBort.TabIndex = 30;
            this.btnTaBort.Text = "Ta Bort...";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(421, 308);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(75, 23);
            this.btnSpara.TabIndex = 29;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(312, 308);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(75, 23);
            this.btnSok.TabIndex = 28;
            this.btnSok.Text = "Sök";
            this.btnSok.UseVisualStyleBackColor = true;
            this.btnSok.Click += new System.EventHandler(this.btnSok_Click_1);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(303, 227);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(49, 13);
            this.lblKategori.TabIndex = 27;
            this.lblKategori.Text = "Kategori:";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(306, 243);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(121, 21);
            this.cbKategori.TabIndex = 26;
            // 
            // lblFrekvens
            // 
            this.lblFrekvens.AutoSize = true;
            this.lblFrekvens.Location = new System.Drawing.Point(176, 226);
            this.lblFrekvens.Name = "lblFrekvens";
            this.lblFrekvens.Size = new System.Drawing.Size(114, 13);
            this.lblFrekvens.TabIndex = 25;
            this.lblFrekvens.Text = "Uppdateringsfrekvens:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(10, 228);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 23;
            this.lblUrl.Text = "URL:";
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(12, 243);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(161, 20);
            this.txbUrl.TabIndex = 22;
            // 
            // lbKategorier
            // 
            this.lbKategorier.FormattingEnabled = true;
            this.lbKategorier.Location = new System.Drawing.Point(648, 187);
            this.lbKategorier.Name = "lbKategorier";
            this.lbKategorier.Size = new System.Drawing.Size(355, 95);
            this.lbKategorier.TabIndex = 41;
            // 
            // lblNyKategori
            // 
            this.lblNyKategori.AutoSize = true;
            this.lblNyKategori.Location = new System.Drawing.Point(651, 313);
            this.lblNyKategori.Name = "lblNyKategori";
            this.lblNyKategori.Size = new System.Drawing.Size(64, 13);
            this.lblNyKategori.TabIndex = 42;
            this.lblNyKategori.Text = "Ny kategori:";
            // 
            // lkLank
            // 
            this.lkLank.AutoSize = true;
            this.lkLank.Location = new System.Drawing.Point(17, 566);
            this.lkLank.Name = "lkLank";
            this.lkLank.Size = new System.Drawing.Size(55, 13);
            this.lkLank.TabIndex = 44;
            this.lkLank.TabStop = true;
            this.lkLank.Text = "linkLabel1";
            this.lkLank.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLank_LinkClicked_1);
            // 
            // lbFeed
            // 
            this.lbFeed.FormattingEnabled = true;
            this.lbFeed.Location = new System.Drawing.Point(12, 25);
            this.lbFeed.Name = "lbFeed";
            this.lbFeed.Size = new System.Drawing.Size(245, 147);
            this.lbFeed.TabIndex = 45;
            this.lbFeed.SelectedIndexChanged += new System.EventHandler(this.lbFeed_SelectedIndexChanged);
            // 
            // lbBox
            // 
            this.lbBox.FormattingEnabled = true;
            this.lbBox.Location = new System.Drawing.Point(269, 25);
            this.lbBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbBox.Name = "lbBox";
            this.lbBox.Size = new System.Drawing.Size(178, 147);
            this.lbBox.TabIndex = 46;
            // 
            // lbAvsnitt
            // 
            this.lbAvsnitt.FormattingEnabled = true;
            this.lbAvsnitt.Location = new System.Drawing.Point(8, 348);
            this.lbAvsnitt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbAvsnitt.Name = "lbAvsnitt";
            this.lbAvsnitt.Size = new System.Drawing.Size(339, 147);
            this.lbAvsnitt.TabIndex = 47;
            this.lbAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lbAvsnitt_SelectedIndexChanged);
            // 
            // labelAvsnitt
            // 
            this.labelAvsnitt.AutoSize = true;
            this.labelAvsnitt.Location = new System.Drawing.Point(8, 326);
            this.labelAvsnitt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAvsnitt.Name = "labelAvsnitt";
            this.labelAvsnitt.Size = new System.Drawing.Size(35, 13);
            this.labelAvsnitt.TabIndex = 48;
            this.labelAvsnitt.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(13, 280);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(75, 23);
            this.btnRensa.TabIndex = 49;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(480, 29);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(173, 128);
            this.listView1.TabIndex = 50;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titel";
            this.columnHeader1.Width = 246;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(674, 29);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(164, 128);
            this.listView2.TabIndex = 51;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 585);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRensa);
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
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.lblFrekvens);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txbUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ComboBox cbKategori;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

