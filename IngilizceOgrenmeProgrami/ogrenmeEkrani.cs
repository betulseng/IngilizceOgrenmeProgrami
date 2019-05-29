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
	public partial class ogrenmeEkrani : MetroFramework.Forms.MetroForm
	{
		public ogrenmeEkrani()
		{
			InitializeComponent();
		}

		OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Sozluk.mdb");
		DateTime zaman = DateTime.Today;
		private void KelimeGoster()
		{
			baglanti.Open();
			OleDbCommand kontrolKomut = new OleDbCommand("SELECT * FROM OgrenilmisKelimeler", baglanti);
			OleDbDataReader read;
			read = kontrolKomut.ExecuteReader();
			while (read.Read())
			{
				if (zaman.ToString() == read["OgrenildigiTarih"].ToString())
				{
					lblIngKelime.Text = read["IngKelime"].ToString();
					lblTrKelime.Text = read["TrKelime"].ToString();
					lblIngCumle.Text = read["IngCumle"].ToString();
					lblTrCumle.Text = read["TrCumle"].ToString();
					lblKelimeTuru.Text = read["KelimeTuru"].ToString();
				}
			}
			baglanti.Close();
		}

		private void ogrenmeEkrani_Load(object sender, EventArgs e)
		{
			KelimeGoster();
			
		}

		private void metroLabel7_Click(object sender, EventArgs e)
		{

		}
	}
}
