namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntexto_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            mensaje = txt1.Text;

            MessageBox.Show("Su mensaje es: "+ mensaje);
        }
    }
}