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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        private void serviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            try
            {
                this.Validate();
                this.serviceBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.___Dem2SkaredinDataSet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Service_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2SkaredinDataSet.Service". При необходимости она может быть перемещена или удалена.
           
            try
            {
              

                this.serviceTableAdapter.Fill(this.___Dem2SkaredinDataSet.Service);
                if (Properties.Settings.Default.position == "Клиент")
                {
                    redaktirovanie.Visible = false;
                    serviceBindingNavigatorSaveItem.Visible = false;
                    bindingNavigatorDeleteItem.Visible = false;
                    bindingNavigatorAddNewItem.Visible = false;
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void redaktirovanie_Click(object sender, EventArgs e)
        {
            try
            {
                Redaktirovanie_i_izmenenie redaktirovanie_I_Izmenenie = new Redaktirovanie_i_izmenenie();
                redaktirovanie_I_Izmenenie.Show();
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

        private void FIO_TextChanged(object sender, EventArgs e)
        {
            
            try
            {

                string tr = "Title like'*" + FIO.Text + "*' or Description like'*" + FIO.Text + "'";
                serviceBindingSource.Filter = tr;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
