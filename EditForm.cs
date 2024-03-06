using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTask
{
    public partial class EditForm : Form
    {
        public string EditedPersonID { get; set; }
        public string EditedName { get; set; }
        public string EditedSurname { get; set; }
        public string EditedMiddleName { get; set; }
        public string EditedAge { get; set; }

        public EditForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EditedPersonID = txtEditId.Text;
            EditedName = txtEditName.Text;
            EditedSurname = txtEditSurname.Text;
            EditedMiddleName = txtEditMiddleName.Text;
            EditedAge = txtEditAge.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
