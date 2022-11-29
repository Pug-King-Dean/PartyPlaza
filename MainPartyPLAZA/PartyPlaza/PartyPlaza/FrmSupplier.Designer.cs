namespace PartyPlaza
{
    partial class FrmSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.txtSupplierList = new System.Windows.Forms.TextBox();
            this.btnDisplayDeleteSupp = new System.Windows.Forms.Button();
            this.btnDisplayEditSupp = new System.Windows.Forms.Button();
            this.btnDisplayExitSupp = new System.Windows.Forms.Button();
            this.btnDisplayAddSupp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(13, 71);
            this.dgvSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSupplier.Name = "dgvSupplier";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSupplier.RowHeadersWidth = 51;
            this.dgvSupplier.RowTemplate.Height = 29;
            this.dgvSupplier.Size = new System.Drawing.Size(800, 562);
            this.dgvSupplier.TabIndex = 6;
            this.dgvSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvSupplier.Click += new System.EventHandler(this.FrmSupplier_Load);
            // 
            // txtSupplierList
            // 
            this.txtSupplierList.BackColor = System.Drawing.SystemColors.Control;
            this.txtSupplierList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplierList.Location = new System.Drawing.Point(13, 23);
            this.txtSupplierList.Name = "txtSupplierList";
            this.txtSupplierList.Size = new System.Drawing.Size(150, 39);
            this.txtSupplierList.TabIndex = 7;
            this.txtSupplierList.Text = "Supplier List";
            // 
            // btnDisplayDeleteSupp
            // 
            this.btnDisplayDeleteSupp.Location = new System.Drawing.Point(838, 399);
            this.btnDisplayDeleteSupp.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayDeleteSupp.Name = "btnDisplayDeleteSupp";
            this.btnDisplayDeleteSupp.Size = new System.Drawing.Size(261, 74);
            this.btnDisplayDeleteSupp.TabIndex = 14;
            this.btnDisplayDeleteSupp.Text = "Delete";
            this.btnDisplayDeleteSupp.UseVisualStyleBackColor = true;
            this.btnDisplayDeleteSupp.Click += new System.EventHandler(this.btnDisplayDeleteSupp_Click);
            // 
            // btnDisplayEditSupp
            // 
            this.btnDisplayEditSupp.Location = new System.Drawing.Point(838, 281);
            this.btnDisplayEditSupp.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayEditSupp.Name = "btnDisplayEditSupp";
            this.btnDisplayEditSupp.Size = new System.Drawing.Size(261, 74);
            this.btnDisplayEditSupp.TabIndex = 13;
            this.btnDisplayEditSupp.Text = "Edit";
            this.btnDisplayEditSupp.UseVisualStyleBackColor = true;
            this.btnDisplayEditSupp.Click += new System.EventHandler(this.btnDisplayEditSupp_Click);
            // 
            // btnDisplayExitSupp
            // 
            this.btnDisplayExitSupp.Location = new System.Drawing.Point(838, 511);
            this.btnDisplayExitSupp.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayExitSupp.Name = "btnDisplayExitSupp";
            this.btnDisplayExitSupp.Size = new System.Drawing.Size(261, 74);
            this.btnDisplayExitSupp.TabIndex = 12;
            this.btnDisplayExitSupp.Text = "Exit";
            this.btnDisplayExitSupp.UseVisualStyleBackColor = true;
            this.btnDisplayExitSupp.Click += new System.EventHandler(this.btnDisplayExitSupp_Click);
            // 
            // btnDisplayAddSupp
            // 
            this.btnDisplayAddSupp.Location = new System.Drawing.Point(838, 170);
            this.btnDisplayAddSupp.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayAddSupp.Name = "btnDisplayAddSupp";
            this.btnDisplayAddSupp.Size = new System.Drawing.Size(261, 74);
            this.btnDisplayAddSupp.TabIndex = 11;
            this.btnDisplayAddSupp.Text = "Add";
            this.btnDisplayAddSupp.UseVisualStyleBackColor = true;
            this.btnDisplayAddSupp.Click += new System.EventHandler(this.btnDisplayAddSupp_Click);
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 646);
            this.Controls.Add(this.btnDisplayDeleteSupp);
            this.Controls.Add(this.btnDisplayEditSupp);
            this.Controls.Add(this.btnDisplayExitSupp);
            this.Controls.Add(this.btnDisplayAddSupp);
            this.Controls.Add(this.txtSupplierList);
            this.Controls.Add(this.dgvSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSupplier";
            this.Text = "FrmSupplier";
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvSupplier;
        private TextBox txtSupplierList;
        private Button btnDisplayDeleteSupp;
        private Button btnDisplayEditSupp;
        private Button btnDisplayExitSupp;
        private Button btnDisplayAddSupp;
    }
}