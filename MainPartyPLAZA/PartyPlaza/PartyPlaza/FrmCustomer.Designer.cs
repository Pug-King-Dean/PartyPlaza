﻿namespace PartyPlaza
{
    partial class FrmCustomer
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
            this.butEditCust = new System.Windows.Forms.Button();
            this.butExitCust = new System.Windows.Forms.Button();
            this.butAddCust = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // butEditCust
            // 
            this.butEditCust.Location = new System.Drawing.Point(842, 130);
            this.butEditCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butEditCust.Name = "butEditCust";
            this.butEditCust.Size = new System.Drawing.Size(261, 74);
            this.butEditCust.TabIndex = 9;
            this.butEditCust.Text = "Edit";
            this.butEditCust.UseVisualStyleBackColor = true;
            this.butEditCust.Click += new System.EventHandler(this.butEditCust_Click);
            // 
            // butExitCust
            // 
            this.butExitCust.Location = new System.Drawing.Point(842, 360);
            this.butExitCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butExitCust.Name = "butExitCust";
            this.butExitCust.Size = new System.Drawing.Size(261, 74);
            this.butExitCust.TabIndex = 7;
            this.butExitCust.Text = "Exit";
            this.butExitCust.UseVisualStyleBackColor = true;
            this.butExitCust.Click += new System.EventHandler(this.butExitCust_Click);
            // 
            // butAddCust
            // 
            this.butAddCust.Location = new System.Drawing.Point(842, 19);
            this.butAddCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butAddCust.Name = "butAddCust";
            this.butAddCust.Size = new System.Drawing.Size(261, 74);
            this.butAddCust.TabIndex = 6;
            this.butAddCust.Text = "Add";
            this.butAddCust.UseVisualStyleBackColor = true;
            this.butAddCust.Click += new System.EventHandler(this.butAddCust_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(18, 19);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 29;
            this.dgvCustomer.Size = new System.Drawing.Size(800, 601);
            this.dgvCustomer.TabIndex = 5;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(842, 248);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(261, 74);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 646);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.butEditCust);
            this.Controls.Add(this.butExitCust);
            this.Controls.Add(this.butAddCust);
            this.Controls.Add(this.dgvCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button butEditCust;
        private Button butExitCust;
        private Button butAddCust;
        private DataGridView dgvCustomer;
        private Button btnDelete;
    }
}