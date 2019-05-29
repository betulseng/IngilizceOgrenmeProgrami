using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace IngilizceOgrenmeProgrami
{
	public partial class anaEkran : MetroFramework.Forms.MetroForm
	{
		public anaEkran()
		{
			InitializeComponent();
		}

		OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Sozluk.mdb");

		public void KelimeListele()
		{
			baglanti.Open();
			OleDbCommand komut = new OleDbCommand();
			komut.Connection = baglanti;
			komut.CommandText = "SELECT * FROM KelimeSozlugu";
			komut.ExecuteNonQuery();
			OleDbDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				checkedListBoxSozluk.Items.Add(reader["IngKelime"].ToString() + "(" + reader["TrKelime"].ToString() + ")");

			}
			baglanti.Close();

		}

		bool kontrol = true;
		private void KelimeKontrol()
		{
			kontrol = true;
			baglanti.Open();
			OleDbCommand kontrolKomut = new OleDbCommand("SELECT * FROM KelimeSozlugu", baglanti);
			OleDbDataReader read;
			read = kontrolKomut.ExecuteReader();
			while (read.Read())
			{
				if (txtBoxArama.Text == read["IngKelime"].ToString() || txtBoxArama.Text == read["TrKelime"].ToString())
				{
					kontrol = false;
				}
			}
			baglanti.Close();
		}

		public void KelimeEkle()
		{
			OleDbCommand komut = new OleDbCommand();
			if (txtBoxIngEkle.Text != "" & txtBoxTrEkle.Text != "" & txtBoxIngCumleEkle.Text != "" & txtBoxTrCumleEkle.Text != "" & txtBoxTurEkle.Text != "")
			{
				komut.Connection = baglanti;
				komut.CommandText = "INSERT INTO KelimeSozlugu(IngKelime,TrKelime,IngCumle,TrCumle,KelimeTuru) VALUES ('" + txtBoxIngEkle.Text + "','" + txtBoxTrEkle.Text + "','" + txtBoxIngCumleEkle.Text + "','" + txtBoxTrCumleEkle.Text + "','" + txtBoxTurEkle.Text + "')";
				baglanti.Open();
				komut.ExecuteNonQuery();
				komut.Dispose();
				baglanti.Close();
				MetroFramework.MetroMessageBox.Show(this, "Kayıt Tamamlandı.", "UYARI", MessageBoxButtons.OK);
			}
			else
			{
				MetroFramework.MetroMessageBox.Show(this, "Boş Alan Bırakmayınız.", "UYARI", MessageBoxButtons.OK);
			}

		}

		public void OgrenilmisKelimeListele()
		{
			baglanti.Open();
			OleDbCommand komut = new OleDbCommand();
			komut.Connection = baglanti;
			komut.CommandText = "SELECT * FROM OgrenilmisKelimeler";
			komut.ExecuteNonQuery();
			OleDbDataReader read;
			read = komut.ExecuteReader();
			while (read.Read())
			{
				listBoxOgrenilecekKelimeler.Items.Add(read["IngKelime"].ToString() + " ->  " + read["TrKelime"].ToString() + "(" + read["OgrenildigiTarih"].ToString() + ")");
			}
			baglanti.Close();

		}

		public void SecilenKelimeler(List<int> index)
		{
			baglanti.Open();
			OleDbCommand kelimeBulmaKomutu = new OleDbCommand("SELECT * FROM KelimeSozlugu", baglanti);
			OleDbDataReader read;
			read = kelimeBulmaKomutu.ExecuteReader();
			while (read.Read())
			{
				foreach (int indx in index)
				{
					if (indx.ToString() == read["Kimlik"].ToString())
					{

						OleDbCommand kelimeTasiKomut = new OleDbCommand();
						kelimeTasiKomut.Connection = baglanti;
						kelimeTasiKomut.CommandText = "INSERT INTO OgrenilmisKelimeler(IngKelime,TrKelime,IngCumle,TrCumle,KelimeTuru,OgrenildigiTarih) VALUES ('" + read["IngKelime"].ToString() + "','" +
							read["TrKelime"].ToString() + "','" + read["IngCumle"].ToString() + "','" + read["TrCumle"].ToString() + "','" + read["KelimeTuru"].ToString() + "','" + DateTime.Today.ToString() + "')";
						kelimeTasiKomut.ExecuteNonQuery();
						kelimeTasiKomut.Dispose();

						//OleDbCommand silKomutu = new OleDbCommand("DELETE FROM KelimeSozlugu WHERE kimlik=@kimlik", baglanti);
						//silKomutu.Parameters.AddWithValue("@kimlik", read["Kimlik"]);
						//silKomutu.ExecuteNonQuery();

					}
				}
			}
			baglanti.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			KelimeListele();
			OgrenilmisKelimeListele();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void checkedListBoxSozluk_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index;
			index = checkedListBoxSozluk.SelectedIndex + 1;
			List<int> secilenKelimeIndex = new List<int>();
			secilenKelimeIndex.Add(index);

			SecilenKelimeler(secilenKelimeIndex);
			listBoxOgrenilecekKelimeler.Items.Clear();
			OgrenilmisKelimeListele();
		}

		private void tileAra_Click(object sender, EventArgs e)
		{
			KelimeKontrol();
			if (kontrol == true)
			{
				MetroFramework.MetroMessageBox.Show(this, "Kelime Bulunamadı" + Environment.NewLine + "Yeni Kelime Ekleyebilirsiniz.", "UYARI");
				tileYeniKelimeEkle.Visible = true;
			}
			else
			{
				MetroFramework.MetroMessageBox.Show(this, "Kelime Sözlükte Mevcuttur.", "UYARI");
				tileYeniKelimeEkle.Visible = false;
			}
		}

		private void tileYeniKelimeEkle_Click(object sender, EventArgs e)
		{
			KelimeEkle();
		}

		private void metroTileOgrenilecekGuncelle_Click(object sender, EventArgs e)
		{
			listBoxOgrenilecekKelimeler.Items.Clear();
			OgrenilmisKelimeListele();
			MetroFramework.MetroMessageBox.Show(this, "Liste Güncellendi.", "UYARI");
		}

		private void tileGuncelle_Click(object sender, EventArgs e)
		{
			checkedListBoxSozluk.Items.Clear();
			KelimeListele();
			MetroFramework.MetroMessageBox.Show(this, "Liste Güncellendi.", "UYARI");
		}

		private void tileOgrenmeyeBasla_Click(object sender, EventArgs e)
		{
			ogrenmeEkrani oEkran = new ogrenmeEkrani();
			oEkran.Show();
		}

		private void tileIstatistik_Click(object sender, EventArgs e)
		{
			Istatistikler ist = new Istatistikler();
			ist.Show();
		}
	}
}
