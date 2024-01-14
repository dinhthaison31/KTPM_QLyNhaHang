namespace testdemo1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_TestLogin = new System.Windows.Forms.Button();
            this.btn_TestRegister = new System.Windows.Forms.Button();
            this.btn_testbooking = new System.Windows.Forms.Button();
            this.btn_testfoodorder = new System.Windows.Forms.Button();
            this.btn_TestCreateStaff = new System.Windows.Forms.Button();
            this.btn_TestProfile = new System.Windows.Forms.Button();
            this.btn_TestServices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_TestLogin
            // 
            this.btn_TestLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TestLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestLogin.Location = new System.Drawing.Point(48, 613);
            this.btn_TestLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TestLogin.Name = "btn_TestLogin";
            this.btn_TestLogin.Size = new System.Drawing.Size(184, 42);
            this.btn_TestLogin.TabIndex = 0;
            this.btn_TestLogin.Text = "Test Đăng Nhập";
            this.btn_TestLogin.UseVisualStyleBackColor = false;
            this.btn_TestLogin.Click += new System.EventHandler(this.btn_TestLogin_Click);
            // 
            // btn_TestRegister
            // 
            this.btn_TestRegister.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TestRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestRegister.Location = new System.Drawing.Point(233, 613);
            this.btn_TestRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TestRegister.Name = "btn_TestRegister";
            this.btn_TestRegister.Size = new System.Drawing.Size(184, 42);
            this.btn_TestRegister.TabIndex = 1;
            this.btn_TestRegister.Text = "Test Đăng Ký";
            this.btn_TestRegister.UseVisualStyleBackColor = false;
            this.btn_TestRegister.Click += new System.EventHandler(this.btn_TestRegister_Click);
            // 
            // btn_testbooking
            // 
            this.btn_testbooking.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_testbooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testbooking.Location = new System.Drawing.Point(417, 613);
            this.btn_testbooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_testbooking.Name = "btn_testbooking";
            this.btn_testbooking.Size = new System.Drawing.Size(184, 42);
            this.btn_testbooking.TabIndex = 2;
            this.btn_testbooking.Text = "Test Đặt Bàn";
            this.btn_testbooking.UseVisualStyleBackColor = false;
            this.btn_testbooking.Click += new System.EventHandler(this.btn_testbooking_Click);
            // 
            // btn_testfoodorder
            // 
            this.btn_testfoodorder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_testfoodorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testfoodorder.Location = new System.Drawing.Point(600, 613);
            this.btn_testfoodorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_testfoodorder.Name = "btn_testfoodorder";
            this.btn_testfoodorder.Size = new System.Drawing.Size(184, 42);
            this.btn_testfoodorder.TabIndex = 3;
            this.btn_testfoodorder.Text = "Test Đặt Món";
            this.btn_testfoodorder.UseVisualStyleBackColor = false;
            this.btn_testfoodorder.Click += new System.EventHandler(this.btn_testfoodorder_Click);
            // 
            // btn_TestCreateStaff
            // 
            this.btn_TestCreateStaff.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TestCreateStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestCreateStaff.Location = new System.Drawing.Point(791, 613);
            this.btn_TestCreateStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TestCreateStaff.Name = "btn_TestCreateStaff";
            this.btn_TestCreateStaff.Size = new System.Drawing.Size(184, 41);
            this.btn_TestCreateStaff.TabIndex = 4;
            this.btn_TestCreateStaff.Text = "Test QLNV";
            this.btn_TestCreateStaff.UseVisualStyleBackColor = false;
            this.btn_TestCreateStaff.Click += new System.EventHandler(this.btn_TestCreateStaff_Click_1);
            // 
            // btn_TestProfile
            // 
            this.btn_TestProfile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TestProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestProfile.Location = new System.Drawing.Point(983, 613);
            this.btn_TestProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TestProfile.Name = "btn_TestProfile";
            this.btn_TestProfile.Size = new System.Drawing.Size(184, 39);
            this.btn_TestProfile.TabIndex = 5;
            this.btn_TestProfile.Text = "Test TTCN";
            this.btn_TestProfile.UseVisualStyleBackColor = false;
            this.btn_TestProfile.Click += new System.EventHandler(this.btn_TestProfile_Click);
            // 
            // btn_TestServices
            // 
            this.btn_TestServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestServices.Location = new System.Drawing.Point(48, 549);
            this.btn_TestServices.Name = "btn_TestServices";
            this.btn_TestServices.Size = new System.Drawing.Size(184, 43);
            this.btn_TestServices.TabIndex = 6;
            this.btn_TestServices.Text = "Test QLDV";
            this.btn_TestServices.UseVisualStyleBackColor = true;
            this.btn_TestServices.Click += new System.EventHandler(this.btn_TestServices_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 675);
            this.Controls.Add(this.btn_TestServices);
            this.Controls.Add(this.btn_TestProfile);
            this.Controls.Add(this.btn_TestCreateStaff);
            this.Controls.Add(this.btn_testfoodorder);
            this.Controls.Add(this.btn_testbooking);
            this.Controls.Add(this.btn_TestRegister);
            this.Controls.Add(this.btn_TestLogin);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form lệnh test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TestLogin;
        private System.Windows.Forms.Button btn_TestRegister;
        private System.Windows.Forms.Button btn_testbooking;
        private System.Windows.Forms.Button btn_testfoodorder;
        private System.Windows.Forms.Button btn_TestCreateStaff;
        private System.Windows.Forms.Button btn_TestProfile;
        private System.Windows.Forms.Button btn_TestServices;
    }
}

