using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Data_Grid_View_and_Data_Binding_Navigator
{
    public partial class FormBindingViewNavigation : Form
    {
        public FormBindingViewNavigation()
        {
            InitializeComponent();
        }

        private void FormBindingViewNavigation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormBeranda().Show();
            this.Hide();
        }
    }
}
