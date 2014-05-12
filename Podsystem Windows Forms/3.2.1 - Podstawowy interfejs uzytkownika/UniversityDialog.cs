using System;
using System.Windows.Forms;

namespace PodstawowyInterfejsUzytkownika
{
    public partial class University : Form
    {
        UniversityData Data;

        public University(UniversityData data)
        {
            InitializeComponent();

            Data = data;

            Prepare();
        }

        private void Prepare()
        {
            NameUniversity.Text = Data.NameUniversity;
            AddressUniversity.Text = Data.AddressUniversity;
            TypeStudy.Text = (Data.TypeStudy as TypeStudy).Description;
            FullTimeStudies.Text = Data.FullTimeStudies ? "dzienne" : string.Empty;
            ComplementaryStudies.Text = Data.ComplementaryStudies ? "uzupełniające" : string.Empty;
        }

        private void OKButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
