using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyCrackTest1
{
    public partial class SecondForm : Form
    {
        public SecondForm(StartForm dialog)
        {
            InitializeComponent();
            int day = DateTime.Today.Day;
            label1.Text = "Сегодня у нас " + day + "день";
            string OsVersion = "" + Environment.OSVersion;
            label2.Text = "Версия ОС  "+ OsVersion;
            string machinename = "" + Environment.MachineName;
            label3.Text = "Имя машины  " + machinename;
            string procCount = "" + Environment.ProcessorCount;
            label4.Text = "Количество процессоров  " + procCount;
            string userName = "Имя пользователя  " + Environment.UserName;
            label5.Text = "" + userName;
            string version = "Версия  " + Environment.Version;
            label6.Text = "" + version;

        }

        private void SecondForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
