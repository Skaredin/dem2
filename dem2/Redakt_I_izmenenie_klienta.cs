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
    public partial class Redakt_I_izmenenie_klienta : Form
    {
        public Redakt_I_izmenenie_klienta()
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

        private void Redakt_I_izmenenie_klienta_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2SkaredinDataSet.Client". При необходимости она может быть перемещена или удалена.
          
            try
            {
  this.clientTableAdapter.Fill(this.___Dem2SkaredinDataSet.Client);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {

            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.___Dem2SkaredinDataSet);
                MessageBox.Show("Сохранилось");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void addd_Click(object sender, EventArgs e)
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

                TableKlient tableKlient = new TableKlient();
                tableKlient.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
