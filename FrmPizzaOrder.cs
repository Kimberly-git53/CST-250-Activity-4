using static PizzaOrder;
using System.Drawing;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Activity4
{
    public partial class FrmPizzaOrder : Form
    {
        List<PizzaOrder> pizzaList = new List<PizzaOrder>();
        public FrmPizzaOrder()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            // Set the initial values for the scroll bars
            lblSauceAmount.Text = hScrollSauce.Value.ToString();
            lblGarlicAmount.Text = hScrollGarlic.Value.ToString();
            lblParmesanCheeseAmount.Text = hScrollParmesanCheese.Value.ToString();

            // Attach the scroll event handlers to the scroll bars
            hScrollSauce.Scroll += hScrollSauce_Scroll;
            hScrollGarlic.Scroll += hScrollGarlic_Scroll;
            hScrollParmesanCheese.Scroll += hScrollParmesanCheese_Scroll;

        }
        // This method changes the label text to the value of the scroll bar when it is scrolled
        private void hScrollSauce_Scroll(object sender, ScrollEventArgs e)
        {
            // Set the maximum and minimum values for the scroll bars  
            hScrollSauce.Minimum = 0;
            hScrollSauce.Maximum = 100;
            hScrollSauce.LargeChange = 1;
            hScrollSauce.SmallChange = 1;
            // Set the initial values for the scroll bars
            lblSauceAmount.Text = hScrollSauce.Value.ToString();
        }
        // This method changes the label text to the value of the scroll bar when it is scrolled
        private void hScrollGarlic_Scroll(object sender, ScrollEventArgs e)
        {
            // Set the maximum and minimum values for the scroll bars
            hScrollGarlic.Minimum = 0;
            hScrollGarlic.Maximum = 100;
            hScrollGarlic.LargeChange = 1;
            hScrollGarlic.SmallChange = 1;
            // Set the initial values for the scroll bars
            lblGarlicAmount.Text = hScrollGarlic.Value.ToString();
        }
        // This method changes the label text to the value of the scroll bar when it is scrolled
        private void hScrollParmesanCheese_Scroll(object sender, ScrollEventArgs e)
        {
            // Set the maximum and minimum values for the scroll bars
            hScrollParmesanCheese.Minimum = 0;
            hScrollParmesanCheese.Maximum = 100;
            hScrollParmesanCheese.LargeChange = 1;
            hScrollParmesanCheese.SmallChange = 1;
            // Set the initial values for the scroll bars
            lblParmesanCheeseAmount.Text = hScrollParmesanCheese.Value.ToString();
        }
        // This initializes the color dialog for the sauce color
        private string selectedSauceColor = string.Empty;

        // This method is to select the sauce color
        private void btnSauceColor_Click(object sender, EventArgs e)
        {
          
            // Show the color dialog and check if the user selected a color
            if (colorDialSauce.ShowDialog() == DialogResult.OK)
            {
                // Set the background color of the button to the selected color
                picbSauceColor.BackColor = colorDialSauce.Color;
                // Store the selected color in the pizza order
                selectedSauceColor = ColorTranslator.ToHtml(colorDialSauce.Color);
                             
            }
            
        }


        // This method is to create a pizza order
        private void btnCreatePizza_Click(object sender, EventArgs e)
        {
            PizzaOrder order = new PizzaOrder();

            //Name
            order.Name = txtBoxNameOfOrder.Text;

            //Date
            order.Delivery = dateTimePickerDelivery.Value;

            //Cheese level entered
            order.CheeseLevel = trkCheeseMeter.Value;
            int cheeseLevel = order.CheeseLevel;
            string cheeseLevelText = cheeseLevel switch
            {
                0 => "No cheese",
                1 => "Regular cheese",
                2 => "Extra cheese",
                _ => "Invalid cheese level"

            };

            //Number of pizzas
            order.NumberOfPizzas = (int)numNumberOfPizzas.Value;

            //Crust type
            if (rbtnThinCrust.Checked)
            {
                order.Crust = PizzaOrder.CrustType.Thin;
            }
            else if (rbtnHandTossed.Checked)
            {
                order.Crust = PizzaOrder.CrustType.HandTossed;
            }
            else if (rbtnDeepDish.Checked)
            {
                order.Crust = PizzaOrder.CrustType.DeepDish;
            }
            else if (rbtnCheeseStuffed.Checked)
            {
                order.Crust = PizzaOrder.CrustType.CheeseStuffed;
            }

            // Toppings (checkboxes)
            order.Toppings = new List<string>();

            if (chkCheese.Checked) order.Toppings.Add("Cheese");
            if (chkBacon.Checked) order.Toppings.Add("Bacon");
            if (chkPepperoni.Checked) order.Toppings.Add("Pepperoni");
            if (chkMushrooms.Checked) order.Toppings.Add("Mushrooms");
            if (chkSausage.Checked) order.Toppings.Add("Sausage");
            if (chkHam.Checked) order.Toppings.Add("Ham");
            if (chkTomatoes.Checked) order.Toppings.Add("Tomatoes");
            if (chkPineapple.Checked) order.Toppings.Add("Pineapple");

            //Other Toppings (list)
            order.OtherToppings = new List<string>();
            foreach (var item in listBoxOtherToppings.SelectedItems)
            {
                order.OtherToppings.Add(item.ToString());
            }

            //Sauce quantity
            order.Sauceqty = hScrollSauce.Value;
            //Garlic quantity
            order.Garlicqty = hScrollGarlic.Value;
            //Parmesan cheese quantity
            order.Parmesanqty = hScrollParmesanCheese.Value;

            // Sauce color
            order.SauceColorHex = selectedSauceColor;

            // Display the order summary
            string orderSummary = $"Name of order: {order.Name}\n" +
                $"Delivery Date: {order.Delivery.ToShortDateString()}\n" +
                $"Number of Pizzas: {order.NumberOfPizzas}\n" +
                $"Crust Type: {order.Crust}\n" +
                $"Cheese Level: {cheeseLevelText}\n" +
                $"Sauce Quantity: {order.Sauceqty}\n" +
                $"Garlic Quantity: {order.Garlicqty}\n" +
                $"Parmesan Cheese Quantity: {order.Parmesanqty}\n" +
                $"Sauce Color: {selectedSauceColor}\n" +
                $"Toppings: {string.Join(", ", order.Toppings)}\n" +
                $"Other Toppings: {string.Join(", ", order.OtherToppings)}";

            MessageBox.Show(orderSummary, "Pizza Order Summary", 
                MessageBoxButtons.OK);

            // Add the order to the list
            pizzaList.Add(order);

            // Show form 2 and pass the list of pizzas
            FrmPizzaList listForm = new FrmPizzaList(pizzaList);
            listForm.ShowDialog();

        }
        // This method is to reset the form
        public void btnResetForm_Click(object sender, EventArgs e)
        {
            // Reset all controls to their default values
            txtBoxNameOfOrder.Clear();
            dateTimePickerDelivery.Value = DateTime.Now;
            trkCheeseMeter.Value = 0;
            numNumberOfPizzas.Value = 0;
            // Reset selected toppings
            chkCheese.Checked = false;
            chkBacon.Checked = false;
            chkPepperoni.Checked = false;
            chkMushrooms.Checked = false;
            chkSausage.Checked = false;
            chkHam.Checked = false;
            chkTomatoes.Checked = false;
            chkPineapple.Checked = false;
            // Clear the selected items in the list box
            listBoxOtherToppings.ClearSelected();
            // Reset the scroll bars
            hScrollSauce.Value = 0;
            lblSauceAmount.Text = hScrollSauce.Value.ToString();
            hScrollGarlic.Value = 0;
            lblGarlicAmount.Text = hScrollGarlic.Value.ToString();
            hScrollParmesanCheese.Value = 0;
            lblParmesanCheeseAmount.Text = hScrollParmesanCheese.Value.ToString();
            // Reset the sauce color
            picbSauceColor.BackColor = Color.LightSalmon;
            // Reset selected crust
            rbtnCheeseStuffed.Checked = false;
            rbtnDeepDish.Checked = false;
            rbtnHandTossed.Checked = false;
            rbtnThinCrust.Checked = false;

        }
    }
}
