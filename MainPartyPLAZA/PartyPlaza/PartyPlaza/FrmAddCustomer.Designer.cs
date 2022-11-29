namespace PartyPlaza
{
    partial class FrmAddCustomer
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnAddExit = new System.Windows.Forms.Button();
            this.BtnAddCancel = new System.Windows.Forms.Button();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddTelNo = new System.Windows.Forms.TextBox();
            this.txtAddPostcode = new System.Windows.Forms.TextBox();
            this.txtAddCounty = new System.Windows.Forms.TextBox();
            this.txtAddTown = new System.Windows.Forms.TextBox();
            this.txtAddStreet = new System.Windows.Forms.TextBox();
            this.txtAddForename = new System.Windows.Forms.TextBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.labCustomerNumAdd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-98, 235);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 120);
            this.panel1.TabIndex = 1;
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // BtnAddExit
            // 
            this.BtnAddExit.Location = new System.Drawing.Point(715, 384);
            this.BtnAddExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddExit.Name = "BtnAddExit";
            this.BtnAddExit.Size = new System.Drawing.Size(366, 76);
            this.BtnAddExit.TabIndex = 61;
            this.BtnAddExit.Text = "Exit";
            this.BtnAddExit.UseVisualStyleBackColor = true;
            this.BtnAddExit.Click += new System.EventHandler(this.BtnAddExit_Click);
            // 
            // BtnAddCancel
            // 
            this.BtnAddCancel.Location = new System.Drawing.Point(715, 239);
            this.BtnAddCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddCancel.Name = "BtnAddCancel";
            this.BtnAddCancel.Size = new System.Drawing.Size(366, 76);
            this.BtnAddCancel.TabIndex = 60;
            this.BtnAddCancel.Text = "Cancel";
            this.BtnAddCancel.UseVisualStyleBackColor = true;
            this.BtnAddCancel.Click += new System.EventHandler(this.BtnAddCancel_Click);
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.Location = new System.Drawing.Point(715, 101);
            this.btnAddAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(366, 79);
            this.btnAddAdd.TabIndex = 59;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = true;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(276, 579);
            this.txtAddEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(343, 31);
            this.txtAddEmail.TabIndex = 58;
            // 
            // txtAddTelNo
            // 
            this.txtAddTelNo.Location = new System.Drawing.Point(276, 516);
            this.txtAddTelNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddTelNo.Name = "txtAddTelNo";
            this.txtAddTelNo.Size = new System.Drawing.Size(343, 31);
            this.txtAddTelNo.TabIndex = 57;
            // 
            // txtAddPostcode
            // 
            this.txtAddPostcode.Location = new System.Drawing.Point(276, 454);
            this.txtAddPostcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddPostcode.Name = "txtAddPostcode";
            this.txtAddPostcode.Size = new System.Drawing.Size(343, 31);
            this.txtAddPostcode.TabIndex = 56;
            // 
            // txtAddCounty
            // 
            this.txtAddCounty.Location = new System.Drawing.Point(276, 384);
            this.txtAddCounty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddCounty.Name = "txtAddCounty";
            this.txtAddCounty.Size = new System.Drawing.Size(343, 31);
            this.txtAddCounty.TabIndex = 55;
            // 
            // txtAddTown
            // 
            this.txtAddTown.Location = new System.Drawing.Point(276, 306);
            this.txtAddTown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddTown.Name = "txtAddTown";
            this.txtAddTown.Size = new System.Drawing.Size(343, 31);
            this.txtAddTown.TabIndex = 54;
            // 
            // txtAddStreet
            // 
            this.txtAddStreet.Location = new System.Drawing.Point(276, 239);
            this.txtAddStreet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddStreet.Name = "txtAddStreet";
            this.txtAddStreet.Size = new System.Drawing.Size(343, 31);
            this.txtAddStreet.TabIndex = 53;
            // 
            // txtAddForename
            // 
            this.txtAddForename.Location = new System.Drawing.Point(276, 169);
            this.txtAddForename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddForename.Name = "txtAddForename";
            this.txtAddForename.Size = new System.Drawing.Size(343, 31);
            this.txtAddForename.TabIndex = 52;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Location = new System.Drawing.Point(276, 101);
            this.txtAddSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(343, 31);
            this.txtAddSurname.TabIndex = 51;
            // 
            // labCustomerNumAdd
            // 
            this.labCustomerNumAdd.AutoSize = true;
            this.labCustomerNumAdd.Location = new System.Drawing.Point(276, 41);
            this.labCustomerNumAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCustomerNumAdd.Name = "labCustomerNumAdd";
            this.labCustomerNumAdd.Size = new System.Drawing.Size(19, 25);
            this.labCustomerNumAdd.TabIndex = 50;
            this.labCustomerNumAdd.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(39, 454);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 28);
            this.label9.TabIndex = 49;
            this.label9.Text = "Postcode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(39, 516);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 28);
            this.label8.TabIndex = 48;
            this.label8.Text = "Telephone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(39, 579);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 28);
            this.label7.TabIndex = 47;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(39, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 28);
            this.label6.TabIndex = 46;
            this.label6.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(39, 384);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 45;
            this.label5.Text = "County";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 28);
            this.label4.TabIndex = 44;
            this.label4.Text = "Town";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Forename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 42;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "Customer Number";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 646);
            this.Controls.Add(this.BtnAddExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAddCancel);
            this.Controls.Add(this.btnAddAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddTelNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddPostcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddCounty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddTown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddStreet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddForename);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddSurname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labCustomerNumAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAddCustomer";
            this.Text = "FrmAddCustomer";
            this.Load += new System.EventHandler(this.FrmAddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private ErrorProvider errP;
        private Button BtnAddExit;
        private Button BtnAddCancel;
        private Button btnAddAdd;
        private Label label1;
        private TextBox txtAddEmail;
        private Label label2;
        private TextBox txtAddTelNo;
        private Label label3;
        private TextBox txtAddPostcode;
        private Label label4;
        private TextBox txtAddCounty;
        private Label label5;
        private TextBox txtAddTown;
        private Label label6;
        private TextBox txtAddStreet;
        private Label label7;
        private TextBox txtAddForename;
        private Label label8;
        private TextBox txtAddSurname;
        private Label label9;
        private Label labCustomerNumAdd;
        private ErrorProvider errorProvider1;
    }
}