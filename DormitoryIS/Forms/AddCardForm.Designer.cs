
namespace DormitoryIS.Forms
{
    partial class AddCardForm
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
            this.numField1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numField2 = new System.Windows.Forms.TextBox();
            this.numField3 = new System.Windows.Forms.TextBox();
            this.numField4 = new System.Windows.Forms.TextBox();
            this.expiryMonthField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ownerField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cvvField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.expiryYearField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите платежную информацию";
            // 
            // numField1
            // 
            this.numField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numField1.Location = new System.Drawing.Point(11, 55);
            this.numField1.MaxLength = 4;
            this.numField1.Name = "numField1";
            this.numField1.Size = new System.Drawing.Size(61, 23);
            this.numField1.TabIndex = 1;
            this.numField1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер карты";
            // 
            // numField2
            // 
            this.numField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numField2.Location = new System.Drawing.Point(78, 55);
            this.numField2.MaxLength = 4;
            this.numField2.Name = "numField2";
            this.numField2.Size = new System.Drawing.Size(61, 23);
            this.numField2.TabIndex = 2;
            this.numField2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // numField3
            // 
            this.numField3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numField3.Location = new System.Drawing.Point(145, 55);
            this.numField3.MaxLength = 4;
            this.numField3.Name = "numField3";
            this.numField3.Size = new System.Drawing.Size(61, 23);
            this.numField3.TabIndex = 3;
            this.numField3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // numField4
            // 
            this.numField4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numField4.Location = new System.Drawing.Point(212, 55);
            this.numField4.MaxLength = 4;
            this.numField4.Name = "numField4";
            this.numField4.Size = new System.Drawing.Size(61, 23);
            this.numField4.TabIndex = 4;
            this.numField4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // expiryMonthField
            // 
            this.expiryMonthField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiryMonthField.Location = new System.Drawing.Point(11, 108);
            this.expiryMonthField.MaxLength = 2;
            this.expiryMonthField.Name = "expiryMonthField";
            this.expiryMonthField.Size = new System.Drawing.Size(29, 23);
            this.expiryMonthField.TabIndex = 5;
            this.expiryMonthField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Срок годности";
            // 
            // ownerField
            // 
            this.ownerField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ownerField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ownerField.Location = new System.Drawing.Point(11, 158);
            this.ownerField.MaxLength = 100;
            this.ownerField.Name = "ownerField";
            this.ownerField.Size = new System.Drawing.Size(152, 23);
            this.ownerField.TabIndex = 7;
            this.ownerField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLetter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Владелец карты";
            // 
            // cvvField
            // 
            this.cvvField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvvField.Location = new System.Drawing.Point(145, 108);
            this.cvvField.MaxLength = 3;
            this.cvvField.Name = "cvvField";
            this.cvvField.Size = new System.Drawing.Size(61, 23);
            this.cvvField.TabIndex = 8;
            this.cvvField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(142, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "CVV";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить карту";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddCard);
            // 
            // expiryYearField
            // 
            this.expiryYearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiryYearField.Location = new System.Drawing.Point(58, 108);
            this.expiryYearField.MaxLength = 2;
            this.expiryYearField.Name = "expiryYearField";
            this.expiryYearField.Size = new System.Drawing.Size(29, 23);
            this.expiryYearField.TabIndex = 6;
            this.expiryYearField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(43, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "/";
            // 
            // AddCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 189);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.expiryYearField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cvvField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ownerField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expiryMonthField);
            this.Controls.Add(this.numField4);
            this.Controls.Add(this.numField3);
            this.Controls.Add(this.numField2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numField1);
            this.Controls.Add(this.label1);
            this.Name = "AddCardForm";
            this.Text = "Добавление банковской карты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numField1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numField2;
        private System.Windows.Forms.TextBox numField3;
        private System.Windows.Forms.TextBox numField4;
        private System.Windows.Forms.TextBox expiryMonthField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ownerField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cvvField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox expiryYearField;
        private System.Windows.Forms.Label label6;
    }
}