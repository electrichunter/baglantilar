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
    public partial class sqlupdate_frm : Form
    {
        
        private bool isEditing = false; // Hücre düzenleniyor mu?
        public sqlupdate_frm()
        {
            InitializeComponent();
            datagrid_load();
           
        }
        sqldata sqldata = new sqldata();

        private void datagrid_load()
        {
            sqldata sqlData = new sqldata();
            DataTable customerData = sqlData.GetCustomerData();

            if (customerData != null)
            {
                // DataGridView'e veri bağla
                dataGridView1.DataSource = customerData;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (isEditing)
                {
                    dataGridView1.EndEdit(); // Düzenlemeyi bitir
                    isEditing = false;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int customerId = Convert.ToInt32(row.Cells["KişiID"].Value); // ID'yi al
                        string newName = row.Cells["Isimler"].Value.ToString(); // Yeni değer
                        string newSurname = row.Cells["Soyisimler"].Value.ToString(); // Yeni değer
                        string newTelfon = row.Cells["Telefon"].Value.ToString();
                        string newDepart = row.Cells["Departman"].Value.ToString();
                        string newSehir = row.Cells["Sehir"].Value.ToString();
                        string newDt = row.Cells["DogumTarihi"].Value.ToString();
                        string newMaas = row.Cells["Maas"].Value.ToString();
                        string newMail = row.Cells["Mail"].Value.ToString();

                        // SQL'de güncelleme yap
                        sqldata.SqlUpdateCustomer(customerId , newName, newSurname, newTelfon, newDepart, newSehir, newDt, newMaas, newMail);
                    }

                    // **Save to database:**
                 //   sqldata.DeğişiklikleriKaydet(); 

                    // DataGridView'u yenile
                    datagrid_load();
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.BeginEdit(true); // Düzenleme moduna geç
                isEditing = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql_ekle sqlekle = new sql_ekle();

            sqlekle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqldelete_frm sqldelete = new sqldelete_frm();
            sqldelete.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
