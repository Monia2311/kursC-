namespace HardcodeFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HardcodeButton = new Button();
            HardcodeButton.Parent = this;
            HardcodeButton.Top = 150;
            HardcodeButton.Left = 150;
            HardcodeButton.Text = "Hardcoded Button...";
            HardcodeButton.Width = 10;
            HardcodeButton.Click += new System.EventHandler(SayHello);
            HardcodeButton.Click += new System.EventHandler(ExtendButton);
        }

        private void SayHello(Object sender, EventArgs args)
        {
            MessageBox.Show("Hello");
        }

        private void ExtendButton(Object sender, EventArgs args)
        {
            HardcodeButton.Width += 20;
        }
    }
}