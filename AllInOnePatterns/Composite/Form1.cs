using System.Xml;

namespace Composite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            CompositeComponent<Category> root = new CompositeComponent<Category>
            {
                Node = new Category { Name = "Kategoriler" }
            };

            var elektronik = root.Add(new Category { Name = "Elektronik" });
            var giyim = root.Add(new Category { Name = "Giyim" });
            var bilgisayar = elektronik.Add(new Category { Name = "Bilgisayar" });
            var cepTelefonu = elektronik.Add(new Category { Name = "Cep Telefonu" });
            var laptop = bilgisayar.Add(new Category { Name = "Laptop" });
            var dell = laptop.Add(new Category { Name = "Dell" });
            var android = cepTelefonu.Add(new Category { Name = "Android" });
            var samsung = android.Add(new Category { Name = "Samsung" });

            CompositeComponent<Category>.Show(root, treeViewCategories);

            XmlDocument xmlDocument = new XmlDocument();
            

        }
    }
}
