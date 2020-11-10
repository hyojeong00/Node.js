using MetroFramework.Forms;

namespace BookRentalShop2020
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }
    }
}
