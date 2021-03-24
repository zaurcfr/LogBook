using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>()
        {
            new Student
            {
                Name="Elgun",
                Surname="Abasquliyev",
                LastLogin=new DateTime(2020,03,20),
                Photo=Properties.Resources.elgun
            },
            new Student
            {
                Name="Amin",
                Surname="Aliyev",
                LastLogin=new DateTime(2020,03,20),
                Photo=Properties.Resources.amin
            },
            new Student
            {
                Name="Ayxan",
                Surname="Axundov",
                LastLogin=new DateTime(2020,03,20),
                Photo=Properties.Resources.ayxan
            },
            new Student
            {
                Name="Arifali",
                Surname="Bagirli",
                LastLogin=new DateTime(2020,03,20),
                Photo=Properties.Resources.arif
            },
            new Student
            {
                Name="Zaur",
                Surname="Jafarov",
                LastLogin=new DateTime(2020,03,20),
                Photo=Properties.Resources.zaur
            }
        };
        public Form1()
        {
            InitializeComponent();
            UserControl1 userControl1 = new UserControl1();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateItems();


        }

        private void CreateItems()
        {
            UserControl1[] userControl1s = new UserControl1[students.Count];
            for (int i = 0; i < students.Count; i++)
            {
                userControl1s[i] = new UserControl1();
                userControl1s[i].StudentName = students[i].Name;
                userControl1s[i].StudentSurname = students[i].Surname;
                userControl1s[i].LastLogin = students[i].LastLogin;
                userControl1s[i].Image = students[i].Photo;
                flowLayoutPanel1.Controls.Add(userControl1s[i]);
            }
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2RadioButton1.Checked == true) subjectTxtb.Enabled = true;
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2RadioButton2.Checked == true)
            {
                subjectTxtb.Enabled = false;
                guna2Button1.Enabled = false;
                editBtn.Enabled = false;
                newTeacherLbl.Visible = true;
                newTeacherTxtb.Visible = true;
                okBtn.Visible = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (subjectTxtb.Text != "")
            {
                MessageBox.Show("Now you can start your lesson. Good Luck!");
                panel.Enabled = true;
                guna2Button1.Enabled = false;
                subjectTxtb.Enabled = false;
            }
            else MessageBox.Show("You must write lesson name first!");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            subjectTxtb.Enabled = true;
            guna2Button1.Enabled = true;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            newTeacherLbl.Visible = false;
            newTeacherTxtb.Visible = false;
            okBtn.Visible = false;
            subjectTxtb.Enabled = true;
            guna2Button1.Enabled = true;
            editBtn.Enabled = true;
        }
    }
}
