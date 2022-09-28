
namespace Proyecto_pva
{
    partial class Form_registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_registro));
            this.label1 = new System.Windows.Forms.Label();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_pass_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_pass_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_registro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario :";
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(109, 6);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(100, 20);
            this.txb_usuario.TabIndex = 1;
            // 
            // txb_pass_1
            // 
            this.txb_pass_1.Location = new System.Drawing.Point(109, 32);
            this.txb_pass_1.Name = "txb_pass_1";
            this.txb_pass_1.PasswordChar = '*';
            this.txb_pass_1.Size = new System.Drawing.Size(100, 20);
            this.txb_pass_1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña :";
            // 
            // txb_pass_2
            // 
            this.txb_pass_2.Location = new System.Drawing.Point(109, 58);
            this.txb_pass_2.Name = "txb_pass_2";
            this.txb_pass_2.PasswordChar = '*';
            this.txb_pass_2.Size = new System.Drawing.Size(100, 20);
            this.txb_pass_2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repita contraseña :";
            // 
            // btn_registro
            // 
            this.btn_registro.Location = new System.Drawing.Point(109, 84);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(100, 21);
            this.btn_registro.TabIndex = 6;
            this.btn_registro.Text = "Registrarse";
            this.btn_registro.UseVisualStyleBackColor = true;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // Form_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_pva.Properties.Resources.depositphotos_9808899_stock_photo_silver_gray_background_300x194;
            this.ClientSize = new System.Drawing.Size(236, 115);
            this.Controls.Add(this.btn_registro);
            this.Controls.Add(this.txb_pass_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_pass_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_pass_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_pass_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_registro;
    }
}