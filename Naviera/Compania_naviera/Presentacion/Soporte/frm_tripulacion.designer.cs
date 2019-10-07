namespace Compania_naviera.Presentacion.Soporte
{
    partial class frm_tripulacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_tripulacion = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cmb_puesto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_tripulacion = new System.Windows.Forms.DataGridView();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tripulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_tripulacion);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.cmb_puesto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // chk_tripulacion
            // 
            this.chk_tripulacion.AutoSize = true;
            this.chk_tripulacion.Location = new System.Drawing.Point(280, 68);
            this.chk_tripulacion.Name = "chk_tripulacion";
            this.chk_tripulacion.Size = new System.Drawing.Size(180, 17);
            this.chk_tripulacion.TabIndex = 5;
            this.chk_tripulacion.Text = "Todos incluidos los desabilitados";
            this.chk_tripulacion.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::Compania_naviera.Properties.Resources.boton_buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(374, 15);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(50, 48);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // cmb_puesto
            // 
            this.cmb_puesto.FormattingEnabled = true;
            this.cmb_puesto.Location = new System.Drawing.Point(230, 30);
            this.cmb_puesto.Name = "cmb_puesto";
            this.cmb_puesto.Size = new System.Drawing.Size(121, 21);
            this.cmb_puesto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puesto:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(68, 30);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // dgv_tripulacion
            // 
            this.dgv_tripulacion.AllowUserToAddRows = false;
            this.dgv_tripulacion.AllowUserToDeleteRows = false;
            this.dgv_tripulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tripulacion.Location = new System.Drawing.Point(48, 149);
            this.dgv_tripulacion.Name = "dgv_tripulacion";
            this.dgv_tripulacion.ReadOnly = true;
            this.dgv_tripulacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tripulacion.Size = new System.Drawing.Size(466, 153);
            this.dgv_tripulacion.TabIndex = 1;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = global::Compania_naviera.Properties.Resources.btn_nuevo;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(54, 308);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(50, 48);
            this.btn_nuevo.TabIndex = 2;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::Compania_naviera.Properties.Resources.btn_modificar;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(110, 308);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(50, 48);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = global::Compania_naviera.Properties.Resources.eliminar;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(166, 308);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(50, 48);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::Compania_naviera.Properties.Resources.boton_exit;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Location = new System.Drawing.Point(464, 308);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(50, 48);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // frm_tripulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Compania_naviera.Properties.Resources.fondo_tripulacion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 395);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dgv_tripulacion);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_tripulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_tripulacion";
            this.Load += new System.EventHandler(this.Frm_tripulacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tripulacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox cmb_puesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_tripulacion;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.CheckBox chk_tripulacion;
    }
}