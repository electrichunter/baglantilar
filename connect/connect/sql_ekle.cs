using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connect
{
    public partial class sql_ekle : Form
    {
        public sql_ekle()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        sqldata sqldata = new sqldata();
        private void Çalışan_ekleme_btn_Click(object sender, EventArgs e)
        {
             try
            {
                string isim = txtIsim.Text;
                string soyisim = txtSoyisim.Text;
                string telefon = txtTelefon.Text;

                string departman = txtDepartman.Text;
                string sehir = txtSehir.Text;
                string dogumTarihi = txtDogumTarihi.Text;
                string maas = txtMaas.Text;
                string mail = txtMail.Text;

                sqldata.SqlEkle(isim, soyisim, telefon, departman, sehir, dogumTarihi, maas, mail);
               

                MessageBox.Show("Çalışan başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnaMenü_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

