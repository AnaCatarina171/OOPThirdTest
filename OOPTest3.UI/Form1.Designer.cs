namespace OOPTest3.UI
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstDigital = new System.Windows.Forms.ListBox();
            this.lstPrint = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublicationName = new System.Windows.Forms.TextBox();
            this.rdoDigital = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoPrint = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMailingAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVolume = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIssue = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDigitalSubtotal = new System.Windows.Forms.Label();
            this.lblPrint = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 429);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstDigital
            // 
            this.lstDigital.FormattingEnabled = true;
            this.lstDigital.Location = new System.Drawing.Point(388, 38);
            this.lstDigital.Name = "lstDigital";
            this.lstDigital.Size = new System.Drawing.Size(230, 316);
            this.lstDigital.TabIndex = 3;
            // 
            // lstPrint
            // 
            this.lstPrint.FormattingEnabled = true;
            this.lstPrint.Location = new System.Drawing.Point(627, 38);
            this.lstPrint.Name = "lstPrint";
            this.lstPrint.Size = new System.Drawing.Size(230, 316);
            this.lstPrint.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Print";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Publication Name:";
            // 
            // txtPublicationName
            // 
            this.txtPublicationName.Location = new System.Drawing.Point(146, 263);
            this.txtPublicationName.Name = "txtPublicationName";
            this.txtPublicationName.Size = new System.Drawing.Size(199, 20);
            this.txtPublicationName.TabIndex = 1;
            // 
            // rdoDigital
            // 
            this.rdoDigital.AutoSize = true;
            this.rdoDigital.Checked = true;
            this.rdoDigital.Location = new System.Drawing.Point(68, 19);
            this.rdoDigital.Name = "rdoDigital";
            this.rdoDigital.Size = new System.Drawing.Size(54, 17);
            this.rdoDigital.TabIndex = 9;
            this.rdoDigital.TabStop = true;
            this.rdoDigital.Text = "Digital";
            this.rdoDigital.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPrint);
            this.groupBox1.Controls.Add(this.rdoDigital);
            this.groupBox1.Location = new System.Drawing.Point(39, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 59);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Media Type";
            // 
            // rdoPrint
            // 
            this.rdoPrint.AutoSize = true;
            this.rdoPrint.Location = new System.Drawing.Point(184, 19);
            this.rdoPrint.Name = "rdoPrint";
            this.rdoPrint.Size = new System.Drawing.Size(46, 17);
            this.rdoPrint.TabIndex = 10;
            this.rdoPrint.Text = "Print";
            this.rdoPrint.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(109, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "chris.cusack@nbcc.ca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(109, 188);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(199, 20);
            this.txtPostalCode.TabIndex = 6;
            this.txtPostalCode.Text = "E1D3E4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Postal Code:";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(109, 162);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(199, 20);
            this.txtProvince.TabIndex = 5;
            this.txtProvince.Text = "NB";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Province:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(109, 136);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(199, 20);
            this.txtCity.TabIndex = 4;
            this.txtCity.Text = "Moncton";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "City:";
            // 
            // txtMailingAddress
            // 
            this.txtMailingAddress.Location = new System.Drawing.Point(109, 110);
            this.txtMailingAddress.Name = "txtMailingAddress";
            this.txtMailingAddress.Size = new System.Drawing.Size(199, 20);
            this.txtMailingAddress.TabIndex = 3;
            this.txtMailingAddress.Text = "1234 Mountain Rd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volume:";
            // 
            // cmbVolume
            // 
            this.cmbVolume.FormattingEnabled = true;
            this.cmbVolume.Location = new System.Drawing.Point(146, 289);
            this.cmbVolume.Name = "cmbVolume";
            this.cmbVolume.Size = new System.Drawing.Size(199, 21);
            this.cmbVolume.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Issue:";
            // 
            // cmbIssue
            // 
            this.cmbIssue.FormattingEnabled = true;
            this.cmbIssue.Location = new System.Drawing.Point(146, 316);
            this.cmbIssue.Name = "cmbIssue";
            this.cmbIssue.Size = new System.Drawing.Size(199, 21);
            this.cmbIssue.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(109, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "Chris";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(109, 57);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 20);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Text = "Cusack";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Last Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(385, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Running Total:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(630, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Running Total:";
            // 
            // lblDigitalSubtotal
            // 
            this.lblDigitalSubtotal.AutoSize = true;
            this.lblDigitalSubtotal.Location = new System.Drawing.Point(468, 373);
            this.lblDigitalSubtotal.Name = "lblDigitalSubtotal";
            this.lblDigitalSubtotal.Size = new System.Drawing.Size(115, 13);
            this.lblDigitalSubtotal.TabIndex = 25;
            this.lblDigitalSubtotal.Text = "[DIGITAL SUBTOTAL]";
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Location = new System.Drawing.Point(713, 373);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(106, 13);
            this.lblPrint.TabIndex = 26;
            this.lblPrint.Text = "[PRINT SUBTOTAL]";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(536, 432);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 24);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "[TOTAL]";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(146, 344);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(199, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 347);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Issue Price:";
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.label8);
            this.grpPersonalInfo.Controls.Add(this.txtPostalCode);
            this.grpPersonalInfo.Controls.Add(this.txtFirstName);
            this.grpPersonalInfo.Controls.Add(this.txtEmail);
            this.grpPersonalInfo.Controls.Add(this.label9);
            this.grpPersonalInfo.Controls.Add(this.label12);
            this.grpPersonalInfo.Controls.Add(this.txtLastName);
            this.grpPersonalInfo.Controls.Add(this.label7);
            this.grpPersonalInfo.Controls.Add(this.txtProvince);
            this.grpPersonalInfo.Controls.Add(this.txtMailingAddress);
            this.grpPersonalInfo.Controls.Add(this.label6);
            this.grpPersonalInfo.Controls.Add(this.label10);
            this.grpPersonalInfo.Controls.Add(this.label11);
            this.grpPersonalInfo.Controls.Add(this.txtCity);
            this.grpPersonalInfo.Location = new System.Drawing.Point(30, 15);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(334, 242);
            this.grpPersonalInfo.TabIndex = 0;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Subscriber Information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(204, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 34);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 481);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpPersonalInfo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.lblDigitalSubtotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbIssue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPublicationName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPrint);
            this.Controls.Add(this.lstDigital);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstDigital;
        private System.Windows.Forms.ListBox lstPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublicationName;
        private System.Windows.Forms.RadioButton rdoDigital;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIssue;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMailingAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDigitalSubtotal;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.Button btnClear;
    }
}

