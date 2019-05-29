namespace IngilizceOgrenmeProgrami
{
	partial class anaEkran
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControlAnaEkran = new MetroFramework.Controls.MetroTabControl();
			this.tabPageSozlukEkrani = new MetroFramework.Controls.MetroTabPage();
			this.tileGuncelle = new MetroFramework.Controls.MetroTile();
			this.tileOgrenmeyeBasla = new MetroFramework.Controls.MetroTile();
			this.checkedListBoxSozluk = new System.Windows.Forms.CheckedListBox();
			this.tabPageOgrenilecekKelimeler = new MetroFramework.Controls.MetroTabPage();
			this.metroTileOgrenilecekGuncelle = new MetroFramework.Controls.MetroTile();
			this.tileIstatistik = new MetroFramework.Controls.MetroTile();
			this.listBoxOgrenilecekKelimeler = new System.Windows.Forms.ListBox();
			this.tabPageYeniKelimeEkle = new MetroFramework.Controls.MetroTabPage();
			this.tileAra = new MetroFramework.Controls.MetroTile();
			this.tileYeniKelimeEkle = new MetroFramework.Controls.MetroTile();
			this.txtBoxArama = new System.Windows.Forms.TextBox();
			this.lblAnaEkran = new MetroFramework.Controls.MetroLabel();
			this.txtBoxTrCumleEkle = new MetroFramework.Controls.MetroTextBox();
			this.txtBoxIngCumleEkle = new MetroFramework.Controls.MetroTextBox();
			this.txtBoxTurEkle = new MetroFramework.Controls.MetroTextBox();
			this.txtBoxTrEkle = new MetroFramework.Controls.MetroTextBox();
			this.txtBoxIngEkle = new MetroFramework.Controls.MetroTextBox();
			this.lblIngCumle = new MetroFramework.Controls.MetroLabel();
			this.lblTrCumle = new MetroFramework.Controls.MetroLabel();
			this.lblKelimeTuru = new MetroFramework.Controls.MetroLabel();
			this.lblTrHaliEkle = new MetroFramework.Controls.MetroLabel();
			this.lblIngHaliEkle = new MetroFramework.Controls.MetroLabel();
			this.lblEklemeBaslik = new MetroFramework.Controls.MetroLabel();
			this.tabControlAnaEkran.SuspendLayout();
			this.tabPageSozlukEkrani.SuspendLayout();
			this.tabPageOgrenilecekKelimeler.SuspendLayout();
			this.tabPageYeniKelimeEkle.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlAnaEkran
			// 
			this.tabControlAnaEkran.Controls.Add(this.tabPageSozlukEkrani);
			this.tabControlAnaEkran.Controls.Add(this.tabPageOgrenilecekKelimeler);
			this.tabControlAnaEkran.Controls.Add(this.tabPageYeniKelimeEkle);
			this.tabControlAnaEkran.Location = new System.Drawing.Point(23, 63);
			this.tabControlAnaEkran.Name = "tabControlAnaEkran";
			this.tabControlAnaEkran.SelectedIndex = 1;
			this.tabControlAnaEkran.Size = new System.Drawing.Size(640, 364);
			this.tabControlAnaEkran.TabIndex = 0;
			this.tabControlAnaEkran.UseSelectable = true;
			// 
			// tabPageSozlukEkrani
			// 
			this.tabPageSozlukEkrani.Controls.Add(this.tileGuncelle);
			this.tabPageSozlukEkrani.Controls.Add(this.tileOgrenmeyeBasla);
			this.tabPageSozlukEkrani.Controls.Add(this.checkedListBoxSozluk);
			this.tabPageSozlukEkrani.HorizontalScrollbarBarColor = true;
			this.tabPageSozlukEkrani.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPageSozlukEkrani.HorizontalScrollbarSize = 10;
			this.tabPageSozlukEkrani.Location = new System.Drawing.Point(4, 38);
			this.tabPageSozlukEkrani.Name = "tabPageSozlukEkrani";
			this.tabPageSozlukEkrani.Size = new System.Drawing.Size(632, 322);
			this.tabPageSozlukEkrani.TabIndex = 0;
			this.tabPageSozlukEkrani.Text = "Sözlük";
			this.tabPageSozlukEkrani.VerticalScrollbarBarColor = true;
			this.tabPageSozlukEkrani.VerticalScrollbarHighlightOnWheel = false;
			this.tabPageSozlukEkrani.VerticalScrollbarSize = 10;
			// 
			// tileGuncelle
			// 
			this.tileGuncelle.ActiveControl = null;
			this.tileGuncelle.Location = new System.Drawing.Point(455, 179);
			this.tileGuncelle.Name = "tileGuncelle";
			this.tileGuncelle.Size = new System.Drawing.Size(177, 143);
			this.tileGuncelle.TabIndex = 4;
			this.tileGuncelle.Text = "Listeyi Güncelle";
			this.tileGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileGuncelle.UseSelectable = true;
			this.tileGuncelle.Click += new System.EventHandler(this.tileGuncelle_Click);
			// 
			// tileOgrenmeyeBasla
			// 
			this.tileOgrenmeyeBasla.ActiveControl = null;
			this.tileOgrenmeyeBasla.Location = new System.Drawing.Point(454, 3);
			this.tileOgrenmeyeBasla.Name = "tileOgrenmeyeBasla";
			this.tileOgrenmeyeBasla.Size = new System.Drawing.Size(175, 169);
			this.tileOgrenmeyeBasla.TabIndex = 3;
			this.tileOgrenmeyeBasla.Text = "Öğrenmeye Başla";
			this.tileOgrenmeyeBasla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileOgrenmeyeBasla.UseSelectable = true;
			this.tileOgrenmeyeBasla.Click += new System.EventHandler(this.tileOgrenmeyeBasla_Click);
			// 
			// checkedListBoxSozluk
			// 
			this.checkedListBoxSozluk.FormattingEnabled = true;
			this.checkedListBoxSozluk.Location = new System.Drawing.Point(3, 3);
			this.checkedListBoxSozluk.Name = "checkedListBoxSozluk";
			this.checkedListBoxSozluk.Size = new System.Drawing.Size(445, 319);
			this.checkedListBoxSozluk.TabIndex = 2;
			this.checkedListBoxSozluk.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxSozluk_SelectedIndexChanged);
			// 
			// tabPageOgrenilecekKelimeler
			// 
			this.tabPageOgrenilecekKelimeler.Controls.Add(this.metroTileOgrenilecekGuncelle);
			this.tabPageOgrenilecekKelimeler.Controls.Add(this.tileIstatistik);
			this.tabPageOgrenilecekKelimeler.Controls.Add(this.listBoxOgrenilecekKelimeler);
			this.tabPageOgrenilecekKelimeler.HorizontalScrollbarBarColor = true;
			this.tabPageOgrenilecekKelimeler.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPageOgrenilecekKelimeler.HorizontalScrollbarSize = 10;
			this.tabPageOgrenilecekKelimeler.Location = new System.Drawing.Point(4, 38);
			this.tabPageOgrenilecekKelimeler.Name = "tabPageOgrenilecekKelimeler";
			this.tabPageOgrenilecekKelimeler.Size = new System.Drawing.Size(632, 322);
			this.tabPageOgrenilecekKelimeler.TabIndex = 1;
			this.tabPageOgrenilecekKelimeler.Text = "Ögrenilecek Kelimeler";
			this.tabPageOgrenilecekKelimeler.VerticalScrollbarBarColor = true;
			this.tabPageOgrenilecekKelimeler.VerticalScrollbarHighlightOnWheel = false;
			this.tabPageOgrenilecekKelimeler.VerticalScrollbarSize = 10;
			// 
			// metroTileOgrenilecekGuncelle
			// 
			this.metroTileOgrenilecekGuncelle.ActiveControl = null;
			this.metroTileOgrenilecekGuncelle.Location = new System.Drawing.Point(374, 261);
			this.metroTileOgrenilecekGuncelle.Name = "metroTileOgrenilecekGuncelle";
			this.metroTileOgrenilecekGuncelle.Size = new System.Drawing.Size(255, 58);
			this.metroTileOgrenilecekGuncelle.TabIndex = 4;
			this.metroTileOgrenilecekGuncelle.Text = "Listeyi Güncelle";
			this.metroTileOgrenilecekGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTileOgrenilecekGuncelle.UseSelectable = true;
			this.metroTileOgrenilecekGuncelle.Click += new System.EventHandler(this.metroTileOgrenilecekGuncelle_Click);
			// 
			// tileIstatistik
			// 
			this.tileIstatistik.ActiveControl = null;
			this.tileIstatistik.Location = new System.Drawing.Point(4, 261);
			this.tileIstatistik.Name = "tileIstatistik";
			this.tileIstatistik.Size = new System.Drawing.Size(363, 58);
			this.tileIstatistik.TabIndex = 3;
			this.tileIstatistik.Text = "İstatistikler";
			this.tileIstatistik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileIstatistik.UseSelectable = true;
			this.tileIstatistik.Click += new System.EventHandler(this.tileIstatistik_Click);
			// 
			// listBoxOgrenilecekKelimeler
			// 
			this.listBoxOgrenilecekKelimeler.FormattingEnabled = true;
			this.listBoxOgrenilecekKelimeler.Location = new System.Drawing.Point(0, 3);
			this.listBoxOgrenilecekKelimeler.Name = "listBoxOgrenilecekKelimeler";
			this.listBoxOgrenilecekKelimeler.Size = new System.Drawing.Size(629, 251);
			this.listBoxOgrenilecekKelimeler.TabIndex = 2;
			this.listBoxOgrenilecekKelimeler.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// tabPageYeniKelimeEkle
			// 
			this.tabPageYeniKelimeEkle.Controls.Add(this.tileAra);
			this.tabPageYeniKelimeEkle.Controls.Add(this.tileYeniKelimeEkle);
			this.tabPageYeniKelimeEkle.Controls.Add(this.txtBoxArama);
			this.tabPageYeniKelimeEkle.Controls.Add(this.lblAnaEkran);
			this.tabPageYeniKelimeEkle.Controls.Add(this.txtBoxTrCumleEkle);
			this.tabPageYeniKelimeEkle.Controls.Add(this.txtBoxIngCumleEkle);
			this.tabPageYeniKelimeEkle.Controls.Add(this.txtBoxTurEkle);
			this.tabPageYeniKelimeEkle.Controls.Add(this.txtBoxTrEkle);
			this.tabPageYeniKelimeEkle.Controls.Add(this.txtBoxIngEkle);
			this.tabPageYeniKelimeEkle.Controls.Add(this.lblIngCumle);
			this.tabPageYeniKelimeEkle.Controls.Add(this.lblTrCumle);
			this.tabPageYeniKelimeEkle.Controls.Add(this.lblKelimeTuru);
			this.tabPageYeniKelimeEkle.Controls.Add(this.lblTrHaliEkle);
			this.tabPageYeniKelimeEkle.Controls.Add(this.lblIngHaliEkle);
			this.tabPageYeniKelimeEkle.Controls.Add(this.lblEklemeBaslik);
			this.tabPageYeniKelimeEkle.HorizontalScrollbarBarColor = true;
			this.tabPageYeniKelimeEkle.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPageYeniKelimeEkle.HorizontalScrollbarSize = 10;
			this.tabPageYeniKelimeEkle.Location = new System.Drawing.Point(4, 38);
			this.tabPageYeniKelimeEkle.Name = "tabPageYeniKelimeEkle";
			this.tabPageYeniKelimeEkle.Size = new System.Drawing.Size(632, 322);
			this.tabPageYeniKelimeEkle.TabIndex = 2;
			this.tabPageYeniKelimeEkle.Text = "Yeni Kelime Ekleyin";
			this.tabPageYeniKelimeEkle.VerticalScrollbarBarColor = true;
			this.tabPageYeniKelimeEkle.VerticalScrollbarHighlightOnWheel = false;
			this.tabPageYeniKelimeEkle.VerticalScrollbarSize = 10;
			// 
			// tileAra
			// 
			this.tileAra.ActiveControl = null;
			this.tileAra.Location = new System.Drawing.Point(33, 132);
			this.tileAra.Name = "tileAra";
			this.tileAra.Size = new System.Drawing.Size(122, 40);
			this.tileAra.TabIndex = 43;
			this.tileAra.Text = "Ara";
			this.tileAra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileAra.UseSelectable = true;
			this.tileAra.Click += new System.EventHandler(this.tileAra_Click);
			// 
			// tileYeniKelimeEkle
			// 
			this.tileYeniKelimeEkle.ActiveControl = null;
			this.tileYeniKelimeEkle.Location = new System.Drawing.Point(370, 242);
			this.tileYeniKelimeEkle.Name = "tileYeniKelimeEkle";
			this.tileYeniKelimeEkle.Size = new System.Drawing.Size(167, 41);
			this.tileYeniKelimeEkle.TabIndex = 42;
			this.tileYeniKelimeEkle.Text = "Yeni Kelime Ekle";
			this.tileYeniKelimeEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tileYeniKelimeEkle.UseSelectable = true;
			this.tileYeniKelimeEkle.Visible = false;
			this.tileYeniKelimeEkle.Click += new System.EventHandler(this.tileYeniKelimeEkle_Click);
			// 
			// txtBoxArama
			// 
			this.txtBoxArama.Location = new System.Drawing.Point(3, 74);
			this.txtBoxArama.Name = "txtBoxArama";
			this.txtBoxArama.Size = new System.Drawing.Size(200, 20);
			this.txtBoxArama.TabIndex = 41;
			// 
			// lblAnaEkran
			// 
			this.lblAnaEkran.AutoSize = true;
			this.lblAnaEkran.Location = new System.Drawing.Point(3, 41);
			this.lblAnaEkran.Name = "lblAnaEkran";
			this.lblAnaEkran.Size = new System.Drawing.Size(152, 19);
			this.lblAnaEkran.TabIndex = 40;
			this.lblAnaEkran.Text = "Aradığınız kelimeyi girin:";
			// 
			// txtBoxTrCumleEkle
			// 
			// 
			// 
			// 
			this.txtBoxTrCumleEkle.CustomButton.Image = null;
			this.txtBoxTrCumleEkle.CustomButton.Location = new System.Drawing.Point(147, 1);
			this.txtBoxTrCumleEkle.CustomButton.Name = "";
			this.txtBoxTrCumleEkle.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtBoxTrCumleEkle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtBoxTrCumleEkle.CustomButton.TabIndex = 1;
			this.txtBoxTrCumleEkle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtBoxTrCumleEkle.CustomButton.UseSelectable = true;
			this.txtBoxTrCumleEkle.CustomButton.Visible = false;
			this.txtBoxTrCumleEkle.Lines = new string[0];
			this.txtBoxTrCumleEkle.Location = new System.Drawing.Point(421, 191);
			this.txtBoxTrCumleEkle.MaxLength = 32767;
			this.txtBoxTrCumleEkle.Name = "txtBoxTrCumleEkle";
			this.txtBoxTrCumleEkle.PasswordChar = '\0';
			this.txtBoxTrCumleEkle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtBoxTrCumleEkle.SelectedText = "";
			this.txtBoxTrCumleEkle.SelectionLength = 0;
			this.txtBoxTrCumleEkle.SelectionStart = 0;
			this.txtBoxTrCumleEkle.ShortcutsEnabled = true;
			this.txtBoxTrCumleEkle.Size = new System.Drawing.Size(169, 23);
			this.txtBoxTrCumleEkle.TabIndex = 39;
			this.txtBoxTrCumleEkle.UseSelectable = true;
			this.txtBoxTrCumleEkle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtBoxTrCumleEkle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtBoxIngCumleEkle
			// 
			// 
			// 
			// 
			this.txtBoxIngCumleEkle.CustomButton.Image = null;
			this.txtBoxIngCumleEkle.CustomButton.Location = new System.Drawing.Point(147, 1);
			this.txtBoxIngCumleEkle.CustomButton.Name = "";
			this.txtBoxIngCumleEkle.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtBoxIngCumleEkle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtBoxIngCumleEkle.CustomButton.TabIndex = 1;
			this.txtBoxIngCumleEkle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtBoxIngCumleEkle.CustomButton.UseSelectable = true;
			this.txtBoxIngCumleEkle.CustomButton.Visible = false;
			this.txtBoxIngCumleEkle.Lines = new string[0];
			this.txtBoxIngCumleEkle.Location = new System.Drawing.Point(421, 161);
			this.txtBoxIngCumleEkle.MaxLength = 32767;
			this.txtBoxIngCumleEkle.Name = "txtBoxIngCumleEkle";
			this.txtBoxIngCumleEkle.PasswordChar = '\0';
			this.txtBoxIngCumleEkle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtBoxIngCumleEkle.SelectedText = "";
			this.txtBoxIngCumleEkle.SelectionLength = 0;
			this.txtBoxIngCumleEkle.SelectionStart = 0;
			this.txtBoxIngCumleEkle.ShortcutsEnabled = true;
			this.txtBoxIngCumleEkle.Size = new System.Drawing.Size(169, 23);
			this.txtBoxIngCumleEkle.TabIndex = 38;
			this.txtBoxIngCumleEkle.UseSelectable = true;
			this.txtBoxIngCumleEkle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtBoxIngCumleEkle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtBoxTurEkle
			// 
			// 
			// 
			// 
			this.txtBoxTurEkle.CustomButton.Image = null;
			this.txtBoxTurEkle.CustomButton.Location = new System.Drawing.Point(147, 1);
			this.txtBoxTurEkle.CustomButton.Name = "";
			this.txtBoxTurEkle.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtBoxTurEkle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtBoxTurEkle.CustomButton.TabIndex = 1;
			this.txtBoxTurEkle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtBoxTurEkle.CustomButton.UseSelectable = true;
			this.txtBoxTurEkle.CustomButton.Visible = false;
			this.txtBoxTurEkle.Lines = new string[0];
			this.txtBoxTurEkle.Location = new System.Drawing.Point(422, 132);
			this.txtBoxTurEkle.MaxLength = 32767;
			this.txtBoxTurEkle.Name = "txtBoxTurEkle";
			this.txtBoxTurEkle.PasswordChar = '\0';
			this.txtBoxTurEkle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtBoxTurEkle.SelectedText = "";
			this.txtBoxTurEkle.SelectionLength = 0;
			this.txtBoxTurEkle.SelectionStart = 0;
			this.txtBoxTurEkle.ShortcutsEnabled = true;
			this.txtBoxTurEkle.Size = new System.Drawing.Size(169, 23);
			this.txtBoxTurEkle.TabIndex = 37;
			this.txtBoxTurEkle.UseSelectable = true;
			this.txtBoxTurEkle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtBoxTurEkle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtBoxTrEkle
			// 
			// 
			// 
			// 
			this.txtBoxTrEkle.CustomButton.Image = null;
			this.txtBoxTrEkle.CustomButton.Location = new System.Drawing.Point(147, 1);
			this.txtBoxTrEkle.CustomButton.Name = "";
			this.txtBoxTrEkle.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtBoxTrEkle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtBoxTrEkle.CustomButton.TabIndex = 1;
			this.txtBoxTrEkle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtBoxTrEkle.CustomButton.UseSelectable = true;
			this.txtBoxTrEkle.CustomButton.Visible = false;
			this.txtBoxTrEkle.Lines = new string[0];
			this.txtBoxTrEkle.Location = new System.Drawing.Point(422, 103);
			this.txtBoxTrEkle.MaxLength = 32767;
			this.txtBoxTrEkle.Name = "txtBoxTrEkle";
			this.txtBoxTrEkle.PasswordChar = '\0';
			this.txtBoxTrEkle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtBoxTrEkle.SelectedText = "";
			this.txtBoxTrEkle.SelectionLength = 0;
			this.txtBoxTrEkle.SelectionStart = 0;
			this.txtBoxTrEkle.ShortcutsEnabled = true;
			this.txtBoxTrEkle.Size = new System.Drawing.Size(169, 23);
			this.txtBoxTrEkle.TabIndex = 36;
			this.txtBoxTrEkle.UseSelectable = true;
			this.txtBoxTrEkle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtBoxTrEkle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtBoxIngEkle
			// 
			// 
			// 
			// 
			this.txtBoxIngEkle.CustomButton.Image = null;
			this.txtBoxIngEkle.CustomButton.Location = new System.Drawing.Point(147, 1);
			this.txtBoxIngEkle.CustomButton.Name = "";
			this.txtBoxIngEkle.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtBoxIngEkle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtBoxIngEkle.CustomButton.TabIndex = 1;
			this.txtBoxIngEkle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtBoxIngEkle.CustomButton.UseSelectable = true;
			this.txtBoxIngEkle.CustomButton.Visible = false;
			this.txtBoxIngEkle.Lines = new string[0];
			this.txtBoxIngEkle.Location = new System.Drawing.Point(422, 74);
			this.txtBoxIngEkle.MaxLength = 32767;
			this.txtBoxIngEkle.Name = "txtBoxIngEkle";
			this.txtBoxIngEkle.PasswordChar = '\0';
			this.txtBoxIngEkle.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtBoxIngEkle.SelectedText = "";
			this.txtBoxIngEkle.SelectionLength = 0;
			this.txtBoxIngEkle.SelectionStart = 0;
			this.txtBoxIngEkle.ShortcutsEnabled = true;
			this.txtBoxIngEkle.Size = new System.Drawing.Size(169, 23);
			this.txtBoxIngEkle.TabIndex = 35;
			this.txtBoxIngEkle.UseSelectable = true;
			this.txtBoxIngEkle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtBoxIngEkle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblIngCumle
			// 
			this.lblIngCumle.AutoSize = true;
			this.lblIngCumle.Location = new System.Drawing.Point(315, 163);
			this.lblIngCumle.Name = "lblIngCumle";
			this.lblIngCumle.Size = new System.Drawing.Size(100, 19);
			this.lblIngCumle.TabIndex = 34;
			this.lblIngCumle.Text = "İngilizce Cümle:";
			// 
			// lblTrCumle
			// 
			this.lblTrCumle.AutoSize = true;
			this.lblTrCumle.Location = new System.Drawing.Point(315, 191);
			this.lblTrCumle.Name = "lblTrCumle";
			this.lblTrCumle.Size = new System.Drawing.Size(90, 19);
			this.lblTrCumle.TabIndex = 33;
			this.lblTrCumle.Text = "Türkçe Cümle:";
			// 
			// lblKelimeTuru
			// 
			this.lblKelimeTuru.AutoSize = true;
			this.lblKelimeTuru.Location = new System.Drawing.Point(315, 135);
			this.lblKelimeTuru.Name = "lblKelimeTuru";
			this.lblKelimeTuru.Size = new System.Drawing.Size(96, 19);
			this.lblKelimeTuru.TabIndex = 32;
			this.lblKelimeTuru.Text = "Kelimenin Türü:";
			// 
			// lblTrHaliEkle
			// 
			this.lblTrHaliEkle.AutoSize = true;
			this.lblTrHaliEkle.Location = new System.Drawing.Point(315, 107);
			this.lblTrHaliEkle.Name = "lblTrHaliEkle";
			this.lblTrHaliEkle.Size = new System.Drawing.Size(91, 19);
			this.lblTrHaliEkle.TabIndex = 31;
			this.lblTrHaliEkle.Text = "Türkçe Kelime:";
			// 
			// lblIngHaliEkle
			// 
			this.lblIngHaliEkle.AutoSize = true;
			this.lblIngHaliEkle.Location = new System.Drawing.Point(315, 78);
			this.lblIngHaliEkle.Name = "lblIngHaliEkle";
			this.lblIngHaliEkle.Size = new System.Drawing.Size(101, 19);
			this.lblIngHaliEkle.TabIndex = 30;
			this.lblIngHaliEkle.Text = "İngilizce Kelime:";
			// 
			// lblEklemeBaslik
			// 
			this.lblEklemeBaslik.AutoSize = true;
			this.lblEklemeBaslik.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblEklemeBaslik.Location = new System.Drawing.Point(315, 35);
			this.lblEklemeBaslik.Name = "lblEklemeBaslik";
			this.lblEklemeBaslik.Size = new System.Drawing.Size(155, 25);
			this.lblEklemeBaslik.TabIndex = 29;
			this.lblEklemeBaslik.Text = "Yeni Kelime Ekleyin";
			// 
			// anaEkran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 450);
			this.Controls.Add(this.tabControlAnaEkran);
			this.Name = "anaEkran";
			this.Text = "Hoş Geldiniz!";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControlAnaEkran.ResumeLayout(false);
			this.tabPageSozlukEkrani.ResumeLayout(false);
			this.tabPageOgrenilecekKelimeler.ResumeLayout(false);
			this.tabPageYeniKelimeEkle.ResumeLayout(false);
			this.tabPageYeniKelimeEkle.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl tabControlAnaEkran;
		private MetroFramework.Controls.MetroTabPage tabPageSozlukEkrani;
		private System.Windows.Forms.CheckedListBox checkedListBoxSozluk;
		private MetroFramework.Controls.MetroTabPage tabPageOgrenilecekKelimeler;
		private System.Windows.Forms.ListBox listBoxOgrenilecekKelimeler;
		private MetroFramework.Controls.MetroTabPage tabPageYeniKelimeEkle;
		private MetroFramework.Controls.MetroTile tileGuncelle;
		private MetroFramework.Controls.MetroTile tileOgrenmeyeBasla;
		private MetroFramework.Controls.MetroTile tileIstatistik;
		private MetroFramework.Controls.MetroTile tileAra;
		private MetroFramework.Controls.MetroTile tileYeniKelimeEkle;
		private System.Windows.Forms.TextBox txtBoxArama;
		private MetroFramework.Controls.MetroLabel lblAnaEkran;
		private MetroFramework.Controls.MetroTextBox txtBoxTrCumleEkle;
		private MetroFramework.Controls.MetroTextBox txtBoxIngCumleEkle;
		private MetroFramework.Controls.MetroTextBox txtBoxTurEkle;
		private MetroFramework.Controls.MetroTextBox txtBoxTrEkle;
		private MetroFramework.Controls.MetroTextBox txtBoxIngEkle;
		private MetroFramework.Controls.MetroLabel lblIngCumle;
		private MetroFramework.Controls.MetroLabel lblTrCumle;
		private MetroFramework.Controls.MetroLabel lblKelimeTuru;
		private MetroFramework.Controls.MetroLabel lblTrHaliEkle;
		private MetroFramework.Controls.MetroLabel lblIngHaliEkle;
		private MetroFramework.Controls.MetroLabel lblEklemeBaslik;
		private MetroFramework.Controls.MetroTile metroTileOgrenilecekGuncelle;
	}
}

