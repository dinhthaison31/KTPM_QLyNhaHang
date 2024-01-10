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
            this.btn_TestServices = new System.Windows.Forms.Button();
            this.btn_TestProfile = new System.Windows.Forms.Button();
            this.btn_TestRegister = new System.Windows.Forms.Button();
            this.btn_testbooking = new System.Windows.Forms.Button();
            this.btn_testfoodorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_TestLogin
            // 
            this.btn_TestLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TestLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestLogin.Location = new System.Drawing.Point(36, 498);
            this.btn_TestLogin.Name = "btn_TestLogin";
            this.btn_TestLogin.Size = new System.Drawing.Size(138, 34);
            this.btn_TestLogin.TabIndex = 0;
            this.btn_TestLogin.Text = "Test Đăng Nhập";
            this.btn_TestLogin.UseVisualStyleBackColor = false;
            this.btn_TestLogin.Click += new System.EventHandler(this.btn_TestLogin_Click);
            // 
            // btn_TestServices
            // 
            this.btn_TestServices.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TestServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestServices.Location = new System.Drawing.Point(588, 498);
            this.btn_TestServices.Name = "btn_TestServices";
            this.btn_TestServices.Size = new System.Drawing.Size(138, 34);
            this.btn_TestServices.TabIndex = 0;
            this.btn_TestServices.Text = "Test Dịch Vụ";
            this.btn_TestServices.UseVisualStyleBackColor = false;
            this.btn_TestServices.Click += new System.EventHandler(this.btn_TestLogin_Click);
            // 
            // btn_TestProfile
            // 
            this.btn_TestProfile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_TestProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestProfile.Location = new System.Drawing.Point(727, 498);
            this.btn_TestProfile.Name = "btn_TestProfile";
            this.btn_TestProfile.Size = new System.Drawing.Size(138, 34);
            this.btn_TestProfile.TabIndex = 0;
            this.btn_TestProfile.Text = "Test TTCN";
            this.btn_TestProfile.UseVisualStyleBackColor = false;
            this.btn_TestProfile.Click += new System.EventHandler(this.btn_TestLogin_Click);
            // 
            // btn_TestRegister
            // 
            this.btn_TestRegister.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TestRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestRegister.Location = new System.Drawing.Point(175, 498);
            this.btn_TestRegister.Name = "btn_TestRegister";
            this.btn_TestRegister.Size = new System.Drawing.Size(138, 34);
            this.btn_TestRegister.TabIndex = 1;
            this.btn_TestRegister.Text = "Test Đăng Ký";
            this.btn_TestRegister.UseVisualStyleBackColor = false;
            this.btn_TestRegister.Click += new System.EventHandler(this.btn_TestRegister_Click);
            // 
            // btn_testbooking
            // 
            this.btn_testbooking.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_testbooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testbooking.Location = new System.Drawing.Point(313, 498);
            this.btn_testbooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_testbooking.Name = "btn_testbooking";
            this.btn_testbooking.Size = new System.Drawing.Size(138, 34);
            this.btn_testbooking.TabIndex = 2;
            this.btn_testbooking.Text = "Test Đặt Bàn";
            this.btn_testbooking.UseVisualStyleBackColor = false;
            this.btn_testbooking.Click += new System.EventHandler(this.btn_testbooking_Click);
            // 
            // btn_testfoodorder
            // 
            this.btn_testfoodorder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_testfoodorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testfoodorder.Location = new System.Drawing.Point(450, 498);
            this.btn_testfoodorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_testfoodorder.Name = "btn_testfoodorder";
            this.btn_testfoodorder.Size = new System.Drawing.Size(138, 34);
            this.btn_testfoodorder.TabIndex = 3;
            this.btn_testfoodorder.Text = "Test Đặt Món";
            this.btn_testfoodorder.UseVisualStyleBackColor = false;
            this.btn_testfoodorder.Click += new System.EventHandler(this.btn_testfoodorder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(901, 553);
            this.Controls.Add(this.btn_testfoodorder);
            this.Controls.Add(this.btn_testbooking);
            this.Controls.Add(this.btn_TestRegister);
            this.Controls.Add(this.btn_TestProfile);
            this.Controls.Add(this.btn_TestServices);
            this.Controls.Add(this.btn_TestLogin);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form lệnh test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TestLogin;
        private System.Windows.Forms.Button btn_TestServices;
        private System.Windows.Forms.Button btn_TestProfile;
        private System.Windows.Forms.Button btn_TestRegister;
        private System.Windows.Forms.Button btn_testbooking;
        private System.Windows.Forms.Button btn_testfoodorder;
    }
}

