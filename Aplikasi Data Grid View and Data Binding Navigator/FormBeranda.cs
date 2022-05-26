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
    public partial class FormBeranda : Form
    {
        public FormBeranda()
        {
            InitializeComponent();
        }

        private void FormBeranda_Load(object sender, EventArgs e)
        {

        }

        private void pictureDataGridView_Click(object sender, EventArgs e)
        {
            new FormDataGridView().Show();
            this.Hide();
        }

        private void pictureDataBinding_Click(object sender, EventArgs e)
        {
            new FormBindingViewNavigation().Show();
            this.Hide();
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }
    }
}
