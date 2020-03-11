using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gos_avtoinspekciya.Authorization
{
    public partial class FormInspektor : Form
    {
        public FormInspektor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new FormDrivers();
            ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            ifrm.Show(); // отображаем Form2
            this.Hide(); // скрываем Form1 (this - текущая форма)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Authorization = Application.OpenForms[0];
            Authorization.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Authorization.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Authorization.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Authorization.Show(); // отображаем Form2
            this.Hide();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
