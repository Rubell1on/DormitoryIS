
namespace DormitoryIS.Forms
{
    partial class AddUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupIdField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studTicketIdField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.birthDateField = new System.Windows.Forms.DateTimePicker();
            this.genderField = new System.Windows.Forms.ComboBox();
            this.roleField = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.roomIdField = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // fullNameField
            // 
            this.fullNameField.Location = new System.Drawing.Point(16, 33);
            this.fullNameField.Name = "fullNameField";
            this.fullNameField.Size = new System.Drawing.Size(140, 20);
            this.fullNameField.TabIndex = 1;
            this.fullNameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullNameField_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "День рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пол";
            // 
            // groupIdField
            // 
            this.groupIdField.Location = new System.Drawing.Point(16, 150);
            this.groupIdField.Name = "groupIdField";
            this.groupIdField.Size = new System.Drawing.Size(140, 20);
            this.groupIdField.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер группы";
            // 
            // studTicketIdField
            // 
            this.studTicketIdField.Location = new System.Drawing.Point(186, 72);
            this.studTicketIdField.Name = "studTicketIdField";
            this.studTicketIdField.Size = new System.Drawing.Size(140, 20);
            this.studTicketIdField.TabIndex = 6;
            this.studTicketIdField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studTicketIdField_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(183, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер студ. билета";
            // 
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(186, 111);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(140, 20);
            this.userNameField.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(183, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Имя пользователя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(184, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Номер комнаты";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(16, 176);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(141, 23);
            this.addUserButton.TabIndex = 9;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // birthDateField
            // 
            this.birthDateField.Location = new System.Drawing.Point(16, 72);
            this.birthDateField.Name = "birthDateField";
            this.birthDateField.Size = new System.Drawing.Size(140, 20);
            this.birthDateField.TabIndex = 2;
            // 
            // genderField
            // 
            this.genderField.FormattingEnabled = true;
            this.genderField.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.genderField.Location = new System.Drawing.Point(16, 110);
            this.genderField.Name = "genderField";
            this.genderField.Size = new System.Drawing.Size(140, 21);
            this.genderField.TabIndex = 3;
            // 
            // roleField
            // 
            this.roleField.FormattingEnabled = true;
            this.roleField.Items.AddRange(new object[] {
            "Студент",
            "Администратор",
            "Комендант"});
            this.roleField.Location = new System.Drawing.Point(186, 32);
            this.roleField.Name = "roleField";
            this.roleField.Size = new System.Drawing.Size(140, 21);
            this.roleField.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(184, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Роль";
            // 
            // roomIdField
            // 
            this.roomIdField.FormattingEnabled = true;
            this.roomIdField.Items.AddRange(new object[] {
            "1",
            "2"});
            this.roomIdField.Location = new System.Drawing.Point(186, 149);
            this.roomIdField.Name = "roomIdField";
            this.roomIdField.Size = new System.Drawing.Size(140, 21);
            this.roomIdField.TabIndex = 8;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 207);
            this.Controls.Add(this.roomIdField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.roleField);
            this.Controls.Add(this.genderField);
            this.Controls.Add(this.birthDateField);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.studTicketIdField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupIdField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullNameField);
            this.Controls.Add(this.label1);
            this.Name = "AddUserForm";
            this.Text = "Добавить нового пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullNameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox groupIdField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studTicketIdField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.DateTimePicker birthDateField;
        private System.Windows.Forms.ComboBox genderField;
        private System.Windows.Forms.ComboBox roleField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox roomIdField;
    }
}