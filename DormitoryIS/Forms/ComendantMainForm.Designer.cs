
namespace DormitoryIS.Forms
{
    partial class ComendantMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДеньРождения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Роль = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пол = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерГруппы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерКомнаты = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Удалить = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.roleField = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.genderField = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.birthDateField = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fullNameField = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userIdField = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutButton});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutButton
            // 
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(149, 22);
            this.AboutButton.Text = "О программе";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // usersGrid
            // 
            this.usersGrid.AllowUserToAddRows = false;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.userId,
            this.ФИО,
            this.ДеньРождения,
            this.Роль,
            this.Пол,
            this.НомерГруппы,
            this.НомерКомнаты,
            this.Удалить});
            this.usersGrid.Location = new System.Drawing.Point(0, 61);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.Size = new System.Drawing.Size(544, 323);
            this.usersGrid.TabIndex = 1;
            this.usersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGrid_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // userId
            // 
            this.userId.HeaderText = "userId";
            this.userId.Name = "userId";
            this.userId.Visible = false;
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            // 
            // ДеньРождения
            // 
            this.ДеньРождения.HeaderText = "День Рождения";
            this.ДеньРождения.Name = "ДеньРождения";
            this.ДеньРождения.Width = 50;
            // 
            // Роль
            // 
            this.Роль.HeaderText = "Роль";
            this.Роль.Name = "Роль";
            this.Роль.Width = 50;
            // 
            // Пол
            // 
            this.Пол.HeaderText = "Пол";
            this.Пол.Name = "Пол";
            this.Пол.Width = 50;
            // 
            // НомерГруппы
            // 
            this.НомерГруппы.HeaderText = "Номер группы";
            this.НомерГруппы.Name = "НомерГруппы";
            this.НомерГруппы.Width = 80;
            // 
            // НомерКомнаты
            // 
            this.НомерКомнаты.HeaderText = "Номер комнаты";
            this.НомерКомнаты.Name = "НомерКомнаты";
            this.НомерКомнаты.Width = 70;
            // 
            // Удалить
            // 
            this.Удалить.HeaderText = "Выселить";
            this.Удалить.Name = "Удалить";
            this.Удалить.Text = "Выселить";
            this.Удалить.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список студентов";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(2, 27);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(31, 31);
            this.addUserButton.TabIndex = 5;
            this.addUserButton.Text = "+";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // searchField
            // 
            this.searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchField.Location = new System.Drawing.Point(333, 37);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(134, 20);
            this.searchField.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(473, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(70, 21);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-4, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 410);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.usersGrid);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.searchField);
            this.tabPage1.Controls.Add(this.addUserButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.changePasswordButton);
            this.tabPage2.Controls.Add(this.roleField);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.genderField);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.birthDateField);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.fullNameField);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.userIdField);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Основная информация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(205, 6);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(119, 23);
            this.changePasswordButton.TabIndex = 31;
            this.changePasswordButton.Text = "Изменить пароль";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // roleField
            // 
            this.roleField.AutoSize = true;
            this.roleField.Location = new System.Drawing.Point(12, 158);
            this.roleField.Name = "roleField";
            this.roleField.Size = new System.Drawing.Size(35, 13);
            this.roleField.TabIndex = 26;
            this.roleField.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Роль";
            // 
            // genderField
            // 
            this.genderField.AutoSize = true;
            this.genderField.Location = new System.Drawing.Point(12, 122);
            this.genderField.Name = "genderField";
            this.genderField.Size = new System.Drawing.Size(35, 13);
            this.genderField.TabIndex = 24;
            this.genderField.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Пол";
            // 
            // birthDateField
            // 
            this.birthDateField.AutoSize = true;
            this.birthDateField.Location = new System.Drawing.Point(12, 86);
            this.birthDateField.Name = "birthDateField";
            this.birthDateField.Size = new System.Drawing.Size(35, 13);
            this.birthDateField.TabIndex = 22;
            this.birthDateField.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Дата рождения";
            // 
            // fullNameField
            // 
            this.fullNameField.AutoSize = true;
            this.fullNameField.Location = new System.Drawing.Point(12, 50);
            this.fullNameField.Name = "fullNameField";
            this.fullNameField.Size = new System.Drawing.Size(35, 13);
            this.fullNameField.TabIndex = 20;
            this.fullNameField.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ФИО";
            // 
            // userIdField
            // 
            this.userIdField.AutoSize = true;
            this.userIdField.Location = new System.Drawing.Point(12, 16);
            this.userIdField.Name = "userIdField";
            this.userIdField.Size = new System.Drawing.Size(35, 13);
            this.userIdField.TabIndex = 18;
            this.userIdField.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Id пользователя";
            // 
            // ComendantMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 433);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ComendantMainForm";
            this.Text = "ComendantMainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДеньРождения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Роль;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пол;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерГруппы;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерКомнаты;
        private System.Windows.Forms.DataGridViewButtonColumn Удалить;
        private System.Windows.Forms.ToolStripMenuItem LogOutButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Label roleField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label genderField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label birthDateField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fullNameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userIdField;
        private System.Windows.Forms.Label label2;
    }
}