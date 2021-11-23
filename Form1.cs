using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;
using System.Data.SqlClient;
namespace LibraryManagement
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        private MyDB db;
        private string username;
        public string Username { get; set; }
        public MyDB DB { get; set; }
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            viewdata();
        }
        public Form1(MyDB db, string username)
        {
            this.db = db;
            this.username = username;
        }
        private void viewdata()
        {
            db.openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM data";
            cmd.Connection = db.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            db.closeConnection();
            dataGridView1.DataSource = dt;
        }
    }
}
