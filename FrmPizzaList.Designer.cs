
namespace Activity4
{
    partial class FrmPizzaList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstPizzaList = new ListBox();
            btnSortAToZ = new Button();
            btnSortZToA = new Button();
            btnDelete = new Button();
            lstPizzaOrderDetails = new ListBox();
            SuspendLayout();
            // 
            // lstPizzaList
            // 
            lstPizzaList.FormattingEnabled = true;
            lstPizzaList.Location = new Point(27, 22);
            lstPizzaList.Name = "lstPizzaList";
            lstPizzaList.Size = new Size(281, 404);
            lstPizzaList.TabIndex = 0;
            // 
            // btnSortAToZ
            // 
            btnSortAToZ.Location = new Point(363, 26);
            btnSortAToZ.Name = "btnSortAToZ";
            btnSortAToZ.Size = new Size(94, 29);
            btnSortAToZ.TabIndex = 1;
            btnSortAToZ.Text = "A->Z";
            btnSortAToZ.UseVisualStyleBackColor = true;
            btnSortAToZ.Click += btnSortAToZ_Click;
            // 
            // btnSortZToA
            // 
            btnSortZToA.Location = new Point(475, 26);
            btnSortZToA.Name = "btnSortZToA";
            btnSortZToA.Size = new Size(94, 29);
            btnSortZToA.TabIndex = 2;
            btnSortZToA.Text = "Z->A";
            btnSortZToA.UseVisualStyleBackColor = true;
            btnSortZToA.Click += btnSortZToA_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(590, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // lstPizzaOrderDetails
            // 
            lstPizzaOrderDetails.FormattingEnabled = true;
            lstPizzaOrderDetails.Location = new Point(367, 75);
            lstPizzaOrderDetails.Name = "lstPizzaOrderDetails";
            lstPizzaOrderDetails.Size = new Size(393, 344);
            lstPizzaOrderDetails.TabIndex = 4;
            // 
            // FrmPizzaList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPizzaOrderDetails);
            Controls.Add(btnDelete);
            Controls.Add(btnSortZToA);
            Controls.Add(btnSortAToZ);
            Controls.Add(lstPizzaList);
            Name = "FrmPizzaList";
            Text = "FrmPizzaList";
            Click += btnSortZToA_Click;
            ResumeLayout(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListBox lstPizzaList;
        private Button btnSortAToZ;
        private Button btnSortZToA;
        private Button btnDelete;
        private ListBox lstPizzaOrderDetails;
    }
}