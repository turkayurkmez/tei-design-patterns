namespace SRP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
           
            var name = textBoxName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            var operation = new ProductService().AddNewProduct(name,price);
            var result =operation == 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(result);

        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color; 
            }
        }
    }
}
