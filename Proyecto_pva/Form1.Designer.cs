
namespace Proyecto_pva
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.lbl_user = new System.Windows.Forms.Label();
            this.txb_user = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.link_lbl_about = new System.Windows.Forms.LinkLabel();
            this.lbl_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_user.Location = new System.Drawing.Point(0, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(460, 13);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "Usuario";
            this.lbl_user.Click += new System.EventHandler(this.label1_Click);
            // 
            // txb_user
            // 
            this.txb_user.Location = new System.Drawing.Point(3, 16);
            this.txb_user.Name = "txb_user";
            this.txb_user.Size = new System.Drawing.Size(282, 20);
            this.txb_user.TabIndex = 2;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(3, 66);
            this.txb_password.Name = "txb_password";
            this.txb_password.PasswordChar = '*';
            this.txb_password.Size = new System.Drawing.Size(282, 20);
            this.txb_password.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(310, 55);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(63, 32);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(379, 55);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(78, 32);
            this.btn_registrar.TabIndex = 7;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // link_lbl_about
            // 
            this.link_lbl_about.AutoSize = true;
            this.link_lbl_about.Location = new System.Drawing.Point(322, 22);
            this.link_lbl_about.Name = "link_lbl_about";
            this.link_lbl_about.Size = new System.Drawing.Size(97, 13);
            this.link_lbl_about.TabIndex = 8;
            this.link_lbl_about.TabStop = true;
            this.link_lbl_about.Text = "Sobre la aplicación";
            this.link_lbl_about.Click += new System.EventHandler(this.link_lbl_about_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_password.Image = global::Proyecto_pva.Properties.Resources.bicycle_2169135_1819011;
            this.lbl_password.Location = new System.Drawing.Point(0, 13);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(460, 86);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Contraseña";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Proyecto_pva.Properties.Resources.depositphotos_9808899_stock_photo_silver_gray_background_300x194;
            this.ClientSize = new System.Drawing.Size(460, 99);
            this.Controls.Add(this.link_lbl_about);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_user);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBike";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txb_user;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.LinkLabel link_lbl_about;
    }
}

