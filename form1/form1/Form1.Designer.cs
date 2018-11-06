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
            this.cbInterval = new System.Windows.Forms.ComboBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.lblNyKategori = new System.Windows.Forms.Label();
            this.lkLank = new System.Windows.Forms.LinkLabel();
            this.lbBox = new System.Windows.Forms.ListBox();
            this.lbAvsnitt = new System.Windows.Forms.ListBox();
            this.labelAvsnitt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRensa = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Interval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAndra = new System.Windows.Forms.Button();
            this.lvSorteradePods = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAndraPod = new System.Windows.Forms.Button();
            this.lblSparade = new System.Windows.Forms.Label();
            this.lblKategorierFiltrerade = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbFeed = new System.Windows.Forms.ListBox();
            this.tbAndraPod = new System.Windows.Forms.TextBox();
            this.labelUtg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKategorierTaBort
            // 
            this.btnKategorierTaBort.Location = new System.Drawing.Point(1515, 552);
            this.btnKategorierTaBort.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnKategorierTaBort.Name = "btnKategorierTaBort";
            this.btnKategorierTaBort.Size = new System.Drawing.Size(176, 54);
            this.btnKategorierTaBort.TabIndex = 40;
            this.btnKategorierTaBort.Text = "Ta Bort..";
            this.btnKategorierTaBort.UseVisualStyleBackColor = true;
            this.btnKategorierTaBort.Click += new System.EventHandler(this.btnKategorierTaBort_Click);
            // 
            // btnKategorierLaggTill
            // 
            this.btnKategorierLaggTill.Location = new System.Drawing.Point(1335, 552);
            this.btnKategorierLaggTill.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnKategorierLaggTill.Name = "btnKategorierLaggTill";
            this.btnKategorierLaggTill.Size = new System.Drawing.Size(168, 54);
            this.btnKategorierLaggTill.TabIndex = 39;
            this.btnKategorierLaggTill.Text = "Lägg Till";
            this.btnKategorierLaggTill.UseVisualStyleBackColor = true;
            this.btnKategorierLaggTill.Click += new System.EventHandler(this.btnKategorierLaggTill_Click);
            // 
            // tbKategorier
            // 
            this.tbKategorier.Location = new System.Drawing.Point(1659, 622);
            this.tbKategorier.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbKategorier.Name = "tbKategorier";
            this.tbKategorier.Size = new System.Drawing.Size(199, 26);
            this.tbKategorier.TabIndex = 36;
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Location = new System.Drawing.Point(1292, 294);
            this.lblKategorier.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(82, 20);
            this.lblKategorier.TabIndex = 35;
            this.lblKategorier.Text = "Kategorier";
            // 
            // rtInfo
            // 
            this.rtInfo.Location = new System.Drawing.Point(1296, 823);
            this.rtInfo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rtInfo.Name = "rtInfo";
            this.rtInfo.Size = new System.Drawing.Size(562, 324);
            this.rtInfo.TabIndex = 33;
            this.rtInfo.Text = "";
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Location = new System.Drawing.Point(87, 772);
            this.lblAvsnitt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(0, 20);
            this.lblAvsnitt.TabIndex = 32;
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(579, 663);
            this.btnTaBort.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(168, 54);
            this.btnTaBort.TabIndex = 30;
            this.btnTaBort.Text = "Ta Bort...";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(399, 663);
            this.btnSpara.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(168, 54);
            this.btnSpara.TabIndex = 29;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(219, 663);
            this.btnSok.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(168, 54);
            this.btnSok.TabIndex = 28;
            this.btnSok.Text = "Sök";
            this.btnSok.UseVisualStyleBackColor = true;
            this.btnSok.Click += new System.EventHandler(this.btnSok_Click_1);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(626, 540);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(72, 20);
            this.lblKategori.TabIndex = 27;
            this.lblKategori.Text = "Kategori:";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(608, 575);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(186, 28);
            this.cbKategori.TabIndex = 26;
            // 
            // lblFrekvens
            // 
            this.lblFrekvens.AutoSize = true;
            this.lblFrekvens.Location = new System.Drawing.Point(396, 540);
            this.lblFrekvens.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFrekvens.Name = "lblFrekvens";
            this.lblFrekvens.Size = new System.Drawing.Size(169, 20);
            this.lblFrekvens.TabIndex = 25;
            this.lblFrekvens.Text = "Uppdateringsfrekvens:";
            // 
            // cbInterval
            // 
            this.cbInterval.FormattingEnabled = true;
            this.cbInterval.Location = new System.Drawing.Point(399, 575);
            this.cbInterval.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(194, 28);
            this.cbInterval.TabIndex = 24;
            this.cbInterval.SelectedIndexChanged += new System.EventHandler(this.cbInterval_SelectedIndexChanged);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(21, 540);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(46, 20);
            this.lblUrl.TabIndex = 23;
            this.lblUrl.Text = "URL:";
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(27, 575);
            this.txbUrl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(358, 26);
            this.txbUrl.TabIndex = 22;
            // 
            // lblNyKategori
            // 
            this.lblNyKategori.AutoSize = true;
            this.lblNyKategori.Location = new System.Drawing.Point(1551, 626);
            this.lblNyKategori.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNyKategori.Name = "lblNyKategori";
            this.lblNyKategori.Size = new System.Drawing.Size(92, 20);
            this.lblNyKategori.TabIndex = 42;
            this.lblNyKategori.Text = "Ny kategori:";
            // 
            // lkLank
            // 
            this.lkLank.AutoSize = true;
            this.lkLank.Location = new System.Drawing.Point(24, 1202);
            this.lkLank.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lkLank.Name = "lkLank";
            this.lkLank.Size = new System.Drawing.Size(80, 20);
            this.lkLank.TabIndex = 44;
            this.lkLank.TabStop = true;
            this.lkLank.Text = "linkLabel1";
            this.lkLank.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLank_LinkClicked_1);
            // 
            // lbBox
            // 
            this.lbBox.FormattingEnabled = true;
            this.lbBox.ItemHeight = 20;
            this.lbBox.Location = new System.Drawing.Point(414, 425);
            this.lbBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lbBox.Name = "lbBox";
            this.lbBox.Size = new System.Drawing.Size(379, 84);
            this.lbBox.TabIndex = 46;
            // 
            // lbAvsnitt
            // 
            this.lbAvsnitt.FormattingEnabled = true;
            this.lbAvsnitt.ItemHeight = 20;
            this.lbAvsnitt.Location = new System.Drawing.Point(20, 823);
            this.lbAvsnitt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lbAvsnitt.Name = "lbAvsnitt";
            this.lbAvsnitt.Size = new System.Drawing.Size(541, 324);
            this.lbAvsnitt.TabIndex = 47;
            this.lbAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lbAvsnitt_SelectedIndexChanged);
            // 
            // labelAvsnitt
            // 
            this.labelAvsnitt.AutoSize = true;
            this.labelAvsnitt.Location = new System.Drawing.Point(20, 772);
            this.labelAvsnitt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAvsnitt.Name = "labelAvsnitt";
            this.labelAvsnitt.Size = new System.Drawing.Size(51, 20);
            this.labelAvsnitt.TabIndex = 48;
            this.labelAvsnitt.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(39, 663);
            this.btnRensa.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(168, 54);
            this.btnRensa.TabIndex = 49;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.Interval});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(20, 58);
            this.listView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(595, 196);
            this.listView1.TabIndex = 50;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titel";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.Width = 100;
            // 
            // Interval
            // 
            this.Interval.Text = "Interval";
            this.Interval.Width = 117;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(1296, 322);
            this.listView2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(562, 219);
            this.listView2.TabIndex = 51;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori";
            this.columnHeader2.Width = 524;
            // 
            // btnAndra
            // 
            this.btnAndra.Location = new System.Drawing.Point(1702, 552);
            this.btnAndra.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(158, 54);
            this.btnAndra.TabIndex = 53;
            this.btnAndra.Text = "Ändra ";
            this.btnAndra.UseVisualStyleBackColor = true;
            this.btnAndra.Click += new System.EventHandler(this.btnAndra_Click);
            // 
            // lvSorteradePods
            // 
            this.lvSorteradePods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvSorteradePods.Location = new System.Drawing.Point(1296, 58);
            this.lvSorteradePods.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lvSorteradePods.Name = "lvSorteradePods";
            this.lvSorteradePods.Size = new System.Drawing.Size(562, 196);
            this.lvSorteradePods.TabIndex = 54;
            this.lvSorteradePods.UseCompatibleStateImageBehavior = false;
            this.lvSorteradePods.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Titel";
            this.columnHeader4.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kategori";
            this.columnHeader5.Width = 122;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Frekvens";
            // 
            // btnAndraPod
            // 
            this.btnAndraPod.Location = new System.Drawing.Point(644, 137);
            this.btnAndraPod.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAndraPod.Name = "btnAndraPod";
            this.btnAndraPod.Size = new System.Drawing.Size(150, 54);
            this.btnAndraPod.TabIndex = 55;
            this.btnAndraPod.Text = "Ändra";
            this.btnAndraPod.UseVisualStyleBackColor = true;
            this.btnAndraPod.Click += new System.EventHandler(this.btnAndraPod_Click);
            // 
            // lblSparade
            // 
            this.lblSparade.AutoSize = true;
            this.lblSparade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSparade.Location = new System.Drawing.Point(15, 14);
            this.lblSparade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSparade.Name = "lblSparade";
            this.lblSparade.Size = new System.Drawing.Size(124, 20);
            this.lblSparade.TabIndex = 56;
            this.lblSparade.Text = "Sparade poddar";
            // 
            // lblKategorierFiltrerade
            // 
            this.lblKategorierFiltrerade.AutoSize = true;
            this.lblKategorierFiltrerade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorierFiltrerade.Location = new System.Drawing.Point(1292, 14);
            this.lblKategorierFiltrerade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKategorierFiltrerade.Name = "lblKategorierFiltrerade";
            this.lblKategorierFiltrerade.Size = new System.Drawing.Size(151, 20);
            this.lblKategorierFiltrerade.TabIndex = 57;
            this.lblKategorierFiltrerade.Text = "Filtrerade kategorier";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 734);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 58;
            this.button1.Text = "Pausa Uppdatering";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbFeed
            // 
            this.lbFeed.FormattingEnabled = true;
            this.lbFeed.ItemHeight = 20;
            this.lbFeed.Location = new System.Drawing.Point(20, 425);
            this.lbFeed.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.lbFeed.Name = "lbFeed";
            this.lbFeed.Size = new System.Drawing.Size(380, 84);
            this.lbFeed.TabIndex = 45;
            this.lbFeed.SelectedIndexChanged += new System.EventHandler(this.lbFeed_SelectedIndexChanged);
            // 
            // tbAndraPod
            // 
            this.tbAndraPod.Location = new System.Drawing.Point(644, 97);
            this.tbAndraPod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAndraPod.Name = "tbAndraPod";
            this.tbAndraPod.Size = new System.Drawing.Size(148, 26);
            this.tbAndraPod.TabIndex = 59;
            // 
            // labelUtg
            // 
            this.labelUtg.AutoSize = true;
            this.labelUtg.Location = new System.Drawing.Point(20, 392);
            this.labelUtg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUtg.Name = "labelUtg";
            this.labelUtg.Size = new System.Drawing.Size(127, 20);
            this.labelUtg.TabIndex = 60;
            this.labelUtg.Text = "Utgivningsnamn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 391);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Ändra podnamn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1178);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUtg);
            this.Controls.Add(this.tbAndraPod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKategorierFiltrerade);
            this.Controls.Add(this.lblSparade);
            this.Controls.Add(this.btnAndraPod);
            this.Controls.Add(this.lvSorteradePods);
            this.Controls.Add(this.btnAndra);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.labelAvsnitt);
            this.Controls.Add(this.lbAvsnitt);
            this.Controls.Add(this.lbBox);
            this.Controls.Add(this.lbFeed);
            this.Controls.Add(this.lkLank);
            this.Controls.Add(this.lblNyKategori);
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
            this.Controls.Add(this.cbInterval);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txbUrl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
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
        private System.Windows.Forms.ComboBox cbInterval;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.Label lblNyKategori;
        private System.Windows.Forms.LinkLabel lkLank;
        private System.Windows.Forms.ListBox lbBox;
        private System.Windows.Forms.ListBox lbAvsnitt;
        private System.Windows.Forms.Label labelAvsnitt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAndra;
        private System.Windows.Forms.ListView lvSorteradePods;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAndraPod;
        private System.Windows.Forms.Label lblSparade;
        private System.Windows.Forms.Label lblKategorierFiltrerade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Interval;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListBox lbFeed;
        private System.Windows.Forms.TextBox tbAndraPod;
        private System.Windows.Forms.Label labelUtg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

