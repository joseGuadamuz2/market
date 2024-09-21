namespace market
{
    partial class frmMain
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
            lblLocal = new Label();
            dgvMain = new DataGridView();
            btnNewBill = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Font = new Font("Sans Serif Collection", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocal.Location = new Point(90, 43);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(164, 71);
            lblLocal.TabIndex = 0;
            lblLocal.Text = "label1";
            // 
            // dgvMain
            // 
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location = new Point(63, 247);
            dgvMain.Name = "dgvMain";
            dgvMain.Size = new Size(563, 150);
            dgvMain.TabIndex = 1;
            // 
            // btnNewBill
            // 
            btnNewBill.Location = new Point(457, 192);
            btnNewBill.Name = "btnNewBill";
            btnNewBill.Size = new Size(140, 23);
            btnNewBill.TabIndex = 2;
            btnNewBill.Text = "Facturar";
            btnNewBill.UseVisualStyleBackColor = true;
            btnNewBill.Click += btnNewBill_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(btnNewBill);
            Controls.Add(dgvMain);
            Controls.Add(lblLocal);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLocal;
        private DataGridView dgvMain;
        private Button btnNewBill;
    }
}
