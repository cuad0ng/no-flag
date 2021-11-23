using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Exit : MaterialForm
    {
        public Exit()
        {
            InitializeComponent();

        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
