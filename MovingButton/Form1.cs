namespace MovingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            var x = rnd.NextInt64(1, 50);
            var y = rnd.NextInt64(1, 50);
            this.RandomButton.Location = new Point(312 +(int)x, 197 +(int)y);
        }
    }
}