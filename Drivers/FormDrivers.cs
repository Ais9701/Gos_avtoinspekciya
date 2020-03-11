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
    public partial class FormDrivers : Form
    {
        public FormDrivers()
        {
            InitializeComponent();
        }

        private void driversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gos_avto_inspekciyaDataSet);

        }

        private void FormDrivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gos_avto_inspekciyaDataSet.Drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.gos_avto_inspekciyaDataSet.Drivers);

        }

        private void FormDrivers_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEditorDrivers f14 = new FormEditorDrivers();
            f14.StartPosition = FormStartPosition.CenterScreen;
            f14.ShowDialog(this);
        }

        private void but_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Inspektor = Application.OpenForms[1];
            Inspektor.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Inspektor.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Inspektor.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Inspektor.Show(); // отображаем Form2
            this.Hide();
        }
    }
}
