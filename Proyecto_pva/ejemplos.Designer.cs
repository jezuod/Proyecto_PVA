
namespace Proyecto_pva
{
    partial class ejemplos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejemplos));
            this.bicicletaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicicletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myBikeDataSet1 = new Proyecto_pva.myBikeDataSet();
            this.myBikeDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bicicletaTableAdapter = new Proyecto_pva.myBikeDataSetTableAdapters.BicicletaTableAdapter();
            this.tableAdapterManager = new Proyecto_pva.myBikeDataSetTableAdapters.TableAdapterManager();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bicicletaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBikeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBikeDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bicicletaDataGridView
            // 
            this.bicicletaDataGridView.AllowUserToAddRows = false;
            this.bicicletaDataGridView.AllowUserToDeleteRows = false;
            this.bicicletaDataGridView.AutoGenerateColumns = false;
            this.bicicletaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bicicletaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.bicicletaDataGridView.DataSource = this.bicicletaBindingSource;
            this.bicicletaDataGridView.Location = new System.Drawing.Point(0, 1);
            this.bicicletaDataGridView.Name = "bicicletaDataGridView";
            this.bicicletaDataGridView.ReadOnly = true;
            this.bicicletaDataGridView.Size = new System.Drawing.Size(946, 220);
            this.bicicletaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_bicicleta";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_bicicleta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn2.HeaderText = "precio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "plantilla";
            this.dataGridViewCheckBoxColumn1.HeaderText = "plantilla";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_user";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_user";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_cuadro";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_cuadro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_grupo";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_grupo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_rueda";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_rueda";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_sillin";
            this.dataGridViewTextBoxColumn7.HeaderText = "id_sillin";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_pedal";
            this.dataGridViewTextBoxColumn8.HeaderText = "id_pedal";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // bicicletaBindingSource
            // 
            this.bicicletaBindingSource.DataMember = "Bicicleta";
            this.bicicletaBindingSource.DataSource = this.myBikeDataSet1;
            // 
            // myBikeDataSet1
            // 
            this.myBikeDataSet1.DataSetName = "myBikeDataSet";
            this.myBikeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myBikeDataSet1BindingSource
            // 
            this.myBikeDataSet1BindingSource.DataSource = this.myBikeDataSet1;
            this.myBikeDataSet1BindingSource.Position = 0;
            // 
            // bicicletaTableAdapter
            // 
            this.bicicletaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BicicletaTableAdapter = this.bicicletaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proyecto_pva.myBikeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(828, 227);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(118, 38);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.Text = "Duplicar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona la fila a replicar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ejemplos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_pva.Properties.Resources._26ba2c9f2bc4cf044c3c46353129a917;
            this.ClientSize = new System.Drawing.Size(945, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.bicicletaDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ejemplos";
            this.Text = "ejemplos";
            this.Load += new System.EventHandler(this.ejemplos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bicicletaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBikeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBikeDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myBikeDataSet myBikeDataSet1;
        private System.Windows.Forms.BindingSource myBikeDataSet1BindingSource;
        private System.Windows.Forms.BindingSource bicicletaBindingSource;
        private myBikeDataSetTableAdapters.BicicletaTableAdapter bicicletaTableAdapter;
        private myBikeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bicicletaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label label1;
    }
}