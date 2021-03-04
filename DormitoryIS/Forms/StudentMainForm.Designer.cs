
namespace DormitoryIS.Forms
{
    partial class StudentMainForm
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
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.studentTicketIdField = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupIdField = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.roleField = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.genderField = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.birthDateField = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fullNameField = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userIdField = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.roomMatesGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Группа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.roomNumField = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dormitoryNameField = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addCardButton = new System.Windows.Forms.Button();
            this.cardsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Удалить = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.notEnougthMoneyField = new System.Windows.Forms.Label();
            this.agreementAcceptedDateField = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paymentAmmountField = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.currentMoneyAmmountField = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lodgerIdField = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.topMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomMatesGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.инфоToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(415, 24);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogOutButton});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(109, 22);
            this.LogOutButton.Text = "Выйти";
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutButton});
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.инфоToolStripMenuItem.Text = "Справка";
            // 
            // AboutButton
            // 
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(149, 22);
            this.AboutButton.Text = "О программе";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(415, 377);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.changePasswordButton);
            this.tabPage1.Controls.Add(this.studentTicketIdField);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.groupIdField);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.roleField);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.genderField);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.birthDateField);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.fullNameField);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.userIdField);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основаная информация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // studentTicketIdField
            // 
            this.studentTicketIdField.AutoSize = true;
            this.studentTicketIdField.Location = new System.Drawing.Point(8, 52);
            this.studentTicketIdField.Name = "studentTicketIdField";
            this.studentTicketIdField.Size = new System.Drawing.Size(41, 13);
            this.studentTicketIdField.TabIndex = 15;
            this.studentTicketIdField.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(8, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "№ студенческого билета";
            // 
            // groupIdField
            // 
            this.groupIdField.AutoSize = true;
            this.groupIdField.Location = new System.Drawing.Point(8, 232);
            this.groupIdField.Name = "groupIdField";
            this.groupIdField.Size = new System.Drawing.Size(41, 13);
            this.groupIdField.TabIndex = 11;
            this.groupIdField.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "№ группы";
            // 
            // roleField
            // 
            this.roleField.AutoSize = true;
            this.roleField.Location = new System.Drawing.Point(8, 195);
            this.roleField.Name = "roleField";
            this.roleField.Size = new System.Drawing.Size(35, 13);
            this.roleField.TabIndex = 9;
            this.roleField.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Роль";
            // 
            // genderField
            // 
            this.genderField.AutoSize = true;
            this.genderField.Location = new System.Drawing.Point(8, 159);
            this.genderField.Name = "genderField";
            this.genderField.Size = new System.Drawing.Size(35, 13);
            this.genderField.TabIndex = 7;
            this.genderField.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Пол";
            // 
            // birthDateField
            // 
            this.birthDateField.AutoSize = true;
            this.birthDateField.Location = new System.Drawing.Point(8, 123);
            this.birthDateField.Name = "birthDateField";
            this.birthDateField.Size = new System.Drawing.Size(35, 13);
            this.birthDateField.TabIndex = 5;
            this.birthDateField.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата рождения";
            // 
            // fullNameField
            // 
            this.fullNameField.AutoSize = true;
            this.fullNameField.Location = new System.Drawing.Point(8, 87);
            this.fullNameField.Name = "fullNameField";
            this.fullNameField.Size = new System.Drawing.Size(35, 13);
            this.fullNameField.TabIndex = 3;
            this.fullNameField.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО";
            // 
            // userIdField
            // 
            this.userIdField.AutoSize = true;
            this.userIdField.Location = new System.Drawing.Point(8, 16);
            this.userIdField.Name = "userIdField";
            this.userIdField.Size = new System.Drawing.Size(35, 13);
            this.userIdField.TabIndex = 1;
            this.userIdField.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id пользователя";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.roomMatesGrid);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.roomNumField);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.addressField);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dormitoryNameField);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 351);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Соседи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // roomMatesGrid
            // 
            this.roomMatesGrid.AllowUserToAddRows = false;
            this.roomMatesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomMatesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomMatesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ФИО,
            this.Группа});
            this.roomMatesGrid.Location = new System.Drawing.Point(0, 188);
            this.roomMatesGrid.Name = "roomMatesGrid";
            this.roomMatesGrid.Size = new System.Drawing.Size(407, 163);
            this.roomMatesGrid.TabIndex = 23;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            // 
            // Группа
            // 
            this.Группа.HeaderText = "Группа";
            this.Группа.Name = "Группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Соседи";
            // 
            // roomNumField
            // 
            this.roomNumField.AutoSize = true;
            this.roomNumField.Location = new System.Drawing.Point(6, 52);
            this.roomNumField.Name = "roomNumField";
            this.roomNumField.Size = new System.Drawing.Size(41, 13);
            this.roomNumField.TabIndex = 21;
            this.roomNumField.Text = "label15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "№ комнаты";
            // 
            // addressField
            // 
            this.addressField.AutoSize = true;
            this.addressField.Location = new System.Drawing.Point(6, 87);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(35, 13);
            this.addressField.TabIndex = 19;
            this.addressField.Text = "label4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Адрес";
            // 
            // dormitoryNameField
            // 
            this.dormitoryNameField.AutoSize = true;
            this.dormitoryNameField.Location = new System.Drawing.Point(6, 16);
            this.dormitoryNameField.Name = "dormitoryNameField";
            this.dormitoryNameField.Size = new System.Drawing.Size(35, 13);
            this.dormitoryNameField.TabIndex = 17;
            this.dormitoryNameField.Text = "label2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Название общежития";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.addCardButton);
            this.tabPage3.Controls.Add(this.cardsGrid);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.notEnougthMoneyField);
            this.tabPage3.Controls.Add(this.agreementAcceptedDateField);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.paymentAmmountField);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.currentMoneyAmmountField);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.lodgerIdField);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(407, 351);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Лицевой счет";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // addCardButton
            // 
            this.addCardButton.BackColor = System.Drawing.Color.Transparent;
            this.addCardButton.Location = new System.Drawing.Point(326, 169);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(75, 23);
            this.addCardButton.TabIndex = 27;
            this.addCardButton.Text = "Добавить";
            this.addCardButton.UseVisualStyleBackColor = false;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // cardsGrid
            // 
            this.cardsGrid.AllowUserToAddRows = false;
            this.cardsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cardId,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Удалить});
            this.cardsGrid.Location = new System.Drawing.Point(0, 198);
            this.cardsGrid.Name = "cardsGrid";
            this.cardsGrid.Size = new System.Drawing.Size(407, 153);
            this.cardsGrid.TabIndex = 26;
            this.cardsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cardsGrid_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // cardId
            // 
            this.cardId.HeaderText = "cardId";
            this.cardId.Name = "cardId";
            this.cardId.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер карты";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Срок годности";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // Удалить
            // 
            this.Удалить.HeaderText = "Удалить";
            this.Удалить.Name = "Удалить";
            this.Удалить.Text = "Удалить";
            this.Удалить.Width = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Платежные средства";
            // 
            // notEnougthMoneyField
            // 
            this.notEnougthMoneyField.AutoSize = true;
            this.notEnougthMoneyField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notEnougthMoneyField.ForeColor = System.Drawing.Color.Red;
            this.notEnougthMoneyField.Location = new System.Drawing.Point(175, 87);
            this.notEnougthMoneyField.Name = "notEnougthMoneyField";
            this.notEnougthMoneyField.Size = new System.Drawing.Size(233, 13);
            this.notEnougthMoneyField.TabIndex = 24;
            this.notEnougthMoneyField.Text = "Необходимо пополнить лицевой счет!";
            // 
            // agreementAcceptedDateField
            // 
            this.agreementAcceptedDateField.AutoSize = true;
            this.agreementAcceptedDateField.Location = new System.Drawing.Point(8, 52);
            this.agreementAcceptedDateField.Name = "agreementAcceptedDateField";
            this.agreementAcceptedDateField.Size = new System.Drawing.Size(41, 13);
            this.agreementAcceptedDateField.TabIndex = 23;
            this.agreementAcceptedDateField.Text = "label15";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Дата заключения договора";
            // 
            // paymentAmmountField
            // 
            this.paymentAmmountField.AutoSize = true;
            this.paymentAmmountField.Location = new System.Drawing.Point(8, 123);
            this.paymentAmmountField.Name = "paymentAmmountField";
            this.paymentAmmountField.Size = new System.Drawing.Size(35, 13);
            this.paymentAmmountField.TabIndex = 21;
            this.paymentAmmountField.Text = "label6";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(8, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Стоимость проживания";
            // 
            // currentMoneyAmmountField
            // 
            this.currentMoneyAmmountField.AutoSize = true;
            this.currentMoneyAmmountField.Location = new System.Drawing.Point(8, 87);
            this.currentMoneyAmmountField.Name = "currentMoneyAmmountField";
            this.currentMoneyAmmountField.Size = new System.Drawing.Size(35, 13);
            this.currentMoneyAmmountField.TabIndex = 19;
            this.currentMoneyAmmountField.Text = "label4";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(8, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Средства на счете";
            // 
            // lodgerIdField
            // 
            this.lodgerIdField.AutoSize = true;
            this.lodgerIdField.Location = new System.Drawing.Point(8, 16);
            this.lodgerIdField.Name = "lodgerIdField";
            this.lodgerIdField.Size = new System.Drawing.Size(35, 13);
            this.lodgerIdField.TabIndex = 17;
            this.lodgerIdField.Text = "label2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(8, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "№ договора найма жилья";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(201, 6);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(119, 23);
            this.changePasswordButton.TabIndex = 16;
            this.changePasswordButton.Text = "Изменить пароль";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 406);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.topMenu);
            this.MainMenuStrip = this.topMenu;
            this.Name = "StudentMainForm";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomMatesGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutButton;
        private System.Windows.Forms.ToolStripMenuItem инфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label studentTicketIdField;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label groupIdField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label roleField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label genderField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label birthDateField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fullNameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userIdField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roomNumField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label addressField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dormitoryNameField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView roomMatesGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Группа;
        private System.Windows.Forms.Label agreementAcceptedDateField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label paymentAmmountField;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label currentMoneyAmmountField;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lodgerIdField;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label notEnougthMoneyField;
        private System.Windows.Forms.DataGridView cardsGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn Удалить;
        private System.Windows.Forms.Button changePasswordButton;
    }
}