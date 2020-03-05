using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister
{
    public partial class RegisterGUI : Form
    {
        double tax;
        public RegisterGUI()
        {
            tax = 0.06;
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                //Get name, quantity, and price
                String name = this.nameTextBox.Text;
                int quantity = Int16.Parse(this.quantityTextBox.Text);
                if (this.priceTextBox.Text.Contains("$"))
                {
                    this.priceTextBox.Text = this.priceTextBox.Text.Replace('$',' ');
                }
                double price = double.Parse(this.priceTextBox.Text);

                //Add Item to list of Items
                Item item = new Item(name, quantity, price);
                this.listOfItems.Items.Add(item.toString());

                //Add the SubTotal
                this.subTotalLabel.Text = this.subTotalLabel.Text.Replace('$', ' ');
                this.subTotalLabel.Text = String.Format("${0}", (double.Parse(this.subTotalLabel.Text) + (quantity * price)).ToString("F2"));

                //Add the total tax
                this.taxLabel.Text = this.taxLabel.Text.Replace('$', ' ');
                this.taxLabel.Text = String.Format("${0}", (double.Parse(this.taxLabel.Text) + (quantity * tax)).ToString("F2"));

                //Add to the Total
                this.totalText.Text = this.totalText.Text.Replace('$', ' ');
                double totalOfItem = (price * quantity) * (1 + this.tax);
                this.totalText.Text = String.Format("${0}",(double.Parse(this.totalText.Text) + totalOfItem).ToString("F2"));

                //Reset Text input boxes
                this.nameTextBox.Text = this.quantityTextBox.Text = this.priceTextBox.Text = "";
            }
            catch (FormatException)
            {
                Console.WriteLine("Something doesn't look right here");
            }
        }

        private void clear_Clicked(object sender, EventArgs e)
        {
            this.nameTextBox.Text = this.quantityTextBox.Text = this.priceTextBox.Text = "";
            this.totalText.Text = this.subTotalLabel.Text = this.taxLabel.Text = "$0.00";
            this.listOfItems.Clear();
        }
    }
}
