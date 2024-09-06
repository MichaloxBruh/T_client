namespace T_client
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Form2 creatuser = new Form2();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            creatuser.Show();
        }
    }
}
