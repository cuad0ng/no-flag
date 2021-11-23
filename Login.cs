
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Login : MaterialForm
    {


        public Login()
        {
            InitializeComponent();

        }

        private void passShow_CheckedChanged(object sender, EventArgs e)
        {
            if (passShow.Checked)
            {
                passBox.Password = false;
                passBox.Focus();
            }
            else
            {
                passBox.Password = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            new Exit().Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            try
            {
                string datasource = sourceBox.Text;
                string username = userBox.Text;
                string password = passBox.Text;
                string role = "DG";
                if (radioNV.Checked)
                {
                    role = "NV";
                }
                else if (radioAD.Checked)
                {
                    role = "AD";
                }
                MyDB db = new MyDB(datasource, username, password);


                db.openConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AuthoLogin";
                cmd.Parameters.AddWithValue("@UserName", userBox.Text);
                cmd.Parameters.AddWithValue("@Password", passBox.Text);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Connection = db.getConnection;

                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 1)
                {
                    new Form1(db, username).Show();
                    MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (code == 2)
                {
                    
                    MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (code == 3)
                {
                    MessageBox.Show("Chào mừng Nhân viện đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (code == 4)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                db.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            new Register().ShowDialog();

        }
    }
}
