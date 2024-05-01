using FireSharp.Config;
using FireSharp.Interfaces;
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
    
    public partial class frebaseekle : Form
    {
        IFirebaseConfig fb = new FirebaseConfig();
        frebasedata frebasedata = new frebasedata();
        public frebaseekle()
        {
            InitializeComponent();
        }
        IFirebaseClient client;
        private void frebaseekle_Load(object sender, EventArgs e)
        {
            frebasedata.FirebaseData();
            try
            {
                client = new FireSharp.FirebaseClient(fb);
            }
            catch
            {
                MessageBox.Show("Veri tabanına bağlanamadım, yolları ve linkleri kontrol et!");
            }
        }
    


        private void Çalışan_ekleme_btn_Click(object sender, EventArgs e)
        {
            frebasedata frebasedata = new frebasedata()
            {
                 
               
                adı = txtIsim.Text,
                soyadı = txtSoyisim.Text,
                telefonu = txtTelefon.Text,
                departmanı = txtDepartman.Text,
                şehri = txtSehir.Text,
                dogumyılı = txtDogumTarihi.Text,
                maaş = txtMaas.Text,
                mail = txtMail.Text,

            };
            var setet = client.Set("calısanlar/" + txtSoyisim + txtIsim + txtTelefon, frebasedata);
            MessageBox.Show(" "+ txtIsim +  " eklendi ");
        }
    }
}
