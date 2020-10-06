using dem2.Model;
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
    public partial class Avtorisacia : Form
    {
        public Avtorisacia()
        {
            InitializeComponent();
        }

        private void Avtorisacia_Load(object sender, EventArgs e)
        {

        }

        private void AvtorisaciaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var Entiti = Entities.GetContext().Client.Where(x => x.Login.Contains(LoginText.Text) && x.Passvord.Contains(PassvordText.Text)).ToList();

                if (LoginText.Text != "" && PassvordText.Text != "")
                {
                    if (Entiti.Count > 0 && Entiti[0].Dolgnost == "Администратор")
                    {
                        Properties.Settings.Default.id = Entiti[0].ID;
                        Properties.Settings.Default.position = Entiti[0].Dolgnost;
                        Menu mainMenu = new Menu();
                        mainMenu.Show();
                        this.Hide();
                        MessageBox.Show(Properties.Settings.Default.position);
                    }
                    else
                    if (Entiti.Count > 0 && Entiti[0].Dolgnost == "Клиент")
                    {
                        Properties.Settings.Default.id = Entiti[0].ID;
                        Properties.Settings.Default.position = Entiti[0].Dolgnost;
                        Menu mainMenu = new Menu();
                        mainMenu.Show();
                        this.Hide();
                        MessageBox.Show(Properties.Settings.Default.position);
                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя не существует"); 

                    }

                    try
                    {


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    try
                    {


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    try
                    {


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    try
                    {


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    try
                    {


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }








                    try
                    {


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    try
                    {


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }






                }
                else
                {
                    LoginText.BackColor = Color.Red;
                    PassvordText.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
           
        }
    }
}
