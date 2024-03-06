namespace UserControlTask
{
    partial class EditForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEditId = new TextBox();
            txtEditSurname = new TextBox();
            txtEditName = new TextBox();
            txtEditMiddleName = new TextBox();
            txtEditAge = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 174);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 220);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 4;
            label5.Text = "Лет";
            // 
            // txtEditId
            // 
            txtEditId.Location = new Point(12, 37);
            txtEditId.Name = "txtEditId";
            txtEditId.Size = new Size(100, 23);
            txtEditId.TabIndex = 5;
            // 
            // txtEditSurname
            // 
            txtEditSurname.Location = new Point(12, 88);
            txtEditSurname.Name = "txtEditSurname";
            txtEditSurname.Size = new Size(100, 23);
            txtEditSurname.TabIndex = 6;
            // 
            // txtEditName
            // 
            txtEditName.Location = new Point(12, 143);
            txtEditName.Name = "txtEditName";
            txtEditName.Size = new Size(100, 23);
            txtEditName.TabIndex = 7;
            // 
            // txtEditMiddleName
            // 
            txtEditMiddleName.Location = new Point(12, 194);
            txtEditMiddleName.Name = "txtEditMiddleName";
            txtEditMiddleName.Size = new Size(100, 23);
            txtEditMiddleName.TabIndex = 8;
            // 
            // txtEditAge
            // 
            txtEditAge.Location = new Point(12, 238);
            txtEditAge.Name = "txtEditAge";
            txtEditAge.Size = new Size(100, 23);
            txtEditAge.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.Location = new Point(167, 266);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 45);
            btnSave.TabIndex = 10;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 333);
            Controls.Add(btnSave);
            Controls.Add(txtEditAge);
            Controls.Add(txtEditMiddleName);
            Controls.Add(txtEditName);
            Controls.Add(txtEditSurname);
            Controls.Add(txtEditId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSave;
        public TextBox txtEditId;
        public TextBox txtEditSurname;
        public TextBox txtEditName;
        public TextBox txtEditMiddleName;
        public TextBox txtEditAge;
    }
}