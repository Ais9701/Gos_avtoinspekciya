namespace Gos_avtoinspekciya.Authorization
{
    partial class FormDrivers
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
            System.Windows.Forms.Label id_driversLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label middlenameLabel;
            System.Windows.Forms.Label passport_serialLabel;
            System.Windows.Forms.Label passport_numberLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label address_lifeLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label jobnameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label regionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrivers));
            this.driversBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gos_avto_inspekciyaDataSet = new Gos_avtoinspekciya.Gos_avto_inspekciyaDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.driversBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_driversTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.middlenameTextBox = new System.Windows.Forms.TextBox();
            this.passport_serialTextBox = new System.Windows.Forms.TextBox();
            this.passport_numberTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.address_lifeTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.jobnameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.but = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.driversTableAdapter = new Gos_avtoinspekciya.Gos_avto_inspekciyaDataSetTableAdapters.DriversTableAdapter();
            this.tableAdapterManager = new Gos_avtoinspekciya.Gos_avto_inspekciyaDataSetTableAdapters.TableAdapterManager();
            id_driversLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            middlenameLabel = new System.Windows.Forms.Label();
            passport_serialLabel = new System.Windows.Forms.Label();
            passport_numberLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            address_lifeLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            jobnameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingNavigator)).BeginInit();
            this.driversBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gos_avto_inspekciyaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_driversLabel
            // 
            id_driversLabel.AutoSize = true;
            id_driversLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_driversLabel.Location = new System.Drawing.Point(19, 82);
            id_driversLabel.Name = "id_driversLabel";
            id_driversLabel.Size = new System.Drawing.Size(133, 39);
            id_driversLabel.TabIndex = 1;
            id_driversLabel.Text = "Водитель:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(19, 113);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(76, 39);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Имя:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surnameLabel.Location = new System.Drawing.Point(19, 145);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(133, 39);
            surnameLabel.TabIndex = 5;
            surnameLabel.Text = "Фамилия:";
            // 
            // middlenameLabel
            // 
            middlenameLabel.AutoSize = true;
            middlenameLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middlenameLabel.Location = new System.Drawing.Point(19, 178);
            middlenameLabel.Name = "middlenameLabel";
            middlenameLabel.Size = new System.Drawing.Size(130, 39);
            middlenameLabel.TabIndex = 7;
            middlenameLabel.Text = "Отчество:";
            // 
            // passport_serialLabel
            // 
            passport_serialLabel.AutoSize = true;
            passport_serialLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passport_serialLabel.Location = new System.Drawing.Point(19, 210);
            passport_serialLabel.Name = "passport_serialLabel";
            passport_serialLabel.Size = new System.Drawing.Size(206, 39);
            passport_serialLabel.TabIndex = 9;
            passport_serialLabel.Text = "Серия паспорта:";
            // 
            // passport_numberLabel
            // 
            passport_numberLabel.AutoSize = true;
            passport_numberLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passport_numberLabel.Location = new System.Drawing.Point(19, 242);
            passport_numberLabel.Name = "passport_numberLabel";
            passport_numberLabel.Size = new System.Drawing.Size(211, 39);
            passport_numberLabel.TabIndex = 11;
            passport_numberLabel.Text = "Номер паспорта:";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            postcodeLabel.Location = new System.Drawing.Point(19, 273);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(232, 39);
            postcodeLabel.TabIndex = 13;
            postcodeLabel.Text = "Почтовый индекс:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(19, 306);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(91, 39);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "Адрес:";
            // 
            // address_lifeLabel
            // 
            address_lifeLabel.AutoSize = true;
            address_lifeLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            address_lifeLabel.Location = new System.Drawing.Point(19, 338);
            address_lifeLabel.Name = "address_lifeLabel";
            address_lifeLabel.Size = new System.Drawing.Size(248, 39);
            address_lifeLabel.TabIndex = 17;
            address_lifeLabel.Text = "Место проживания:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            companyLabel.Location = new System.Drawing.Point(19, 370);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(145, 39);
            companyLabel.TabIndex = 19;
            companyLabel.Text = "Компания:";
            // 
            // jobnameLabel
            // 
            jobnameLabel.AutoSize = true;
            jobnameLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            jobnameLabel.Location = new System.Drawing.Point(19, 402);
            jobnameLabel.Name = "jobnameLabel";
            jobnameLabel.Size = new System.Drawing.Size(225, 39);
            jobnameLabel.TabIndex = 21;
            jobnameLabel.Text = "Название работы:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(19, 433);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(122, 39);
            phoneLabel.TabIndex = 23;
            phoneLabel.Text = "Телефон:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(19, 465);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(154, 39);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "Элек.почта:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(19, 498);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(139, 39);
            descriptionLabel.TabIndex = 27;
            descriptionLabel.Text = "Описание:";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Font = new System.Drawing.Font("Sitka Banner", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            regionLabel.Location = new System.Drawing.Point(19, 530);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(106, 39);
            regionLabel.TabIndex = 29;
            regionLabel.Text = "Регион:";
            // 
            // driversBindingNavigator
            // 
            this.driversBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.driversBindingNavigator.BindingSource = this.driversBindingSource;
            this.driversBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.driversBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.driversBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.driversBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.driversBindingNavigatorSaveItem});
            this.driversBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.driversBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.driversBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.driversBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.driversBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.driversBindingNavigator.Name = "driversBindingNavigator";
            this.driversBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.driversBindingNavigator.Size = new System.Drawing.Size(891, 32);
            this.driversBindingNavigator.TabIndex = 0;
            this.driversBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.gos_avto_inspekciyaDataSet;
            // 
            // gos_avto_inspekciyaDataSet
            // 
            this.gos_avto_inspekciyaDataSet.DataSetName = "Gos_avto_inspekciyaDataSet";
            this.gos_avto_inspekciyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.191489F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // driversBindingNavigatorSaveItem
            // 
            this.driversBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driversBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("driversBindingNavigatorSaveItem.Image")));
            this.driversBindingNavigatorSaveItem.Name = "driversBindingNavigatorSaveItem";
            this.driversBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.driversBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.driversBindingNavigatorSaveItem.Visible = false;
            this.driversBindingNavigatorSaveItem.Click += new System.EventHandler(this.driversBindingNavigatorSaveItem_Click);
            // 
            // id_driversTextBox
            // 
            this.id_driversTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "id_drivers", true));
            this.id_driversTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_driversTextBox.ForeColor = System.Drawing.Color.Black;
            this.id_driversTextBox.Location = new System.Drawing.Point(279, 95);
            this.id_driversTextBox.Name = "id_driversTextBox";
            this.id_driversTextBox.Size = new System.Drawing.Size(208, 26);
            this.id_driversTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(279, 127);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(208, 26);
            this.nameTextBox.TabIndex = 4;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "surname", true));
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.ForeColor = System.Drawing.Color.Black;
            this.surnameTextBox.Location = new System.Drawing.Point(279, 159);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(208, 26);
            this.surnameTextBox.TabIndex = 6;
            // 
            // middlenameTextBox
            // 
            this.middlenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "middlename", true));
            this.middlenameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middlenameTextBox.ForeColor = System.Drawing.Color.Black;
            this.middlenameTextBox.Location = new System.Drawing.Point(279, 191);
            this.middlenameTextBox.Name = "middlenameTextBox";
            this.middlenameTextBox.Size = new System.Drawing.Size(208, 26);
            this.middlenameTextBox.TabIndex = 8;
            // 
            // passport_serialTextBox
            // 
            this.passport_serialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "passport_serial", true));
            this.passport_serialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passport_serialTextBox.ForeColor = System.Drawing.Color.Black;
            this.passport_serialTextBox.Location = new System.Drawing.Point(279, 223);
            this.passport_serialTextBox.Name = "passport_serialTextBox";
            this.passport_serialTextBox.Size = new System.Drawing.Size(208, 26);
            this.passport_serialTextBox.TabIndex = 10;
            // 
            // passport_numberTextBox
            // 
            this.passport_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "passport_number", true));
            this.passport_numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passport_numberTextBox.ForeColor = System.Drawing.Color.Black;
            this.passport_numberTextBox.Location = new System.Drawing.Point(279, 255);
            this.passport_numberTextBox.Name = "passport_numberTextBox";
            this.passport_numberTextBox.Size = new System.Drawing.Size(208, 26);
            this.passport_numberTextBox.TabIndex = 12;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "postcode", true));
            this.postcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postcodeTextBox.ForeColor = System.Drawing.Color.Black;
            this.postcodeTextBox.Location = new System.Drawing.Point(279, 287);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(208, 26);
            this.postcodeTextBox.TabIndex = 14;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressTextBox.Location = new System.Drawing.Point(279, 319);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(208, 26);
            this.addressTextBox.TabIndex = 16;
            // 
            // address_lifeTextBox
            // 
            this.address_lifeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "address_life", true));
            this.address_lifeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address_lifeTextBox.ForeColor = System.Drawing.Color.Black;
            this.address_lifeTextBox.Location = new System.Drawing.Point(279, 351);
            this.address_lifeTextBox.Name = "address_lifeTextBox";
            this.address_lifeTextBox.Size = new System.Drawing.Size(208, 26);
            this.address_lifeTextBox.TabIndex = 18;
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "company", true));
            this.companyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyTextBox.ForeColor = System.Drawing.Color.Black;
            this.companyTextBox.Location = new System.Drawing.Point(279, 383);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(208, 26);
            this.companyTextBox.TabIndex = 20;
            // 
            // jobnameTextBox
            // 
            this.jobnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "jobname", true));
            this.jobnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jobnameTextBox.ForeColor = System.Drawing.Color.Black;
            this.jobnameTextBox.Location = new System.Drawing.Point(279, 415);
            this.jobnameTextBox.Name = "jobnameTextBox";
            this.jobnameTextBox.Size = new System.Drawing.Size(208, 26);
            this.jobnameTextBox.TabIndex = 22;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.phoneTextBox.Location = new System.Drawing.Point(279, 447);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(208, 26);
            this.phoneTextBox.TabIndex = 24;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(279, 479);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(208, 26);
            this.emailTextBox.TabIndex = 26;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.Black;
            this.descriptionTextBox.Location = new System.Drawing.Point(279, 511);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(208, 26);
            this.descriptionTextBox.TabIndex = 28;
            // 
            // regionTextBox
            // 
            this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "region", true));
            this.regionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regionTextBox.ForeColor = System.Drawing.Color.Black;
            this.regionTextBox.Location = new System.Drawing.Point(279, 540);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(208, 26);
            this.regionTextBox.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(673, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 65);
            this.button1.TabIndex = 31;
            this.button1.Text = "Редактирование";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but
            // 
            this.but.BackColor = System.Drawing.Color.MediumAquamarine;
            this.but.Font = new System.Drawing.Font("Sitka Banner", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but.Location = new System.Drawing.Point(688, 517);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(191, 52);
            this.but.TabIndex = 32;
            this.but.Text = "Назад";
            this.but.UseVisualStyleBackColor = false;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gos_avtoinspekciya.Properties.Resources.gibdd_logo;
            this.pictureBox1.Location = new System.Drawing.Point(601, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
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
            // FormDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_driversLabel);
            this.Controls.Add(this.id_driversTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(middlenameLabel);
            this.Controls.Add(this.middlenameTextBox);
            this.Controls.Add(passport_serialLabel);
            this.Controls.Add(this.passport_serialTextBox);
            this.Controls.Add(passport_numberLabel);
            this.Controls.Add(this.passport_numberTextBox);
            this.Controls.Add(postcodeLabel);
            this.Controls.Add(this.postcodeTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(address_lifeLabel);
            this.Controls.Add(this.address_lifeTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(jobnameLabel);
            this.Controls.Add(this.jobnameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(regionLabel);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(this.driversBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.170213F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Водители";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDrivers_FormClosed);
            this.Load += new System.EventHandler(this.FormDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingNavigator)).EndInit();
            this.driversBindingNavigator.ResumeLayout(false);
            this.driversBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gos_avto_inspekciyaDataSet)).EndInit();
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
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton driversBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_driversTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox middlenameTextBox;
        private System.Windows.Forms.TextBox passport_serialTextBox;
        private System.Windows.Forms.TextBox passport_numberTextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox address_lifeTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox jobnameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}