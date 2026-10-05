namespace Clientibus
{
    public partial class MainWindow : Form
    {
        private DataClasses.DatabaseContext dbContext = new DataClasses.DatabaseContext();
        public MainWindow()
        {
            InitializeComponent();
            
        }
    }
}
