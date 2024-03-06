namespace UserControlTask
{
    partial class PersonRecordUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblSurname = new Label();
            lblName = new Label();
            lblMiddleName = new Label();
            lblAge = new Label();
            txtId = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 11);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(46, 11);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(58, 15);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "Фамилия";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(146, 11);
            lblName.Name = "lblName";
            lblName.Size = new Size(31, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Имя";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(245, 11);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(58, 15);
            lblMiddleName.TabIndex = 3;
            lblMiddleName.Text = "Отчество";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(348, 11);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(26, 15);
            lblAge.TabIndex = 4;
            lblAge.Text = "Лет";
            // 
            // txtId
            // 
            txtId.Location = new Point(4, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(26, 23);
            txtId.TabIndex = 5;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(46, 29);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(76, 23);
            txtSurname.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(76, 23);
            txtName.TabIndex = 7;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(245, 29);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(76, 23);
            txtMiddleName.TabIndex = 8;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(348, 29);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(50, 23);
            txtAge.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(413, 11);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Изменить";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(413, 40);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // PersonRecordUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleName);
            Controls.Add(txtName);
            Controls.Add(txtSurname);
            Controls.Add(txtId);
            Controls.Add(lblAge);
            Controls.Add(lblMiddleName);
            Controls.Add(lblName);
            Controls.Add(lblSurname);
            Controls.Add(lblId);
            Name = "PersonRecordUserControl";
            Size = new Size(500, 75);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblSurname;
        private Label lblName;
        private Label lblMiddleName;
        private Label lblAge;
        private TextBox txtId;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtMiddleName;
        private TextBox txtAge;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
