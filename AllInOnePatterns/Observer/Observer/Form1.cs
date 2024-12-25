namespace Observer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ObservableColorSubscription observable = new ObservableColorSubscription();
        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(observable);
            form2.Show();
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                //this.BackColor = colorDialog.Color;
                observable.Color = colorDialog.Color;
            }
        }
    }
}
