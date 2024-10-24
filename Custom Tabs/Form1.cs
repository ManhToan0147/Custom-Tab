namespace Custom_Tabs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Inbox uc = new UC_Inbox();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Sent uc = new UC_Sent();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_Settingcs uc = new UC_Settingcs();
            addUserControl(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }
    }
}
