namespace Activity4
{
    partial class FrmPizzaOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNameForOrder = new Label();
            txtBoxNameOfOrder = new TextBox();
            grpToppings = new GroupBox();
            chkMushrooms = new CheckBox();
            chkHam = new CheckBox();
            chkPineapple = new CheckBox();
            chkPepperoni = new CheckBox();
            chkTomatoes = new CheckBox();
            chkSausage = new CheckBox();
            chkBacon = new CheckBox();
            chkCheese = new CheckBox();
            label2 = new Label();
            listBoxOtherToppings = new ListBox();
            grpCrust = new GroupBox();
            rbtnCheeseStuffed = new RadioButton();
            rbtnDeepDish = new RadioButton();
            rbtnHandTossed = new RadioButton();
            rbtnThinCrust = new RadioButton();
            grpCustomize = new GroupBox();
            lblParmesanCheeseAmount = new Label();
            lblGarlicAmount = new Label();
            lblSauceAmount = new Label();
            lblParmesanCheese = new Label();
            lblGarlic = new Label();
            lblSauce = new Label();
            hScrollParmesanCheese = new HScrollBar();
            hScrollGarlic = new HScrollBar();
            hScrollSauce = new HScrollBar();
            grpDeliveryTime = new GroupBox();
            dateTimePickerDelivery = new DateTimePicker();
            lblQuantityOfPizzas = new Label();
            numNumberOfPizzas = new NumericUpDown();
            lblCheeseMeter = new Label();
            trkCheeseMeter = new TrackBar();
            btnResetForm = new Button();
            btnCreatePizza = new Button();
            lblNoCheese = new Label();
            lblExtremeCheese = new Label();
            lblNormalChese = new Label();
            picbSauceColor = new PictureBox();
            colorDialSauce = new ColorDialog();
            btnSauceColor = new Button();
            grpToppings.SuspendLayout();
            grpCrust.SuspendLayout();
            grpCustomize.SuspendLayout();
            grpDeliveryTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNumberOfPizzas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkCheeseMeter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbSauceColor).BeginInit();
            SuspendLayout();
            // 
            // lblNameForOrder
            // 
            lblNameForOrder.AutoSize = true;
            lblNameForOrder.Location = new Point(16, 52);
            lblNameForOrder.Margin = new Padding(4, 0, 4, 0);
            lblNameForOrder.Name = "lblNameForOrder";
            lblNameForOrder.Size = new Size(151, 28);
            lblNameForOrder.TabIndex = 0;
            lblNameForOrder.Text = "Name for order:";
            // 
            // txtBoxNameOfOrder
            // 
            txtBoxNameOfOrder.Location = new Point(179, 48);
            txtBoxNameOfOrder.Margin = new Padding(4);
            txtBoxNameOfOrder.Name = "txtBoxNameOfOrder";
            txtBoxNameOfOrder.Size = new Size(337, 34);
            txtBoxNameOfOrder.TabIndex = 1;
            // 
            // grpToppings
            // 
            grpToppings.Controls.Add(chkMushrooms);
            grpToppings.Controls.Add(chkHam);
            grpToppings.Controls.Add(chkPineapple);
            grpToppings.Controls.Add(chkPepperoni);
            grpToppings.Controls.Add(chkTomatoes);
            grpToppings.Controls.Add(chkSausage);
            grpToppings.Controls.Add(chkBacon);
            grpToppings.Controls.Add(chkCheese);
            grpToppings.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grpToppings.Location = new Point(30, 132);
            grpToppings.Margin = new Padding(4);
            grpToppings.Name = "grpToppings";
            grpToppings.Padding = new Padding(4);
            grpToppings.Size = new Size(388, 249);
            grpToppings.TabIndex = 2;
            grpToppings.TabStop = false;
            grpToppings.Text = "Toppings";
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Location = new Point(195, 196);
            chkMushrooms.Margin = new Padding(4);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(134, 32);
            chkMushrooms.TabIndex = 7;
            chkMushrooms.Text = "Mushrooms";
            chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            chkHam.AutoSize = true;
            chkHam.Location = new Point(195, 148);
            chkHam.Margin = new Padding(4);
            chkHam.Name = "chkHam";
            chkHam.Size = new Size(76, 32);
            chkHam.TabIndex = 6;
            chkHam.Text = "Ham";
            chkHam.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            chkPineapple.AutoSize = true;
            chkPineapple.Location = new Point(195, 95);
            chkPineapple.Margin = new Padding(4);
            chkPineapple.Name = "chkPineapple";
            chkPineapple.Size = new Size(120, 32);
            chkPineapple.TabIndex = 5;
            chkPineapple.Text = "Pineapple";
            chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            chkPepperoni.AutoSize = true;
            chkPepperoni.Location = new Point(195, 46);
            chkPepperoni.Margin = new Padding(4);
            chkPepperoni.Name = "chkPepperoni";
            chkPepperoni.Size = new Size(122, 32);
            chkPepperoni.TabIndex = 4;
            chkPepperoni.Text = "Pepperoni";
            chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkTomatoes
            // 
            chkTomatoes.AutoSize = true;
            chkTomatoes.Location = new Point(8, 196);
            chkTomatoes.Margin = new Padding(4);
            chkTomatoes.Name = "chkTomatoes";
            chkTomatoes.Size = new Size(119, 32);
            chkTomatoes.TabIndex = 3;
            chkTomatoes.Text = "Tomatoes";
            chkTomatoes.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            chkSausage.AutoSize = true;
            chkSausage.Location = new Point(7, 148);
            chkSausage.Margin = new Padding(4);
            chkSausage.Name = "chkSausage";
            chkSausage.Size = new Size(106, 32);
            chkSausage.TabIndex = 2;
            chkSausage.Text = "Sausage";
            chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            chkBacon.AutoSize = true;
            chkBacon.Location = new Point(7, 95);
            chkBacon.Margin = new Padding(4);
            chkBacon.Name = "chkBacon";
            chkBacon.Size = new Size(87, 32);
            chkBacon.TabIndex = 1;
            chkBacon.Text = "Bacon";
            chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Location = new Point(7, 46);
            chkCheese.Margin = new Padding(4);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(96, 32);
            chkCheese.TabIndex = 0;
            chkCheese.Text = "Cheese";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 393);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 3;
            label2.Text = "Other Toppings";
            // 
            // listBoxOtherToppings
            // 
            listBoxOtherToppings.BackColor = Color.SaddleBrown;
            listBoxOtherToppings.ForeColor = SystemColors.Info;
            listBoxOtherToppings.FormattingEnabled = true;
            listBoxOtherToppings.ItemHeight = 28;
            listBoxOtherToppings.Items.AddRange(new object[] { "Black Olives", "Jalapeños", "Spinach", "Bell Peppers", "Onions", "" });
            listBoxOtherToppings.Location = new Point(16, 426);
            listBoxOtherToppings.Margin = new Padding(4);
            listBoxOtherToppings.Name = "listBoxOtherToppings";
            listBoxOtherToppings.Size = new Size(245, 200);
            listBoxOtherToppings.TabIndex = 4;
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rbtnCheeseStuffed);
            grpCrust.Controls.Add(rbtnDeepDish);
            grpCrust.Controls.Add(rbtnHandTossed);
            grpCrust.Controls.Add(rbtnThinCrust);
            grpCrust.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grpCrust.Location = new Point(290, 393);
            grpCrust.Margin = new Padding(4);
            grpCrust.Name = "grpCrust";
            grpCrust.Padding = new Padding(4);
            grpCrust.Size = new Size(246, 234);
            grpCrust.TabIndex = 5;
            grpCrust.TabStop = false;
            grpCrust.Text = "Crust";
            // 
            // rbtnCheeseStuffed
            // 
            rbtnCheeseStuffed.AutoSize = true;
            rbtnCheeseStuffed.Location = new Point(25, 167);
            rbtnCheeseStuffed.Margin = new Padding(4);
            rbtnCheeseStuffed.Name = "rbtnCheeseStuffed";
            rbtnCheeseStuffed.Size = new Size(181, 32);
            rbtnCheeseStuffed.TabIndex = 3;
            rbtnCheeseStuffed.TabStop = true;
            rbtnCheeseStuffed.Text = "Stuffed w Cheese";
            rbtnCheeseStuffed.UseVisualStyleBackColor = true;
            // 
            // rbtnDeepDish
            // 
            rbtnDeepDish.AutoSize = true;
            rbtnDeepDish.Location = new Point(25, 125);
            rbtnDeepDish.Margin = new Padding(4);
            rbtnDeepDish.Name = "rbtnDeepDish";
            rbtnDeepDish.Size = new Size(122, 32);
            rbtnDeepDish.TabIndex = 2;
            rbtnDeepDish.TabStop = true;
            rbtnDeepDish.Text = "Deep Dish";
            rbtnDeepDish.UseVisualStyleBackColor = true;
            // 
            // rbtnHandTossed
            // 
            rbtnHandTossed.AutoSize = true;
            rbtnHandTossed.Location = new Point(25, 83);
            rbtnHandTossed.Margin = new Padding(4);
            rbtnHandTossed.Name = "rbtnHandTossed";
            rbtnHandTossed.Size = new Size(145, 32);
            rbtnHandTossed.TabIndex = 1;
            rbtnHandTossed.TabStop = true;
            rbtnHandTossed.Text = "Hand Tossed";
            rbtnHandTossed.UseVisualStyleBackColor = true;
            // 
            // rbtnThinCrust
            // 
            rbtnThinCrust.AutoSize = true;
            rbtnThinCrust.Location = new Point(25, 41);
            rbtnThinCrust.Margin = new Padding(4);
            rbtnThinCrust.Name = "rbtnThinCrust";
            rbtnThinCrust.Size = new Size(131, 32);
            rbtnThinCrust.TabIndex = 0;
            rbtnThinCrust.TabStop = true;
            rbtnThinCrust.Text = "Thin Crispy";
            rbtnThinCrust.UseVisualStyleBackColor = true;
            // 
            // grpCustomize
            // 
            grpCustomize.Controls.Add(lblParmesanCheeseAmount);
            grpCustomize.Controls.Add(lblGarlicAmount);
            grpCustomize.Controls.Add(lblSauceAmount);
            grpCustomize.Controls.Add(lblParmesanCheese);
            grpCustomize.Controls.Add(lblGarlic);
            grpCustomize.Controls.Add(lblSauce);
            grpCustomize.Controls.Add(hScrollParmesanCheese);
            grpCustomize.Controls.Add(hScrollGarlic);
            grpCustomize.Controls.Add(hScrollSauce);
            grpCustomize.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grpCustomize.Location = new Point(588, 339);
            grpCustomize.Margin = new Padding(4);
            grpCustomize.Name = "grpCustomize";
            grpCustomize.Padding = new Padding(4);
            grpCustomize.Size = new Size(454, 288);
            grpCustomize.TabIndex = 6;
            grpCustomize.TabStop = false;
            grpCustomize.Text = "Customize";
            // 
            // lblParmesanCheeseAmount
            // 
            lblParmesanCheeseAmount.AutoSize = true;
            lblParmesanCheeseAmount.Location = new Point(263, 207);
            lblParmesanCheeseAmount.Margin = new Padding(4, 0, 4, 0);
            lblParmesanCheeseAmount.Name = "lblParmesanCheeseAmount";
            lblParmesanCheeseAmount.Size = new Size(23, 28);
            lblParmesanCheeseAmount.TabIndex = 17;
            lblParmesanCheeseAmount.Text = "0";
            // 
            // lblGarlicAmount
            // 
            lblGarlicAmount.AutoSize = true;
            lblGarlicAmount.Location = new Point(263, 120);
            lblGarlicAmount.Margin = new Padding(4, 0, 4, 0);
            lblGarlicAmount.Name = "lblGarlicAmount";
            lblGarlicAmount.Size = new Size(23, 28);
            lblGarlicAmount.TabIndex = 16;
            lblGarlicAmount.Text = "0";
            // 
            // lblSauceAmount
            // 
            lblSauceAmount.AutoSize = true;
            lblSauceAmount.Location = new Point(263, 35);
            lblSauceAmount.Margin = new Padding(4, 0, 4, 0);
            lblSauceAmount.Name = "lblSauceAmount";
            lblSauceAmount.Size = new Size(23, 28);
            lblSauceAmount.TabIndex = 15;
            lblSauceAmount.Text = "0";
            // 
            // lblParmesanCheese
            // 
            lblParmesanCheese.AutoSize = true;
            lblParmesanCheese.Location = new Point(41, 207);
            lblParmesanCheese.Margin = new Padding(4, 0, 4, 0);
            lblParmesanCheese.Name = "lblParmesanCheese";
            lblParmesanCheese.Size = new Size(167, 28);
            lblParmesanCheese.TabIndex = 14;
            lblParmesanCheese.Text = "Parmesan Cheese";
            // 
            // lblGarlic
            // 
            lblGarlic.AutoSize = true;
            lblGarlic.Location = new Point(41, 120);
            lblGarlic.Margin = new Padding(4, 0, 4, 0);
            lblGarlic.Name = "lblGarlic";
            lblGarlic.Size = new Size(63, 28);
            lblGarlic.TabIndex = 13;
            lblGarlic.Text = "Garlic";
            // 
            // lblSauce
            // 
            lblSauce.AutoSize = true;
            lblSauce.Location = new Point(41, 38);
            lblSauce.Margin = new Padding(4, 0, 4, 0);
            lblSauce.Name = "lblSauce";
            lblSauce.Size = new Size(161, 28);
            lblSauce.TabIndex = 12;
            lblSauce.Text = "Amount of Sauce";
            // 
            // hScrollParmesanCheese
            // 
            hScrollParmesanCheese.Location = new Point(18, 248);
            hScrollParmesanCheese.Name = "hScrollParmesanCheese";
            hScrollParmesanCheese.Size = new Size(404, 26);
            hScrollParmesanCheese.TabIndex = 11;
            hScrollParmesanCheese.Scroll += hScrollParmesanCheese_Scroll;
            // 
            // hScrollGarlic
            // 
            hScrollGarlic.Location = new Point(16, 171);
            hScrollGarlic.Name = "hScrollGarlic";
            hScrollGarlic.Size = new Size(404, 26);
            hScrollGarlic.TabIndex = 10;
            hScrollGarlic.Scroll += hScrollGarlic_Scroll;
            // 
            // hScrollSauce
            // 
            hScrollSauce.Location = new Point(18, 84);
            hScrollSauce.Name = "hScrollSauce";
            hScrollSauce.Size = new Size(404, 26);
            hScrollSauce.TabIndex = 9;
            hScrollSauce.Scroll += hScrollSauce_Scroll;
            // 
            // grpDeliveryTime
            // 
            grpDeliveryTime.Controls.Add(dateTimePickerDelivery);
            grpDeliveryTime.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grpDeliveryTime.Location = new Point(588, 55);
            grpDeliveryTime.Margin = new Padding(4);
            grpDeliveryTime.Name = "grpDeliveryTime";
            grpDeliveryTime.Padding = new Padding(4);
            grpDeliveryTime.Size = new Size(474, 105);
            grpDeliveryTime.TabIndex = 7;
            grpDeliveryTime.TabStop = false;
            grpDeliveryTime.Text = "Delivery Time";
            // 
            // dateTimePickerDelivery
            // 
            dateTimePickerDelivery.Location = new Point(8, 36);
            dateTimePickerDelivery.Margin = new Padding(4);
            dateTimePickerDelivery.Name = "dateTimePickerDelivery";
            dateTimePickerDelivery.Size = new Size(455, 34);
            dateTimePickerDelivery.TabIndex = 0;
            // 
            // lblQuantityOfPizzas
            // 
            lblQuantityOfPizzas.AutoSize = true;
            lblQuantityOfPizzas.Location = new Point(518, 291);
            lblQuantityOfPizzas.Margin = new Padding(4, 0, 4, 0);
            lblQuantityOfPizzas.Name = "lblQuantityOfPizzas";
            lblQuantityOfPizzas.Size = new Size(164, 28);
            lblQuantityOfPizzas.TabIndex = 8;
            lblQuantityOfPizzas.Text = "Number of Pizzas";
            // 
            // numNumberOfPizzas
            // 
            numNumberOfPizzas.Location = new Point(729, 291);
            numNumberOfPizzas.Margin = new Padding(4);
            numNumberOfPizzas.Name = "numNumberOfPizzas";
            numNumberOfPizzas.Size = new Size(146, 34);
            numNumberOfPizzas.TabIndex = 11;
            // 
            // lblCheeseMeter
            // 
            lblCheeseMeter.AutoSize = true;
            lblCheeseMeter.Location = new Point(518, 181);
            lblCheeseMeter.Margin = new Padding(4, 0, 4, 0);
            lblCheeseMeter.Name = "lblCheeseMeter";
            lblCheeseMeter.Size = new Size(129, 28);
            lblCheeseMeter.TabIndex = 13;
            lblCheeseMeter.Text = "Cheesy meter";
            // 
            // trkCheeseMeter
            // 
            trkCheeseMeter.Location = new Point(692, 168);
            trkCheeseMeter.Margin = new Padding(4);
            trkCheeseMeter.Maximum = 2;
            trkCheeseMeter.Name = "trkCheeseMeter";
            trkCheeseMeter.Size = new Size(353, 56);
            trkCheeseMeter.TabIndex = 14;
            // 
            // btnResetForm
            // 
            btnResetForm.BackColor = Color.DarkRed;
            btnResetForm.Font = new Font("Viner Hand ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetForm.ForeColor = Color.LightSkyBlue;
            btnResetForm.Location = new Point(595, 651);
            btnResetForm.Margin = new Padding(4);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(195, 57);
            btnResetForm.TabIndex = 16;
            btnResetForm.Text = "Reset Form";
            btnResetForm.UseVisualStyleBackColor = false;
            btnResetForm.Click += this.btnResetForm_Click;
            // 
            // btnCreatePizza
            // 
            btnCreatePizza.BackColor = Color.LightGreen;
            btnCreatePizza.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreatePizza.ForeColor = Color.Maroon;
            btnCreatePizza.Location = new Point(826, 651);
            btnCreatePizza.Margin = new Padding(4);
            btnCreatePizza.Name = "btnCreatePizza";
            btnCreatePizza.Size = new Size(216, 57);
            btnCreatePizza.TabIndex = 17;
            btnCreatePizza.Text = "Create Pizza";
            btnCreatePizza.UseVisualStyleBackColor = false;
            btnCreatePizza.Click += btnCreatePizza_Click;
            // 
            // lblNoCheese
            // 
            lblNoCheese.AutoSize = true;
            lblNoCheese.Location = new Point(630, 223);
            lblNoCheese.Margin = new Padding(4, 0, 4, 0);
            lblNoCheese.Name = "lblNoCheese";
            lblNoCheese.Size = new Size(105, 28);
            lblNoCheese.TabIndex = 18;
            lblNoCheese.Text = "No Cheese";
            // 
            // lblExtremeCheese
            // 
            lblExtremeCheese.AutoSize = true;
            lblExtremeCheese.Location = new Point(976, 223);
            lblExtremeCheese.Margin = new Padding(4, 0, 4, 0);
            lblExtremeCheese.Name = "lblExtremeCheese";
            lblExtremeCheese.Size = new Size(82, 28);
            lblExtremeCheese.TabIndex = 19;
            lblExtremeCheese.Text = "Extreme";
            // 
            // lblNormalChese
            // 
            lblNormalChese.AutoSize = true;
            lblNormalChese.Location = new Point(829, 223);
            lblNormalChese.Margin = new Padding(4, 0, 4, 0);
            lblNormalChese.Name = "lblNormalChese";
            lblNormalChese.Size = new Size(78, 28);
            lblNormalChese.TabIndex = 20;
            lblNormalChese.Text = "Normal";
            // 
            // picbSauceColor
            // 
            picbSauceColor.Location = new Point(197, 651);
            picbSauceColor.Name = "picbSauceColor";
            picbSauceColor.Size = new Size(332, 79);
            picbSauceColor.TabIndex = 21;
            picbSauceColor.TabStop = false;
            // 
            // btnSauceColor
            // 
            btnSauceColor.BackColor = Color.PaleTurquoise;
            btnSauceColor.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSauceColor.ForeColor = Color.Red;
            btnSauceColor.Location = new Point(37, 669);
            btnSauceColor.Name = "btnSauceColor";
            btnSauceColor.Size = new Size(132, 39);
            btnSauceColor.TabIndex = 23;
            btnSauceColor.Text = "Sauce Color";
            btnSauceColor.UseVisualStyleBackColor = false;
            btnSauceColor.Click += btnSauceColor_Click;
            // 
            // FrmPizzaOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1100, 772);
            Controls.Add(btnSauceColor);
            Controls.Add(picbSauceColor);
            Controls.Add(lblNormalChese);
            Controls.Add(lblExtremeCheese);
            Controls.Add(lblNoCheese);
            Controls.Add(btnCreatePizza);
            Controls.Add(btnResetForm);
            Controls.Add(trkCheeseMeter);
            Controls.Add(lblCheeseMeter);
            Controls.Add(numNumberOfPizzas);
            Controls.Add(lblQuantityOfPizzas);
            Controls.Add(grpDeliveryTime);
            Controls.Add(grpCustomize);
            Controls.Add(grpCrust);
            Controls.Add(listBoxOtherToppings);
            Controls.Add(label2);
            Controls.Add(grpToppings);
            Controls.Add(txtBoxNameOfOrder);
            Controls.Add(lblNameForOrder);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.MidnightBlue;
            Margin = new Padding(4);
            Name = "FrmPizzaOrder";
            Text = "Pizza Order";
            grpToppings.ResumeLayout(false);
            grpToppings.PerformLayout();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            grpCustomize.ResumeLayout(false);
            grpCustomize.PerformLayout();
            grpDeliveryTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numNumberOfPizzas).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkCheeseMeter).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbSauceColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameForOrder;
        private TextBox txtBoxNameOfOrder;
        private GroupBox grpToppings;
        private CheckBox chkMushrooms;
        private CheckBox chkHam;
        private CheckBox chkPineapple;
        private CheckBox chkPepperoni;
        private CheckBox chkTomatoes;
        private CheckBox chkSausage;
        private CheckBox chkBacon;
        private CheckBox chkCheese;
        private Label label2;
        private ListBox listBoxOtherToppings;
        private GroupBox grpCrust;
        private RadioButton rbtnCheeseStuffed;
        private RadioButton rbtnDeepDish;
        private RadioButton rbtnHandTossed;
        private RadioButton rbtnThinCrust;
        private GroupBox grpCustomize;
        private GroupBox grpDeliveryTime;
        private DateTimePicker dateTimePickerDelivery;
        private Label lblQuantityOfPizzas;
        private HScrollBar hScrollParmesanCheese;
        private HScrollBar hScrollGarlic;
        private HScrollBar hScrollSauce;
        private Label lblParmesanCheese;
        private Label lblGarlic;
        private Label lblSauce;
        private NumericUpDown numNumberOfPizzas;
        private Label lblCheeseMeter;
        private TrackBar trkCheeseMeter;
        private Button btnResetForm;
        private Button btnCreatePizza;
        private Label lblParmesanCheeseAmount;
        private Label lblGarlicAmount;
        private Label lblSauceAmount;
        private Label lblNoCheese;
        private Label lblExtremeCheese;
        private Label lblNormalChese;
        private PictureBox picbSauceColor;
        private ColorDialog colorDialSauce;
        private Button btnSauceColor;
    }
}
