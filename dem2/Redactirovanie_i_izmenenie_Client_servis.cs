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
    public partial class Redactirovanie_i_izmenenie_Client_servis : Form
    {
        public Redactirovanie_i_izmenenie_Client_servis()
        {
            InitializeComponent();
        }

        private void clientServiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientServiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.___Dem2SkaredinDataSet);

        }

        private void Redactirovanie_i_izmenenie_Client_servis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2SkaredinDataSet.ClientService". При необходимости она может быть перемещена или удалена.
            this.clientServiceTableAdapter.Fill(this.___Dem2SkaredinDataSet.ClientService);

        }

        private void Nazad_Click(object sender, EventArgs e)
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
