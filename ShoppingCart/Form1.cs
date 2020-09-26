using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class frmShoppingCart : Form
    {
        public frmShoppingCart()
        {
            InitializeComponent();

            //SoundPlayer player = new SoundPlayer(@"    \sony boogie.wav"); - add address here
            //player.Play();
        }

        int itemsOrdered;
        const int numberOfProducts = 11;
        Product[] products = new Product[numberOfProducts];

        private void frmShoppingCart_Load(object sender, EventArgs e)
        {
            LoadProducts();
            PopulateProductsComboBox();
        }

        private void PopulateProductsComboBox()
        {
            cbProducts.Items.AddRange(products.Select(p => p.Desciption).ToArray());
            cbProducts.SelectedIndex = 0;
        }

        private void LoadProducts()
        {
            products[0] = new Product("Sega Genesis", 79, "sega.jpg");
            products[1] = new Product("Segway Ninebot", 350, "segway.jpg");
            products[2] = new Product("Razer keyboard", 85, "razer.jpg");
            products[3] = new Product("Samsung S9", 499, "samsung.jpg");
            products[4] = new Product("Sony Playstation 5", 450, "playstation.png");
            products[5] = new Product("Xbox One Controller", 49, "xbox.jpg");
            products[6] = new Product("GeForce GTX 1660", 250, "gtx.jpg");
            products[7] = new Product("Panasonic blu-ray player", 100, "blu-ray.png");
            products[8] = new Product("JBL Speaker", 119, "jbl.jpg");
            products[9] = new Product("iPod Nano", 70, "ipod.jpeg");
            products[10] = new Product("HDMI cable", 5, "hdmi.jpg");
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            itemsOrdered = 0;
            lblItemsOrdered.Text = "Items ordered: 0";

            for (int i = 0; i < numberOfProducts; i++)
            {
                products[i].NumberOrdered = 0;
            }

            cbProducts.SelectedIndex = 0;
            lstProducts.Items.Clear();
            lblTotalCost.Text = "Total Cost";
            txtMailingLabel.Text = "";
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            products[cbProducts.SelectedIndex].NumberOrdered++;
            itemsOrdered++;
            lblItemsOrdered.Text = "Items Ordered: " + itemsOrdered.ToString();
        }

        private void tabShoppingCart_selectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabOrderForm.SelectedIndex)
            {
                case 1:
                    if (itemsOrdered == 0)
                    {
                        MessageBox.Show("There are no items in your shopping cart", "Invalid Order", MessageBoxButtons.OK);
                        tabOrderForm.SelectedIndex = 0;
                    }
                    else
                    {
                        double totalCost = 0;
                        lstProducts.Items.Clear();

                        for (int i = 0; i < numberOfProducts; i++)
                        {
                            if (products[i].NumberOrdered != 0)
                            {
                                lstProducts.Items.Add(products[i].NumberOrdered.ToString() + " " + products[i].Desciption);
                                totalCost += products[i].Cost * products[i].NumberOrdered;
                            }
                        }
                        lblTotalCost.Text = "Total Cost: " + String.Format("{0:f2}", totalCost);
                    }
                    break;

                case 2:

                    if (txtFullName.Text == "" || txtPostcode.Text == "" || txtAddress.Text == "" || txtCC.Text == "")
                    {
                        MessageBox.Show("Address registration not completed", "Invalid Address", MessageBoxButtons.OK);
                        tabOrderForm.SelectedIndex = 1;
                        txtFullName.Focus();
                    }
                    else
                    {
                        string fullName = txtFullName.Text;
                        string postcode = "\r\n" + txtPostcode.Text;
                        string address = "\r\n" + txtAddress.Text;
                        string cityCountry = "\r\n" + txtCC.Text;

                        txtMailingLabel.Text = fullName + postcode + address + cityCountry;
                    }
                    break;
            }
        }
    
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void brnExitSecondButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewOrderSecondButton_Click(object sender, EventArgs e)
        {
            btnNewOrder_Click(sender, e);
            tabOrderForm.SelectedIndex = 0;
        }

        private void cbProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedProductIndex = ((ComboBox)sender).SelectedIndex;
            var selectedProduct = products[selectedProductIndex];
            if (string.IsNullOrEmpty(selectedProduct.ImageName))
            {
                pbProduct.Image = null;
            }
            else
            {
                var pictureFolder = @"C:\Users\Justinas\Desktop\UPDATED VERSIONS\Cart\ShoppingCart\ShoppingCart\ProductsPhotos\";
                
                pbProduct.Image = new Bitmap($"{pictureFolder}{selectedProduct.ImageName}");
            }
        }
    }
}
