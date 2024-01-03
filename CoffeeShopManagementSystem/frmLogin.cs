using System.Runtime.InteropServices;

namespace CoffeeShopManagementSystem
{
    public partial class frmLogin : Form
    {
        // To Round the Buttons
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );
        public frmLogin()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 30, 30));
            btnClear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 30, 30));
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Login Button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "root";
            string password = "toor";
            if (username == txtUsername.Text && password == txtPassword.Text)
            {
                MessageBox.Show("Login Successfull!");
                frmDashboard frmDashboard = new frmDashboard();
                this.Hide();
                frmDashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login Credentials!");
            }
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
