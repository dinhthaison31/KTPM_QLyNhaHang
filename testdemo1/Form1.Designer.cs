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
            this.btn_TestTable = new System.Windows.Forms.Button();
            this.btn_TestOrder = new System.Windows.Forms.Button();
            this.btn_TestServices = new System.Windows.Forms.Button();
            this.btn_TestProfile = new System.Windows.Forms.Button();
            this.btn_TestRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_TestLogin
            // 
            this.btn_TestLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestLogin.Location = new System.Drawing.Point(39, 47);
            this.btn_TestLogin.Name = "btn_TestLogin";
            this.btn_TestLogin.Size = new System.Drawing.Size(154, 45);
            this.btn_TestLogin.TabIndex = 0;
            this.btn_TestLogin.Text = "Test Đăng Nhập";
            this.btn_TestLogin.UseVisualStyleBackColor = true;
            this.btn_TestLogin.Click += new System.EventHandler(this.btn_TestLogin_Click);
            // 
            // btn_TestTable
            // 
            this.btn_TestTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestTable.Location = new System.Drawing.Point(39, 251);
            this.btn_TestTable.Name = "btn_TestTable";
            this.btn_TestTable.Size = new System.Drawing.Size(154, 45);
            this.btn_TestTable.TabIndex = 0;
            this.btn_TestTable.Text = "Test Đặt bàn";
            this.btn_TestTable.UseVisualStyleBackColor = true;
            this.btn_TestTable.Click += new System.EventHandler(this.btn_TestLogin_Click);
            // 
            // btn_TestOrder
            // 
            this.btn_TestOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestOrder.Location = new System.Drawing.Point(39, 200);
            this.btn_TestOrder.Name = "btn_TestOrder";
            this.btn_TestOrder.Size = new System.Drawing.Size(154, 45);
            this.btn_TestOrder.TabIndex = 0;
            this.btn_TestOrder.Text = "Test Đặt món";
            this.btn_TestOrder.UseVisualStyleBackColor = true;
            this.btn_TestOrder.Click += new System.EventHandler(this.btn_TestLogin_Click);
            // 
            // btn_TestServices
            // 
            this.btn_TestServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestServices.Location = new System.Drawing.Point(39, 149);
            this.btn_TestServices.Name = "btn_TestServices";
            this.btn_TestServices.Size = new System.Drawing.Size(154, 45);
            this.btn_TestServices.TabIndex = 0;
            this.btn_TestServices.Text = "Test Dịch Vụ";
            this.btn_TestServices.UseVisualStyleBackColor = true;
            this.btn_TestServices.Click += new System.EventHandler(this.btn_TestLogin_Click);
            // 
            // btn_TestProfile
            // 
            this.btn_TestProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestProfile.Location = new System.Drawing.Point(39, 302);
            this.btn_TestProfile.Name = "btn_TestProfile";
            this.btn_TestProfile.Size = new System.Drawing.Size(154, 45);
            this.btn_TestProfile.TabIndex = 0;
            this.btn_TestProfile.Text = "Test TTCN";
            this.btn_TestProfile.UseVisualStyleBackColor = true;
            this.btn_TestProfile.Click += new System.EventHandler(this.btn_TestLogin_Click);
            // 
            // btn_TestRegister
            // 
            this.btn_TestRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestRegister.Location = new System.Drawing.Point(39, 98);
            this.btn_TestRegister.Name = "btn_TestRegister";
            this.btn_TestRegister.Size = new System.Drawing.Size(154, 45);
            this.btn_TestRegister.TabIndex = 1;
            this.btn_TestRegister.Text = "Test Đăng Ký";
            this.btn_TestRegister.UseVisualStyleBackColor = true;
            this.btn_TestRegister.Click += new System.EventHandler(this.btn_TestRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_TestRegister);
            this.Controls.Add(this.btn_TestProfile);
            this.Controls.Add(this.btn_TestServices);
            this.Controls.Add(this.btn_TestOrder);
            this.Controls.Add(this.btn_TestTable);
            this.Controls.Add(this.btn_TestLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form lệnh test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TestLogin;
        private System.Windows.Forms.Button btn_TestTable;
        private System.Windows.Forms.Button btn_TestOrder;
        private System.Windows.Forms.Button btn_TestServices;
        private System.Windows.Forms.Button btn_TestProfile;
        private System.Windows.Forms.Button btn_TestRegister;
    }
}

