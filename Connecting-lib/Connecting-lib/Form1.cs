using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connecting_lib
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        sql_data sql_Data = new sql_data();

        private void Form1_Load(object sender, EventArgs e)
        {
            sql_Data.Sqlbaglan();
        }

        private void button1_Click(object sender, EventArgs e)
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

                sql_Data.SqlEkle(isim, soyisim, telefon,departman, sehir, dogumTarihi, maas, mail);

                MessageBox.Show("Çalışan başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

