
namespace DormitoryIS.Forms
{
    partial class ChangePasswordForm
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
            this.oldPasswordField = new System.Windows.Forms.TextBox();
            this.newPasswordField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmNewPasswordField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите старый пароль";
            // 
            // oldPasswordField
            // 
            this.oldPasswordField.Location = new System.Drawing.Point(15, 25);
            this.oldPasswordField.Name = "oldPasswordField";
            this.oldPasswordField.Size = new System.Drawing.Size(172, 20);
            this.oldPasswordField.TabIndex = 1;
            // 
            // newPasswordField
            // 
            this.newPasswordField.Location = new System.Drawing.Point(15, 65);
            this.newPasswordField.Name = "newPasswordField";
            this.newPasswordField.Size = new System.Drawing.Size(172, 20);
            this.newPasswordField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите новый пароль";
            // 
            // confirmNewPasswordField
            // 
            this.confirmNewPasswordField.Location = new System.Drawing.Point(15, 107);
            this.confirmNewPasswordField.Name = "confirmNewPasswordField";
            this.confirmNewPasswordField.Size = new System.Drawing.Size(172, 20);
            this.confirmNewPasswordField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Подтвердите  новый пароль";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(15, 134);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(172, 23);
            this.changePasswordButton.TabIndex = 6;
            this.changePasswordButton.Text = "Сменить пароль";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 171);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.confirmNewPasswordField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPasswordField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldPasswordField);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordForm";
            this.Text = "Сменить пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPasswordField;
        private System.Windows.Forms.TextBox newPasswordField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmNewPasswordField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changePasswordButton;
    }
}