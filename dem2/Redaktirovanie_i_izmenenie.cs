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
    public partial class Redaktirovanie_i_izmenenie : Form
    {
        public Redaktirovanie_i_izmenenie()
        {
            InitializeComponent();
        }
        public void Nev()
        {
            try
            {
                serviceBindingSource.MoveNext();
                kartinka.Image = Image.FromFile(mainImagePathTextBox.Text.Replace(@" ", @""));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          


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

        private void Redaktirovanie_i_izmenenie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2SkaredinDataSet.Service". При необходимости она может быть перемещена или удалена.
           
            try
            {
                
                this.serviceTableAdapter.Fill(this.___Dem2SkaredinDataSet.Service);
                Nev();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            Nev();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.serviceBindingSource.MovePrevious();
               Nev();
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {
       
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Nev();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {

        }

        private void Nazad_Click_1(object sender, EventArgs e)
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
    }
}
