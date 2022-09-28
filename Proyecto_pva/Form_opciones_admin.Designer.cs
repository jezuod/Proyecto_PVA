
namespace Proyecto_pva
{
    partial class Form_opciones_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_opciones_admin));
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_historico = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_ejemplos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(28, 12);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(141, 20);
            this.btn_nuevo.TabIndex = 3;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_historico
            // 
            this.btn_historico.Location = new System.Drawing.Point(28, 64);
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.Size = new System.Drawing.Size(141, 20);
            this.btn_historico.TabIndex = 6;
            this.btn_historico.Text = "Histórico";
            this.btn_historico.UseVisualStyleBackColor = true;
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(28, 90);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(141, 20);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_ejemplos
            // 
            this.btn_ejemplos.Location = new System.Drawing.Point(28, 38);
            this.btn_ejemplos.Name = "btn_ejemplos";
            this.btn_ejemplos.Size = new System.Drawing.Size(141, 20);
            this.btn_ejemplos.TabIndex = 5;
            this.btn_ejemplos.Text = "Plantillas";
            this.btn_ejemplos.UseVisualStyleBackColor = true;
            this.btn_ejemplos.Click += new System.EventHandler(this.btn_ejemplos_Click);
            // 
            // Form_opciones_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_pva.Properties.Resources.depositphotos_9808899_stock_photo_silver_gray_background_300x194;
            this.ClientSize = new System.Drawing.Size(211, 124);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_historico);
            this.Controls.Add(this.btn_ejemplos);
            this.Controls.Add(this.btn_nuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_opciones_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBike";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_opciones_admin_FormClosed);
            this.Load += new System.EventHandler(this.Form_opciones_admin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_historico;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_ejemplos;
    }
}