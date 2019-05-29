namespace IngilizceOgrenmeProgrami
{
	partial class Istatistikler
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartKelimeIstatistik = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chartKelimeIstatistik)).BeginInit();
			this.SuspendLayout();
			// 
			// chartKelimeIstatistik
			// 
			chartArea1.Name = "ChartArea1";
			this.chartKelimeIstatistik.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartKelimeIstatistik.Legends.Add(legend1);
			this.chartKelimeIstatistik.Location = new System.Drawing.Point(23, 63);
			this.chartKelimeIstatistik.Name = "chartKelimeIstatistik";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Kelime";
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
			this.chartKelimeIstatistik.Series.Add(series1);
			this.chartKelimeIstatistik.Size = new System.Drawing.Size(417, 297);
			this.chartKelimeIstatistik.TabIndex = 0;
			this.chartKelimeIstatistik.Text = "Kelime Öğrenme Bilgileri";
			this.chartKelimeIstatistik.Click += new System.EventHandler(this.chartKelimeIstatistik_Click);
			// 
			// Istatistikler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 394);
			this.Controls.Add(this.chartKelimeIstatistik);
			this.Name = "Istatistikler";
			this.Text = "Istatistikler";
			this.Load += new System.EventHandler(this.Istatistikler_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartKelimeIstatistik)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartKelimeIstatistik;
	}
}