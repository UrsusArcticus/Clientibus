namespace Clientibus
{
    public partial class MainWindow : Form {

        private DataClasses.DatabaseContext dbContext = new DataClasses.DatabaseContext();
        public MainWindow() {
            InitializeComponent();

        }

        private void newCustomerBtn_Click(object sender, EventArgs e) {
            CustomerControl customerControl = new CustomerControl();
            customerControl.Dock = DockStyle.Fill;
            customerControl.DatabaseContext = dbContext;
            TabPage customerPage = new TabPage("New Customer");
            customerPage.Controls.Add(customerControl);
            mainTabControl.TabPages.Add(customerPage);

        }
    }
}
