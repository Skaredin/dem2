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
    public partial class Client_Service_Tabl : Form
    {
        public Client_Service_Tabl()
        {
            InitializeComponent();
        }

        private void clientServiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            try
            {
                this.Validate();
                this.clientServiceBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.___Dem2SkaredinDataSet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Client_Service_Tabl_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2SkaredinDataSet.ClientService". При необходимости она может быть перемещена или удалена.

                this.clientServiceTableAdapter.Fill(this.___Dem2SkaredinDataSet.ClientService);
                if (Properties.Settings.Default.position == "Клиент")
                {
                    izmenenie.Visible = false;
                    clientServiceBindingNavigatorSaveItem.Visible = false;
                    bindingNavigatorDeleteItem.Visible = false;
                    bindingNavigatorAddNewItem.Visible = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void izmenenie_Click(object sender, EventArgs e)
        {
            
            try
            {
                Redactirovanie_i_izmenenie_Client_servis redactirovanie_I_Izmenenie_Client_Servis = new Redactirovanie_i_izmenenie_Client_servis();
                redactirovanie_I_Izmenenie_Client_Servis.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            try
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
