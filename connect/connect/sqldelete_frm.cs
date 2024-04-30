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
    public partial class sqldelete_frm : Form
    {
        public sqldelete_frm()
        {
            InitializeComponent();
            datagrid_load();

        }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırın ID'sini al
                int customerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["KişiID"].Value);

                // SQL silme metodunu çağır
                sqldata sql = new sqldata();
                sql.Sqlsil(customerId);
                datagrid_load();
            }
            else
            {
                MessageBox.Show("Silinecek bir satır seçin.");
            }
        }

        private void sqldelete_frm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql_ekle sql_Ekle = new sql_ekle();
            sql_Ekle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
