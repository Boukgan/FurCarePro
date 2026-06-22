namespace FurCarePro
{
    partial class FrmRegister
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressPassword = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Peru;
            this.lblTitle.Location = new System.Drawing.Point(567, 94);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Create Account";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(571, 161);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(250, 20);
            this.txtFullName.TabIndex = 4;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoEllipsis = true;
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.SteelBlue;
            this.lblFullName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFullName.Location = new System.Drawing.Point(567, 138);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(76, 18);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Full Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(571, 237);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.SteelBlue;
            this.lblEmail.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEmail.Location = new System.Drawing.Point(567, 214);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 18);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.lblPassword.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPassword.Location = new System.Drawing.Point(567, 295);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 18);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(571, 318);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(571, 408);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 20);
            this.txtConfirmPassword.TabIndex = 10;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.lblConfirmPassword.Location = new System.Drawing.Point(567, 385);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(126, 18);
            this.lblConfirmPassword.TabIndex = 9;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(571, 495);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 20);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.SteelBlue;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPhoneNumber.Location = new System.Drawing.Point(567, 472);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(106, 18);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(543, 554);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(654, 554);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(768, 554);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressPassword
            // 
            this.progressPassword.Location = new System.Drawing.Point(573, 345);
            this.progressPassword.Name = "progressPassword";
            this.progressPassword.Size = new System.Drawing.Size(248, 23);
            this.progressPassword.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(528, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 541);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FurCarePro.Properties.Resources._8;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.progressPassword);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegister";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar progressPassword;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}