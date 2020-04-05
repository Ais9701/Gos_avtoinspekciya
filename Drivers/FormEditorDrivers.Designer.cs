namespace Gos_avtoinspekciya.Authorization
{
    partial class FormEditorDrivers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditorDrivers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gos_avto_inspekciyaDataSet = new Gos_avtoinspekciya.Gos_avto_inspekciyaDataSet();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driversTableAdapter = new Gos_avtoinspekciya.Gos_avto_inspekciyaDataSetTableAdapters.DriversTableAdapter();
            this.tableAdapterManager = new Gos_avtoinspekciya.Gos_avto_inspekciyaDataSetTableAdapters.TableAdapterManager();
            this.driversBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.driversDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butBack = new System.Windows.Forms.Button();
            this.textBoxavtozapolnenie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonotobrazitvse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gos_avto_inspekciyaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingNavigator)).BeginInit();
            this.driversBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gos_avto_inspekciyaDataSet
            // 
            this.gos_avto_inspekciyaDataSet.DataSetName = "Gos_avto_inspekciyaDataSet";
            this.gos_avto_inspekciyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.gos_avto_inspekciyaDataSet;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Data_registrationTableAdapter = null;
            this.tableAdapterManager.DriversTableAdapter = this.driversTableAdapter;
            this.tableAdapterManager.Region_codesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gos_avtoinspekciya.Gos_avto_inspekciyaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // driversBindingNavigator
            // 
            this.driversBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.driversBindingNavigator.BindingSource = this.driversBindingSource;
            this.driversBindingNavigator.CountItem = null;
            this.driversBindingNavigator.DeleteItem = null;
            this.driversBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.driversBindingNavigator.Font = new System.Drawing.Font("Sitka Banner", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driversBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.driversBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorAddNewItem});
            this.driversBindingNavigator.Location = new System.Drawing.Point(592, 910);
            this.driversBindingNavigator.MoveFirstItem = null;
            this.driversBindingNavigator.MoveLastItem = null;
            this.driversBindingNavigator.MoveNextItem = null;
            this.driversBindingNavigator.MovePreviousItem = null;
            this.driversBindingNavigator.Name = "driversBindingNavigator";
            this.driversBindingNavigator.PositionItem = null;
            this.driversBindingNavigator.Size = new System.Drawing.Size(136, 44);
            this.driversBindingNavigator.TabIndex = 0;
            this.driversBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.BackColor = System.Drawing.Color.SpringGreen;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(114, 40);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 44);
            // 
            // driversDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Banner", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driversDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.driversDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 9.191489F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driversDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.driversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.driversDataGridView.DataSource = this.driversBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Banner", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.driversDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.driversDataGridView.Location = new System.Drawing.Point(0, 154);
            this.driversDataGridView.Name = "driversDataGridView";
            this.driversDataGridView.RowHeadersWidth = 60;
            this.driversDataGridView.RowTemplate.Height = 28;
            this.driversDataGridView.Size = new System.Drawing.Size(1924, 721);
            this.driversDataGridView.TabIndex = 1;
            this.driversDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.driversDataGridView_CellContentClick);
            this.driversDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.driversDataGridView_EditingControlShowing);
            this.driversDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.driversDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_drivers";
            this.dataGridViewTextBoxColumn1.FillWeight = 126.3158F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Водитель";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 147;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.FillWeight = 121.3775F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 141;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn3.FillWeight = 116.829F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 136;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "middlename";
            this.dataGridViewTextBoxColumn4.FillWeight = 112.6397F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 131;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "passport_serial";
            this.dataGridViewTextBoxColumn5.FillWeight = 108.7811F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Серия паспорта";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 127;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "passport_number";
            this.dataGridViewTextBoxColumn6.FillWeight = 105.2271F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер паспорта";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 122;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "postcode";
            this.dataGridViewTextBoxColumn7.FillWeight = 101.9537F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Почтовый индекс";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 119;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn8.FillWeight = 98.93871F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 115;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "address_life";
            this.dataGridViewTextBoxColumn9.FillWeight = 96.16174F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Место проживания";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 112;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "company";
            this.dataGridViewTextBoxColumn10.FillWeight = 93.60403F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Компания";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 109;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "jobname";
            this.dataGridViewTextBoxColumn11.FillWeight = 91.24824F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Название работы";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 106;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn12.FillWeight = 89.07841F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 104;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn13.FillWeight = 87.0799F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Элек.почта";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 101;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "photo";
            this.dataGridViewImageColumn1.FillWeight = 85.23917F;
            this.dataGridViewImageColumn1.HeaderText = "Фотография";
            this.dataGridViewImageColumn1.MinimumWidth = 7;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 99;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn14.FillWeight = 83.54375F;
            this.dataGridViewTextBoxColumn14.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 98;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "region";
            this.dataGridViewTextBoxColumn15.FillWeight = 81.98219F;
            this.dataGridViewTextBoxColumn15.HeaderText = "Регион";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 95;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Font = new System.Drawing.Font("Sitka Banner", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(999, 910);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.SpringGreen;
            this.butSave.Font = new System.Drawing.Font("Sitka Banner", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSave.Location = new System.Drawing.Point(757, 910);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(196, 61);
            this.butSave.TabIndex = 4;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1011, 974);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "(можно воспользоваться\r\nкнопкой DEL)\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gos_avtoinspekciya.Properties.Resources.gibdd_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.Color.MediumAquamarine;
            this.butBack.Font = new System.Drawing.Font("Sitka Banner", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butBack.Location = new System.Drawing.Point(1744, 910);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(168, 61);
            this.butBack.TabIndex = 10;
            this.butBack.Text = "Назад";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // textBoxavtozapolnenie
            // 
            this.textBoxavtozapolnenie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxavtozapolnenie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxavtozapolnenie.Location = new System.Drawing.Point(88, 910);
            this.textBoxavtozapolnenie.Name = "textBoxavtozapolnenie";
            this.textBoxavtozapolnenie.Size = new System.Drawing.Size(195, 26);
            this.textBoxavtozapolnenie.TabIndex = 11;
            this.textBoxavtozapolnenie.TextChanged += new System.EventHandler(this.textBoxavtozapolnenie_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 948);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Для поиска адреса \r\nвведите нужную букву";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonotobrazitvse
            // 
            this.buttonotobrazitvse.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonotobrazitvse.Font = new System.Drawing.Font("Sitka Banner", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonotobrazitvse.Location = new System.Drawing.Point(340, 908);
            this.buttonotobrazitvse.Name = "buttonotobrazitvse";
            this.buttonotobrazitvse.Size = new System.Drawing.Size(196, 61);
            this.buttonotobrazitvse.TabIndex = 13;
            this.buttonotobrazitvse.Text = "Отобразить все";
            this.buttonotobrazitvse.UseVisualStyleBackColor = false;
            this.buttonotobrazitvse.Click += new System.EventHandler(this.buttonotobrazitvse_Click);
            // 
            // FormEditorDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1051);
            this.Controls.Add(this.buttonotobrazitvse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxavtozapolnenie);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.driversDataGridView);
            this.Controls.Add(this.driversBindingNavigator);
            this.Name = "FormEditorDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование водителей";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInspertor_FormClosed);
            this.Load += new System.EventHandler(this.FormInspertor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gos_avto_inspekciyaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingNavigator)).EndInit();
            this.driversBindingNavigator.ResumeLayout(false);
            this.driversBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gos_avto_inspekciyaDataSet gos_avto_inspekciyaDataSet;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private Gos_avto_inspekciyaDataSetTableAdapters.DriversTableAdapter driversTableAdapter;
        private Gos_avto_inspekciyaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator driversBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.DataGridView driversDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.TextBox textBoxavtozapolnenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonotobrazitvse;
    }
}