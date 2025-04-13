using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4
{
    public partial class FrmPizzaList : Form
    {
        BindingSource bindingSourcePizzaList = new BindingSource();
        List<PizzaOrder> pizzaList = new List<PizzaOrder>();
        public FrmPizzaList(List<PizzaOrder> pizzaOrders)
        {
            InitializeComponent();
            pizzaList = pizzaOrders;
            // Set the data source for the first list box
            bindingSourcePizzaList.DataSource = pizzaList;
            // Set the display member for the first list box
            lstPizzaList.DataSource = bindingSourcePizzaList;
            lstPizzaList.DisplayMember = "Name";
            // Display order on the second list box
            lstPizzaList.SelectedIndexChanged += LstPizzaList_SelectedIndexChanged;


        }
        // This method is to display the details of the selected item in the second list box
        private void LstPizzaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedName = lstPizzaList.SelectedItem as PizzaOrder;

            if (selectedName != null)
            {
                List<string> details = new List<string>()
                {
                    $"Name: {selectedName.Name}",
                    $"Delivery Date: {selectedName.Delivery.ToShortDateString()}",
                    $"Number of Pizzas: {selectedName.NumberOfPizzas}",
                    $"Crust Type: {selectedName.Crust}",
                    $"Sauce Amount: {selectedName.Sauceqty}",
                    $"Garlic Amount: {selectedName.Garlicqty}",
                    $"Parmesan Amount: {selectedName.Parmesanqty}",
                    $"Sauce Color: {selectedName.SauceColorHex}",
                    $"Cheese Level: {GetCheeseLevelDescription(selectedName.CheeseLevel)}",
                    $"Toppings: {string.Join(", ", selectedName.Toppings)}",
                    $"Other Toppings: {string.Join(", ", selectedName.OtherToppings)}"
                };

                lstPizzaOrderDetails.DataSource = details;
            }
        }

        // This method replaces the number value with a string value
        private object GetCheeseLevelDescription(int cheeseLevel)
        {
            return cheeseLevel switch
            {
                0 => "No cheese",
                1 => "Regular cheese",
                2 => "Extra cheese",
                _ => "Invalid cheese level"
            };
        }
        // This method is to sort the list in ascending order
        private void btnSortAToZ_Click(object sender, EventArgs e)
        {
            // Sort the list in ascending order
            pizzaList = pizzaList.OrderBy(p => p.Name).ToList();
            // Update the binding source
            bindingSourcePizzaList.DataSource = pizzaList;
            // Rebind the list box
            lstPizzaList.DataSource = bindingSourcePizzaList;
            lstPizzaList.DisplayMember = "Name";
            // Reset the selected index to the first item
            if (lstPizzaList.Items.Count > 0)
            {
                lstPizzaList.SelectedIndex = 0;
            }
            else
            {
                lstPizzaOrderDetails.DataSource = null;
            }

        }
        // This method is to sort the list in descending order
        private void btnSortZToA_Click(object sender, EventArgs e)
        {
            // Sort the list in descending order
            pizzaList = pizzaList.OrderByDescending(p => p.Name).ToList();
            // Update the binding source
            bindingSourcePizzaList.DataSource = pizzaList;
            // Rebind the list box
            lstPizzaList.DataSource = bindingSourcePizzaList;
            lstPizzaList.DisplayMember = "Name";
            // Reset the selected index to the first item
            if (lstPizzaList.Items.Count > 0)
            {
                lstPizzaList.SelectedIndex = 0;
            }
            else
            {
                lstPizzaOrderDetails.DataSource = null;
            }
        }
        // This method is to delete an item from the list
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
        // Check if an item is selected
            if (lstPizzaList.SelectedItem != null)
            {
                // Remove the selected item from the list
                bindingSourcePizzaList.Remove(lstPizzaList.SelectedItem);

                // Clear the details list box
                if (lstPizzaList.Items.Count > 0)
                {
                    lstPizzaList.SelectedIndex = 0;
                }
                else
                {
                    lstPizzaOrderDetails.DataSource = null;
                }

            }
            else
            {
                MessageBox.Show("Please select a pizza order to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
