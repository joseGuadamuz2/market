namespace market
{
    partial class frmBill
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
            components = new System.ComponentModel.Container();
            lblID = new Label();
            lblShowID = new Label();
            lblName = new Label();
            txtName = new TextBox();
            dgvitems = new DataGridView();
            ldlIDArticle = new Label();
            txtID = new TextBox();
            lblArticleName = new Label();
            LblAmountArticle = new Label();
            txtAmount = new TextBox();
            lblPriceArticle = new Label();
            lblPriceShow = new Label();
            btnAddArticle = new Button();
            bindingSource1 = new BindingSource(components);
            lblNameProdutShow = new Label();
            btnSearchArticle = new Button();
            lblTotalPrice = new Label();
            lblAllPriceShow = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvitems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(48, 47);
            lblID.Name = "lblID";
            lblID.Size = new Size(62, 15);
            lblID.TabIndex = 0;
            lblID.Text = "Num Fact:";
            // 
            // lblShowID
            // 
            lblShowID.AutoSize = true;
            lblShowID.Location = new Point(126, 47);
            lblShowID.Name = "lblShowID";
            lblShowID.Size = new Size(38, 15);
            lblShowID.TabIndex = 1;
            lblShowID.Text = "label1";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(198, 47);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Nombre:";
            // 
            // txtName
            // 
            txtName.Location = new Point(280, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // dgvitems
            // 
            dgvitems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvitems.Location = new Point(48, 193);
            dgvitems.Name = "dgvitems";
            dgvitems.Size = new Size(551, 192);
            dgvitems.TabIndex = 4;
            // 
            // ldlIDArticle
            // 
            ldlIDArticle.AutoSize = true;
            ldlIDArticle.Location = new Point(48, 121);
            ldlIDArticle.Name = "ldlIDArticle";
            ldlIDArticle.Size = new Size(21, 15);
            ldlIDArticle.TabIndex = 5;
            ldlIDArticle.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(75, 118);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 6;
            txtID.Enter += txtID_Enter;
            // 
            // lblArticleName
            // 
            lblArticleName.AutoSize = true;
            lblArticleName.Location = new Point(196, 121);
            lblArticleName.Name = "lblArticleName";
            lblArticleName.Size = new Size(56, 15);
            lblArticleName.TabIndex = 7;
            lblArticleName.Text = "Producto";
            // 
            // LblAmountArticle
            // 
            LblAmountArticle.AutoSize = true;
            LblAmountArticle.Location = new Point(371, 118);
            LblAmountArticle.Name = "LblAmountArticle";
            LblAmountArticle.Size = new Size(55, 15);
            LblAmountArticle.TabIndex = 9;
            LblAmountArticle.Text = "Cantidad";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(448, 115);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 10;
            // 
            // lblPriceArticle
            // 
            lblPriceArticle.AutoSize = true;
            lblPriceArticle.Location = new Point(196, 160);
            lblPriceArticle.Name = "lblPriceArticle";
            lblPriceArticle.Size = new Size(43, 15);
            lblPriceArticle.TabIndex = 11;
            lblPriceArticle.Text = "Precio:";
            // 
            // lblPriceShow
            // 
            lblPriceShow.AutoSize = true;
            lblPriceShow.Location = new Point(265, 160);
            lblPriceShow.Name = "lblPriceShow";
            lblPriceShow.Size = new Size(38, 15);
            lblPriceShow.TabIndex = 12;
            lblPriceShow.Text = "label1";
            // 
            // btnAddArticle
            // 
            btnAddArticle.Location = new Point(461, 156);
            btnAddArticle.Name = "btnAddArticle";
            btnAddArticle.Size = new Size(75, 23);
            btnAddArticle.TabIndex = 13;
            btnAddArticle.Text = "Agregar";
            btnAddArticle.UseVisualStyleBackColor = true;
            btnAddArticle.Click += btnAddArticle_Click;
            // 
            // lblNameProdutShow
            // 
            lblNameProdutShow.AutoSize = true;
            lblNameProdutShow.Location = new Point(265, 121);
            lblNameProdutShow.Name = "lblNameProdutShow";
            lblNameProdutShow.Size = new Size(38, 15);
            lblNameProdutShow.TabIndex = 8;
            lblNameProdutShow.Text = "label1";
            // 
            // btnSearchArticle
            // 
            btnSearchArticle.Location = new Point(351, 156);
            btnSearchArticle.Name = "btnSearchArticle";
            btnSearchArticle.Size = new Size(75, 23);
            btnSearchArticle.TabIndex = 14;
            btnSearchArticle.Text = "Buscar";
            btnSearchArticle.UseVisualStyleBackColor = true;
            btnSearchArticle.Click += btnSearchArticle_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 22F);
            lblTotalPrice.Location = new Point(373, 400);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(88, 41);
            lblTotalPrice.TabIndex = 15;
            lblTotalPrice.Text = "Total:";
            // 
            // lblAllPriceShow
            // 
            lblAllPriceShow.AutoSize = true;
            lblAllPriceShow.Font = new Font("Segoe UI", 22F);
            lblAllPriceShow.Location = new Point(470, 400);
            lblAllPriceShow.Name = "lblAllPriceShow";
            lblAllPriceShow.Size = new Size(97, 41);
            lblAllPriceShow.TabIndex = 16;
            lblAllPriceShow.Text = "label1";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(641, 412);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 17;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(lblAllPriceShow);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnSearchArticle);
            Controls.Add(lblNameProdutShow);
            Controls.Add(btnAddArticle);
            Controls.Add(lblPriceShow);
            Controls.Add(lblPriceArticle);
            Controls.Add(txtAmount);
            Controls.Add(LblAmountArticle);
            Controls.Add(lblArticleName);
            Controls.Add(txtID);
            Controls.Add(ldlIDArticle);
            Controls.Add(dgvitems);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblShowID);
            Controls.Add(lblID);
            Name = "frmBill";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmBill";
            ((System.ComponentModel.ISupportInitialize)dgvitems).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblShowID;
        private Label lblName;
        private TextBox txtName;
        private DataGridView dgvitems;
        private Label ldlIDArticle;
        private TextBox txtID;
        private Label lblArticleName;
        private Label LblAmountArticle;
        private TextBox txtAmount;
        private Label lblPriceArticle;
        private Label lblPriceShow;
        private Button btnAddArticle;
        private BindingSource bindingSource1;
        private Label lblNameProdutShow;
        private Button btnSearchArticle;
        private Label lblTotalPrice;
        private Label lblAllPriceShow;
        private Button btnSave;
    }
}