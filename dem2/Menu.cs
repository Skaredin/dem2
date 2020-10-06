using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dem2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TableKlient tableKlient = new TableKlient();
                tableKlient.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Service service = new Service();
                service.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void клиентИУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            try
            {
                Client_Service_Tabl client_Service_Tabl = new Client_Service_Tabl();
                client_Service_Tabl.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
