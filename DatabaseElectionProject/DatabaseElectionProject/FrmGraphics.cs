using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseElectionProject
{
    public partial class FrmGraphics : Form
    {
        public FrmGraphics()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FM26IC9\MSSQLSERVER02;Initial Catalog=DbElectionProject;Integrated Security=True");
        private void FrmGraphics_Load(object sender, EventArgs e)
        {
            // 1.Adım: İlçe adlarını Combobox'a çekme:
            baglanti.Open();
            SqlCommand komut = new SqlCommand ("SELECT DistrictName FROM Tbl_District", baglanti);
            SqlDataReader dr = komut.ExecuteReader(); 
            // ExecuteReader metodu, bir SQL sorgusunu çalıştırır ve sorgunun döndürdüğü sonuçları bir SqlDataReader nesnesine aktarır.
            // SqlDataReader, sorgudan dönen satırları satır satır okuyabilen bir veri okuyucudur.
            while (dr.Read())  // dr komutu okuma işlemi yaptığı müddetçe,
            {
                comboBox1.Items.Add(dr[0]);   // Combobox'ın içerine dr'den gelen 0.indexi(ilçe adlarını) ekle.
            }
            baglanti.Close();

            // 2.Adım: Grafiğe toplam sonuçları getirme:
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT SUM(Party_A), SUM(Party_B), SUM(Party_C), SUM(Party_D), SUM(Party_E) FROM Tbl_District", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Partisi", dr2[0]); // dr2[0] = SUM(Party_A)
                chart1.Series["Partiler"].Points.AddXY("B Partisi", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Partisi", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Partisi", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E Partisi", dr2[4]);
                chart1.ChartAreas[0].AxisX.Title = "Partiler";
                chart1.ChartAreas[0].AxisX.TitleFont = new Font("Georgia", 12, FontStyle.Bold);
                chart1.ChartAreas[0].AxisY.Title = "Toplam Oy sayıları";
                chart1.ChartAreas[0].AxisY.TitleFont = new Font("Georgia", 12, FontStyle.Bold);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 3.Adım: Seçilen ilçeye göre partilerin oy oranlarının ekrana getirilmesi:
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_District WHERE DistrictName=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                LblA.Text = dr[2].ToString();
                LblB.Text = dr[3].ToString();
                LblC.Text = dr[4].ToString();
                LblD.Text = dr[5].ToString();
                LblE.Text = dr[6].ToString();

            }
            baglanti.Close();
        }
    }
}
