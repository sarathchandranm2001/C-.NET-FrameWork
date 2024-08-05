namespace Student_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login log=new login();
            log.Show(); 
        }
    }
}
