using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gos_avtoinspekciya.Authorization
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gos_avto_inspekciyaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gos_avto_inspekciyaDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.gos_avto_inspekciyaDataSet.Users);

        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            try
            {

                string loginUser = txtboxlog.Text;
                string passUser = txtboxpas.Text;
                ClassDB db = new ClassDB();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand commandGos_avto_inspekciya = new SqlCommand("SELECT * FROM [Users] WHERE Login = @uL AND Password = @uP AND Role= 'inspektor'", db.GetConnection());
                commandGos_avto_inspekciya.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandGos_avto_inspekciya.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter.SelectCommand = commandGos_avto_inspekciya;
                adapter.Fill(table);
             
                if (table.Rows.Count > 0)
                {
                    Form ifrm = new FormMenu();
                    ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                    ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                    ifrm.Show(); // отображаем Form2
                    this.Hide(); // скрываем Form1 (this - текущая форма)
                }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        txtboxlog.Clear();
                        txtboxpas.Clear();
                        a++;
                        if (a == 3)
                        {
                            a = 0;
                            timer1.Enabled = true;
                            butEnter.Enabled = false;
                            label1.Visible = true;
                            butExit.Enabled = false;
                            txtboxlog.Enabled = false;
                            txtboxpas.Enabled = false;
                        }
                    }
            }
            finally { }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int a = 0, b = 15, s = 0, d = 15;

        private void FormAuthorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b > 0)
            {
                b--;
                label1.Text = ("Вы заблокированы. Пожалуйста подождите: " + b);
                if (b == 0)
                {
                    b = d;
                    d += 5;
                    timer1.Enabled = false;
                    butEnter.Enabled = true;
                    label1.Visible = false;
                    butExit.Enabled = true;
                    label1.Text = "";
                    txtboxlog.Enabled = true;
                    txtboxpas.Enabled = true;
                }
            }
            s++;
        }
    }
    }
    

