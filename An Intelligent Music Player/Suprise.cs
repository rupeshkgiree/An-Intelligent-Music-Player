using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sobel_filtering
{
    public partial class Suprise : Form
    {
        Class2 ob = new Class2();
        public Suprise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry = "select Filepath from UploadFiles where FileName='" + comboBox1.SelectedItem.ToString() + "'";
            DataSet ds = ob.Display(qry);
            string s = ds.Tables[0].Rows[0][0].ToString();
            axWindowsMediaPlayer1.URL = s;
            axWindowsMediaPlayer1.Ctlcontrols.play();

            axWindowsMediaPlayer1.settings.autoStart = true;
        }

        

     

        private void Suprise_Load_1(object sender, EventArgs e)
        {
            

            string qry1 = "select FileName  from UploadFiles where categeory='Surprised'";
            DataSet ds1 = ob.Display(qry1);

            if (ds1.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow rd in ds1.Tables[0].Rows)
                {


                    comboBox1.Items.Add(rd["FileName"].ToString());


                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 cap = new Form3();
            cap.Show();
            this.Hide();
        }

       

        

    }
}