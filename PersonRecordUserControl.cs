using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserControlTask
{
    public partial class PersonRecordUserControl : UserControl
    {
        public PersonRecordUserControl()
        {
            InitializeComponent();
            btnUpdate.Click += EditButton_Click;
            btnDelete.Click += DeleteButton_Click;
            RoundCorners(this, 30);
        }
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;
        private void RoundCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            control.Region = new Region(path);
        }
        public string PersonID
        {
            get => txtId.Text;
            set => txtId.Text = value;
        }

        public string FirstName
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }

        public string LastName
        {
            get => txtSurname.Text;
            set => txtSurname.Text = value;
        }

        public string MiddleName
        {
            get => txtMiddleName.Text;
            set => txtMiddleName.Text = value;
        }

        public string Age
        {
            get => txtAge.Text;
            set => txtAge.Text = value;
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
