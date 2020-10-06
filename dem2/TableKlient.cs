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
    public partial class TableKlient : Form
    {
        public TableKlient()
        {
            InitializeComponent();
           
            
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

 this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.___Dem2SkaredinDataSet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        private void TableKlient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2SkaredinDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.___Dem2SkaredinDataSet.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2SkaredinDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.___Dem2SkaredinDataSet.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2SkaredinDataSet.Client". При необходимости она может быть перемещена или удалена.

            try
            {
                tt.Visible = false;
                this.clientTableAdapter.Fill(this.___Dem2SkaredinDataSet.Client);
                if (Properties.Settings.Default.position == "Клиент")
                {
                    Redaktirovanie_Izmenenie.Visible = false;
                    clientBindingNavigatorSaveItem.Visible = false;
                    bindingNavigatorDeleteItem.Visible = false;
                    bindingNavigatorAddNewItem.Visible = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Redaktirovanie_Izmenenie_Click(object sender, EventArgs e)
        {
            
            try
            {

                Redakt_I_izmenenie_klienta redakt_I_Izmenenie_Klienta = new Redakt_I_izmenenie_klienta();
                redakt_I_Izmenenie_Klienta.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            try
            {
this.clientBindingSource.AddNew();

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

        private void filtr_Click(object sender, EventArgs e)
        {
           
            try
            {

                string tr = "FirstName like'*" + FIO.Text + "*' or LastName like'*" + FIO.Text + "*' or Patronymic like'*" + FIO.Text + "'";
                clientBindingSource.Filter = tr;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Vse_Click(object sender, EventArgs e)
        {
            
            try
            {

                clientBindingSource.Filter = tt.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
