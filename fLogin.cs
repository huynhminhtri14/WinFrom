namespace QuanLy
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbfLogin.Text == "" || txbPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txbfLogin.Text == "minhtri" && txbPass.Text == "123456")
            {
                fTableManager f = new fTableManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng. Vui lòng thử lại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

      
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
