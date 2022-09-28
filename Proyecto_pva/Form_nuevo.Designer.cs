
namespace Proyecto_pva
{
    partial class Form_nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_nuevo));
            this.cb_marca_cuadro = new System.Windows.Forms.ComboBox();
            this.cb_modelo_cuadro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_precio_cuadro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_precio_grupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_marca_grupo = new System.Windows.Forms.ComboBox();
            this.cb_modelo_grupo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_precio_ruedas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_marca_ruedas = new System.Windows.Forms.ComboBox();
            this.cb_modelo_ruedas = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txb_precio_sillin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_marca_sillin = new System.Windows.Forms.ComboBox();
            this.cb_modelo_sillin = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txb_precio_pedales = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_marca_pedales = new System.Windows.Forms.ComboBox();
            this.cb_modelo_pedales = new System.Windows.Forms.ComboBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_marca_cuadro
            // 
            this.cb_marca_cuadro.FormattingEnabled = true;
            this.cb_marca_cuadro.Location = new System.Drawing.Point(27, 35);
            this.cb_marca_cuadro.Name = "cb_marca_cuadro";
            this.cb_marca_cuadro.Size = new System.Drawing.Size(121, 21);
            this.cb_marca_cuadro.TabIndex = 1;
            this.cb_marca_cuadro.Click += new System.EventHandler(this.cb_marca_cuadro_Click);
            // 
            // cb_modelo_cuadro
            // 
            this.cb_modelo_cuadro.FormattingEnabled = true;
            this.cb_modelo_cuadro.Location = new System.Drawing.Point(154, 35);
            this.cb_modelo_cuadro.Name = "cb_modelo_cuadro";
            this.cb_modelo_cuadro.Size = new System.Drawing.Size(121, 21);
            this.cb_modelo_cuadro.TabIndex = 2;
            this.cb_modelo_cuadro.SelectedIndexChanged += new System.EventHandler(this.cb_modelo_cuadro_SelectedIndexChanged);
            this.cb_modelo_cuadro.Click += new System.EventHandler(this.cb_modelo_cuadro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txb_precio_cuadro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_marca_cuadro);
            this.groupBox1.Controls.Add(this.cb_modelo_cuadro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(510, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuadro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(479, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "€";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Precio :";
            // 
            // txb_precio_cuadro
            // 
            this.txb_precio_cuadro.ForeColor = System.Drawing.Color.Lime;
            this.txb_precio_cuadro.Location = new System.Drawing.Point(373, 36);
            this.txb_precio_cuadro.Name = "txb_precio_cuadro";
            this.txb_precio_cuadro.ReadOnly = true;
            this.txb_precio_cuadro.Size = new System.Drawing.Size(100, 20);
            this.txb_precio_cuadro.TabIndex = 8;
            this.txb_precio_cuadro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marca";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txb_precio_grupo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cb_marca_grupo);
            this.groupBox2.Controls.Add(this.cb_modelo_grupo);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(510, 68);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupo ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(479, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "€";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(302, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Precio :";
            // 
            // txb_precio_grupo
            // 
            this.txb_precio_grupo.ForeColor = System.Drawing.Color.Lime;
            this.txb_precio_grupo.Location = new System.Drawing.Point(373, 36);
            this.txb_precio_grupo.Name = "txb_precio_grupo";
            this.txb_precio_grupo.ReadOnly = true;
            this.txb_precio_grupo.Size = new System.Drawing.Size(100, 20);
            this.txb_precio_grupo.TabIndex = 8;
            this.txb_precio_grupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo";
            // 
            // cb_marca_grupo
            // 
            this.cb_marca_grupo.FormattingEnabled = true;
            this.cb_marca_grupo.Location = new System.Drawing.Point(27, 35);
            this.cb_marca_grupo.Name = "cb_marca_grupo";
            this.cb_marca_grupo.Size = new System.Drawing.Size(121, 21);
            this.cb_marca_grupo.TabIndex = 1;
            this.cb_marca_grupo.Click += new System.EventHandler(this.cb_marca_grupo_Click);
            // 
            // cb_modelo_grupo
            // 
            this.cb_modelo_grupo.FormattingEnabled = true;
            this.cb_modelo_grupo.Location = new System.Drawing.Point(154, 35);
            this.cb_modelo_grupo.Name = "cb_modelo_grupo";
            this.cb_modelo_grupo.Size = new System.Drawing.Size(121, 21);
            this.cb_modelo_grupo.TabIndex = 2;
            this.cb_modelo_grupo.SelectedIndexChanged += new System.EventHandler(this.cb_modelo_grupo_SelectedIndexChanged);
            this.cb_modelo_grupo.Click += new System.EventHandler(this.cb_modelo_grupo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txb_precio_ruedas);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cb_marca_ruedas);
            this.groupBox3.Controls.Add(this.cb_modelo_ruedas);
            this.groupBox3.Location = new System.Drawing.Point(12, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(510, 68);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ruedas";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(479, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "€";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(302, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Precio :";
            // 
            // txb_precio_ruedas
            // 
            this.txb_precio_ruedas.ForeColor = System.Drawing.Color.Lime;
            this.txb_precio_ruedas.Location = new System.Drawing.Point(373, 36);
            this.txb_precio_ruedas.Name = "txb_precio_ruedas";
            this.txb_precio_ruedas.ReadOnly = true;
            this.txb_precio_ruedas.Size = new System.Drawing.Size(100, 20);
            this.txb_precio_ruedas.TabIndex = 8;
            this.txb_precio_ruedas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Modelo";
            // 
            // cb_marca_ruedas
            // 
            this.cb_marca_ruedas.FormattingEnabled = true;
            this.cb_marca_ruedas.Location = new System.Drawing.Point(27, 35);
            this.cb_marca_ruedas.Name = "cb_marca_ruedas";
            this.cb_marca_ruedas.Size = new System.Drawing.Size(121, 21);
            this.cb_marca_ruedas.TabIndex = 1;
            this.cb_marca_ruedas.SelectedIndexChanged += new System.EventHandler(this.cb_marca_ruedas_SelectedIndexChanged);
            this.cb_marca_ruedas.Click += new System.EventHandler(this.cb_marca_ruedas_Click);
            // 
            // cb_modelo_ruedas
            // 
            this.cb_modelo_ruedas.FormattingEnabled = true;
            this.cb_modelo_ruedas.Location = new System.Drawing.Point(154, 35);
            this.cb_modelo_ruedas.Name = "cb_modelo_ruedas";
            this.cb_modelo_ruedas.Size = new System.Drawing.Size(121, 21);
            this.cb_modelo_ruedas.TabIndex = 2;
            this.cb_modelo_ruedas.SelectedIndexChanged += new System.EventHandler(this.cb_modelo_ruedas_SelectedIndexChanged);
            this.cb_modelo_ruedas.Click += new System.EventHandler(this.cb_modelo_ruedas_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txb_precio_sillin);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cb_marca_sillin);
            this.groupBox4.Controls.Add(this.cb_modelo_sillin);
            this.groupBox4.Location = new System.Drawing.Point(12, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(510, 68);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sillín";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(479, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "€";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(302, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Precio :";
            // 
            // txb_precio_sillin
            // 
            this.txb_precio_sillin.ForeColor = System.Drawing.Color.Lime;
            this.txb_precio_sillin.Location = new System.Drawing.Point(373, 36);
            this.txb_precio_sillin.Name = "txb_precio_sillin";
            this.txb_precio_sillin.ReadOnly = true;
            this.txb_precio_sillin.Size = new System.Drawing.Size(100, 20);
            this.txb_precio_sillin.TabIndex = 8;
            this.txb_precio_sillin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Modelo";
            // 
            // cb_marca_sillin
            // 
            this.cb_marca_sillin.FormattingEnabled = true;
            this.cb_marca_sillin.Location = new System.Drawing.Point(27, 35);
            this.cb_marca_sillin.Name = "cb_marca_sillin";
            this.cb_marca_sillin.Size = new System.Drawing.Size(121, 21);
            this.cb_marca_sillin.TabIndex = 1;
            this.cb_marca_sillin.SelectedIndexChanged += new System.EventHandler(this.cb_marca_sillin_SelectedIndexChanged);
            this.cb_marca_sillin.Click += new System.EventHandler(this.cb_marca_sillin_Click);
            // 
            // cb_modelo_sillin
            // 
            this.cb_modelo_sillin.FormattingEnabled = true;
            this.cb_modelo_sillin.Location = new System.Drawing.Point(154, 35);
            this.cb_modelo_sillin.Name = "cb_modelo_sillin";
            this.cb_modelo_sillin.Size = new System.Drawing.Size(121, 21);
            this.cb_modelo_sillin.TabIndex = 2;
            this.cb_modelo_sillin.SelectedIndexChanged += new System.EventHandler(this.cb_modelo_sillin_SelectedIndexChanged);
            this.cb_modelo_sillin.Click += new System.EventHandler(this.cb_modelo_sillin_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txb_precio_pedales);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.cb_marca_pedales);
            this.groupBox5.Controls.Add(this.cb_modelo_pedales);
            this.groupBox5.Location = new System.Drawing.Point(12, 308);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(510, 68);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pedales";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(479, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "€";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(302, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Precio :";
            // 
            // txb_precio_pedales
            // 
            this.txb_precio_pedales.ForeColor = System.Drawing.Color.Lime;
            this.txb_precio_pedales.Location = new System.Drawing.Point(373, 36);
            this.txb_precio_pedales.Name = "txb_precio_pedales";
            this.txb_precio_pedales.ReadOnly = true;
            this.txb_precio_pedales.Size = new System.Drawing.Size(100, 20);
            this.txb_precio_pedales.TabIndex = 8;
            this.txb_precio_pedales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Marca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Modelo";
            // 
            // cb_marca_pedales
            // 
            this.cb_marca_pedales.FormattingEnabled = true;
            this.cb_marca_pedales.Location = new System.Drawing.Point(27, 35);
            this.cb_marca_pedales.Name = "cb_marca_pedales";
            this.cb_marca_pedales.Size = new System.Drawing.Size(121, 21);
            this.cb_marca_pedales.TabIndex = 1;
            this.cb_marca_pedales.Click += new System.EventHandler(this.cb_marca_pedales_Click);
            // 
            // cb_modelo_pedales
            // 
            this.cb_modelo_pedales.FormattingEnabled = true;
            this.cb_modelo_pedales.Location = new System.Drawing.Point(154, 35);
            this.cb_modelo_pedales.Name = "cb_modelo_pedales";
            this.cb_modelo_pedales.Size = new System.Drawing.Size(121, 21);
            this.cb_modelo_pedales.TabIndex = 2;
            this.cb_modelo_pedales.SelectedIndexChanged += new System.EventHandler(this.cb_modelo_pedales_SelectedIndexChanged);
            this.cb_modelo_pedales.Click += new System.EventHandler(this.cb_modelo_pedales_Click);
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_enviar.Location = new System.Drawing.Point(39, 382);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(121, 23);
            this.btn_enviar.TabIndex = 13;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // Form_nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_pva.Properties.Resources.bicycle_2169135_1819011;
            this.ClientSize = new System.Drawing.Size(557, 408);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBike";
            this.Load += new System.EventHandler(this.Form_nuevo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_marca_cuadro;
        private System.Windows.Forms.ComboBox cb_modelo_cuadro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_precio_cuadro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txb_precio_grupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_marca_grupo;
        private System.Windows.Forms.ComboBox cb_modelo_grupo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txb_precio_ruedas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_marca_ruedas;
        private System.Windows.Forms.ComboBox cb_modelo_ruedas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txb_precio_sillin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_marca_sillin;
        private System.Windows.Forms.ComboBox cb_modelo_sillin;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txb_precio_pedales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_marca_pedales;
        private System.Windows.Forms.ComboBox cb_modelo_pedales;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}