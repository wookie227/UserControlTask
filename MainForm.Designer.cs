namespace UserControlTask
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            ListPersons = new FlowLayoutPanel();
            lblCount = new Label();
            lblSumAge = new Label();
            txtSumAge = new TextBox();
            txtCount = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 54);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ListPersons
            // 
            ListPersons.AutoScroll = true;
            ListPersons.BackColor = Color.LightGray;
            ListPersons.Location = new Point(25, 89);
            ListPersons.Name = "ListPersons";
            ListPersons.Size = new Size(523, 300);
            ListPersons.TabIndex = 1;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(253, 12);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(88, 15);
            lblCount.TabIndex = 2;
            lblCount.Text = "Всего записей:";
            // 
            // lblSumAge
            // 
            lblSumAge.AutoSize = true;
            lblSumAge.Location = new Point(253, 51);
            lblSumAge.Name = "lblSumAge";
            lblSumAge.Size = new Size(69, 15);
            lblSumAge.TabIndex = 3;
            lblSumAge.Text = "Сумма лет:";
            // 
            // txtSumAge
            // 
            txtSumAge.Location = new Point(347, 51);
            txtSumAge.Name = "txtSumAge";
            txtSumAge.Size = new Size(100, 23);
            txtSumAge.TabIndex = 5;
            txtSumAge.Text = "0";
            // 
            // txtCount
            // 
            txtCount.Location = new Point(347, 9);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(100, 23);
            txtCount.TabIndex = 6;
            txtCount.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 411);
            Controls.Add(txtCount);
            Controls.Add(txtSumAge);
            Controls.Add(lblSumAge);
            Controls.Add(lblCount);
            Controls.Add(ListPersons);
            Controls.Add(btnAdd);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private FlowLayoutPanel ListPersons;
        private Label lblCount;
        private Label lblSumAge;
        private TextBox txtSumAge;
        private TextBox txtCount;
    }
}
