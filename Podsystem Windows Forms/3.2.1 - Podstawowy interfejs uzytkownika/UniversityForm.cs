using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace PodstawowyInterfejsUzytkownika
{
    public partial class UniversityChoiceWindow : Form
    {
        public UniversityChoiceWindow()
        {
            InitializeComponent();

            Prepare();
        }

        private void Prepare()
        {
            BindingList<TypeStudy> data = new BindingList<TypeStudy>();
            data.Add(new TypeStudy { ID = Study.BACHELOR, Description = "Licencjackie" });
            data.Add(new TypeStudy { ID = Study.MASTER, Description = "Magisterskie" });

            TypeStudyComboBox.DataSource = data;
            TypeStudyComboBox.ValueMember = "ID";
            TypeStudyComboBox.DisplayMember = "Description";
        }

        private void AcceptClick(object sender, EventArgs e)
        {
            UniversityData data = new UniversityData 
            { 
                NameUniversity = NameUniversity.Text,
                AddressUniversity = AddressUniversity.Text,
                TypeStudy = TypeStudyComboBox.SelectedItem,
                ComplementaryStudies = ComplementaryStudies.Checked,
                FullTimeStudies = FullTimeStudies.Checked
            };

            University universityDialog = new University(data);
            universityDialog.ShowDialog();
        }

        private void CancelClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
