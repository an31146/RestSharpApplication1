namespace RestSharpApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMethod = new System.Windows.Forms.ComboBox();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listResponse = new System.Windows.Forms.ListBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboResource = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "https://";
            // 
            // textServer
            // 
            this.textServer.Font = new System.Drawing.Font("Arial", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textServer.Location = new System.Drawing.Point(220, 51);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(466, 39);
            this.textServer.TabIndex = 1;
            this.textServer.TextChanged += new System.EventHandler(this.textServer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "userid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "password:";
            // 
            // comboMethod
            // 
            this.comboMethod.Font = new System.Drawing.Font("Arial", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMethod.FormattingEnabled = true;
            this.comboMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE",
            "PATCH"});
            this.comboMethod.Location = new System.Drawing.Point(1684, 50);
            this.comboMethod.Name = "comboMethod";
            this.comboMethod.Size = new System.Drawing.Size(170, 40);
            this.comboMethod.TabIndex = 5;
            this.comboMethod.Text = "PUT";
            this.comboMethod.SelectedIndexChanged += new System.EventHandler(this.comboMethod_SelectedIndexChanged);
            // 
            // textUserID
            // 
            this.textUserID.Font = new System.Drawing.Font("Arial", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserID.Location = new System.Drawing.Point(220, 116);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(229, 39);
            this.textUserID.TabIndex = 6;
            this.textUserID.TextChanged += new System.EventHandler(this.textUserID_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Arial", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(220, 184);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '●';
            this.textPassword.Size = new System.Drawing.Size(229, 39);
            this.textPassword.TabIndex = 7;
            this.textPassword.UseSystemPasswordChar = true;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(1684, 187);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(170, 56);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "E&xecute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1708, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Server / Hostname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(692, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1094, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Resource";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(891, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "Response";
            // 
            // listResponse
            // 
            this.listResponse.Font = new System.Drawing.Font("Courier New", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResponse.FormattingEnabled = true;
            this.listResponse.HorizontalScrollbar = true;
            this.listResponse.ItemHeight = 30;
            this.listResponse.Location = new System.Drawing.Point(79, 278);
            this.listResponse.Name = "listResponse";
            this.listResponse.Size = new System.Drawing.Size(1775, 1084);
            this.listResponse.TabIndex = 15;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Arial", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(1684, 118);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(170, 56);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "B&rowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textFileName
            // 
            this.textFileName.Font = new System.Drawing.Font("Arial", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFileName.Location = new System.Drawing.Point(727, 120);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(938, 39);
            this.textFileName.TabIndex = 17;
            this.textFileName.Text = "%userprofile%\\Documents";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(589, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "filename:";
            // 
            // comboResource
            // 
            this.comboResource.Font = new System.Drawing.Font("Arial", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboResource.FormattingEnabled = true;
            this.comboResource.Items.AddRange(new object[] {
            "api/v1/session/login",
            "api/v1/documents/search?custom1={id}&type=ACROBAT",
            "api/v1/documents/{id}/download",
            "api/v1/workspaces/search?custom1={id}&wstype=workspace",
            "api/v1/users/search?query=*",
            "api/v1/groups/search?query=*",
            "Mobility2/MobilityService.svc/MyMatters",
            "Mobility2/MobilityService.svc/Top"});
            this.comboResource.Location = new System.Drawing.Point(721, 50);
            this.comboResource.Name = "comboResource";
            this.comboResource.Size = new System.Drawing.Size(944, 40);
            this.comboResource.TabIndex = 19;
            this.comboResource.Text = "api/v1/session/login";
            this.comboResource.SelectedIndexChanged += new System.EventHandler(this.comboResource_SelectedIndexChanged);
            this.comboResource.TextUpdate += new System.EventHandler(this.comboResource_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1933, 1465);
            this.Controls.Add(this.comboResource);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.listResponse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUserID);
            this.Controls.Add(this.comboMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textServer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RestSharpApplication1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMethod;
        private System.Windows.Forms.TextBox textUserID;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listResponse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboResource;
    }
}

