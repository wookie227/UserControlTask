using System.Windows.Forms;

namespace UserControlTask
{
    public partial class MainForm : Form
    {
        private int counter = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonRecordUserControl personRecord = new PersonRecordUserControl();
            personRecord.PersonID = "123";
            personRecord.FirstName = "Иван";
            personRecord.LastName = "Иванов";
            personRecord.MiddleName = "Иванович";
            personRecord.Age = "18";

            counter += 1;
            txtCount.Text = counter.ToString();
            personRecord.EditClicked += PersonRecord_EditClicked;
            personRecord.DeleteClicked += PersonRecord_DeleteClicked;
            ListPersons.Controls.Add(personRecord);
            CalculateTotalAge();
        }
        private void PersonRecord_EditClicked(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();

            var personRecord = sender as PersonRecordUserControl;
            editForm.txtEditId.Text = personRecord.PersonID;
            editForm.txtEditName.Text = personRecord.FirstName;
            editForm.txtEditSurname.Text = personRecord.LastName;
            editForm.txtEditMiddleName.Text = personRecord.MiddleName;
            editForm.txtEditAge.Text = personRecord.Age;

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personRecord.PersonID = editForm.EditedPersonID;
                personRecord.FirstName = editForm.EditedName;
                personRecord.LastName = editForm.EditedSurname;
                personRecord.MiddleName = editForm.EditedMiddleName;
                personRecord.Age = editForm.EditedAge;
                CalculateTotalAge();
            }
        }

        private void PersonRecord_DeleteClicked(object sender, EventArgs e)
        {
            counter -= 1;
            txtCount.Text = counter.ToString();
            ListPersons.Controls.Remove(sender as PersonRecordUserControl);
            CalculateTotalAge();
        }

        private void CalculateTotalAge()
        {
            int totalAge = 0;

            foreach (Control control in ListPersons.Controls)
            {
                if (control is PersonRecordUserControl personRecord)
                {
                    if (int.TryParse(personRecord.Age, out int age))
                    {
                        totalAge += age;
                    }
                }
            }
            txtSumAge.Text = totalAge.ToString();
        }
    }
}
