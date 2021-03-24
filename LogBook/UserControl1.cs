using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook
{
    public partial class UserControl1 : UserControl
    {
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public DateTime LastLogin { get; set; }
        public Image Image { get; set; }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            UCNameLbl.Text = StudentName + " " + StudentSurname;
            UCLastLoginLbl.Text = LastLogin.ToShortDateString();
            UCProfilePhoto.Image = Image;
        }

        private void crystal1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{StudentName} gets 1 crystal!");
            crystal1.BackColor = Color.DeepSkyBlue;
        }

        private void crystal2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{StudentName} gets 2 crystals!");
            crystal1.BackColor = Color.DeepSkyBlue;
            crystal2.BackColor = Color.DeepSkyBlue;
        }

        private void crystal3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{StudentName} gets 3 crystals!");
            crystal1.BackColor = Color.DeepSkyBlue;
            crystal2.BackColor = Color.DeepSkyBlue;
            crystal3.BackColor = Color.DeepSkyBlue;
        }


        private void feedbackOkBtn_Click_1(object sender, EventArgs e)
        {
            if (feedbackTxtb.Text != "")
            {
                feedbackTxtb.Enabled = false;
                feedbackOkBtn.Enabled = false;
                MessageBox.Show("Feedback added succesfully!");
            }
            else MessageBox.Show("You must write something first!");
        }

        private void feedbackEditBtn_Click(object sender, EventArgs e)
        {
            feedbackTxtb.Enabled = true;
            feedbackOkBtn.Enabled = true;
        }
    }
}
