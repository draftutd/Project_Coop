using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF1.Securities.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            WPF1.Utilities.Log.recordLog(" # Start open program #");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           // WPF1.Utilities.Log.closeLog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            WPF1.Utilities.Log.recordLog(" # Start Login program #");
            if(txtUsername.Text.Trim() == "WPF" && txtPassword.Text.Trim() == "1234")
            {
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(Threadcall));
                thread.Start();
                this.Close();
            }
            else
                MessageBox.Show("ชื่อ หรือ รหัสผู้ใช้งานไม่ถูกต้อง กรุณาลองใหม่อีกครั้ง", "เข้าใช้ระบบผิดพลาด", MessageBoxButtons.OK);
        }

        public static void Threadcall()
        {
            Application.Run(new Main());
        }

        private void Login_Closing(object sender, FormClosingEventArgs e)
        {
            WPF1.Utilities.Log.closeLog();
        }
    }
}
