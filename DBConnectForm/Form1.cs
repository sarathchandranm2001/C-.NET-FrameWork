namespace DBConnectForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.ShowDialog();
        }
    }
}
