namespace FitSecretProject.Presentation
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            label1 = new Label();
            label2 = new Label();
            btnAdmin = new Button();
            btnUser = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 20F);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(218, 168);
            label1.Name = "label1";
            label1.Size = new Size(390, 45);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Fit Fusion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F);
            label2.ForeColor = Color.Ivory;
            label2.Location = new Point(299, 256);
            label2.Name = "label2";
            label2.Size = new Size(245, 24);
            label2.TabIndex = 1;
            label2.Text = "Choose Your Account Type";
            // 
            // btnAdmin
            // 
            btnAdmin.FlatAppearance.BorderColor = Color.Black;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Popup;
            btnAdmin.Font = new Font("Bahnschrift SemiBold", 12F);
            btnAdmin.ForeColor = Color.Ivory;
            btnAdmin.Location = new Point(118, 456);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(250, 60);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "ADMIN LOGIN";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnUser
            // 
            btnUser.FlatAppearance.BorderColor = Color.Black;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Popup;
            btnUser.Font = new Font("Bahnschrift SemiBold", 12F);
            btnUser.ForeColor = Color.Ivory;
            btnUser.Location = new Point(467, 456);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(250, 60);
            btnUser.TabIndex = 4;
            btnUser.Text = "USER LOGIN";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(795, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 717);
            Controls.Add(pictureBox2);
            Controls.Add(btnAdmin);
            Controls.Add(btnUser);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnAdmin;
        private Button btnUser;
        private PictureBox pictureBox2;
    }
}