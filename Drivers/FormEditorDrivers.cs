using Gos_avtoinspekciya.Gos_avto_inspekciyaDataSetTableAdapters;
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
    public partial class FormEditorDrivers : Form
    {
        public FormEditorDrivers()
        {
            InitializeComponent();
        }

        private void driversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gos_avto_inspekciyaDataSet);

        }

        private void driversBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.driversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gos_avto_inspekciyaDataSet);

        }

        private void FormInspertor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gos_avto_inspekciyaDataSet.Drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.gos_avto_inspekciyaDataSet.Drivers);

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            driversTableAdapter.Update(gos_avto_inspekciyaDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            driversDataGridView.Rows.RemoveAt(driversDataGridView.CurrentCell.RowIndex);
            driversTableAdapter.Update(gos_avto_inspekciyaDataSet);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void FormInspertor_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Drivers = Application.OpenForms[2];
            Drivers.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Drivers.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Drivers.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Drivers.Show(); // отображаем Form2
            this.Hide();
        }
    }
}
