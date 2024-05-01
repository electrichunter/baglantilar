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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqldata.Sqlbaglan();
        }

        sqldata sqldata = new sqldata();


  


        private void button1_Click(object sender, EventArgs e)
        {
          
}

        private void SqlEkle_btn_Click(object sender, EventArgs e)
        {
            sql_ekle sqlekle  = new sql_ekle();
          
            sqlekle.Show(); 
            this.Hide();
        }

        private void SqlDelete_btn_Click(object sender, EventArgs e)
        {
            sqldelete_frm sqldelete = new sqldelete_frm();
            sqldelete.Show();
            this.Hide();
        }

        private void Sqlupdate_btn_Click(object sender, EventArgs e)
        {
            sqlupdate_frm sqlupdate = new sqlupdate_frm();
            sqlupdate.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          frebaseekle fek = new frebaseekle();
           fek.Show();
            this.Hide();
        }
    }
}
