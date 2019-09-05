namespace Compania_naviera.Presentacion
{
    partial class frm_navios
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
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_navios = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.Busqueda = new System.Windows.Forms.GroupBox();
            this.codigo_navio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autonomia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desplazamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eslora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_pasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_tripulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_motores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_navios)).BeginInit();
            this.Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo navio:";
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(93, 21);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(121, 20);
            this.txt_cod.TabIndex = 1;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(352, 21);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de navio:";
            // 
            // dgv_navios
            // 
            this.dgv_navios.AllowUserToAddRows = false;
            this.dgv_navios.AllowUserToDeleteRows = false;
            this.dgv_navios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_navios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_navio,
            this.nombre,
            this.altura,
            this.autonomia,
            this.desplazamiento,
            this.eslora,
            this.manga,
            this.cantidad_pasajeros,
            this.cantidad_tripulacion,
            this.tipo_clasificacion,
            this.cantidad_motores});
            this.dgv_navios.Location = new System.Drawing.Point(26, 97);
            this.dgv_navios.Name = "dgv_navios";
            this.dgv_navios.ReadOnly = true;
            this.dgv_navios.Size = new System.Drawing.Size(644, 210);
            this.dgv_navios.TabIndex = 1;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackgroundImage = global::Compania_naviera.Properties.Resources.boton_buscar;
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultar.Location = new System.Drawing.Point(576, 11);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(51, 47);
            this.btn_consultar.TabIndex = 4;
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::Compania_naviera.Properties.Resources.btn_modificar;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(316, 327);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(56, 48);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::Compania_naviera.Properties.Resources.btn_nuevo1;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Location = new System.Drawing.Point(26, 327);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(56, 47);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::Compania_naviera.Properties.Resources.boton_exit;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Location = new System.Drawing.Point(614, 327);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(56, 46);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Busqueda
            // 
            this.Busqueda.Controls.Add(this.btn_consultar);
            this.Busqueda.Controls.Add(this.label1);
            this.Busqueda.Controls.Add(this.label2);
            this.Busqueda.Controls.Add(this.txt_cod);
            this.Busqueda.Controls.Add(this.cmb_tipo);
            this.Busqueda.Location = new System.Drawing.Point(26, 27);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(644, 64);
            this.Busqueda.TabIndex = 0;
            this.Busqueda.TabStop = false;
            this.Busqueda.Text = "Busqueda";
            // 
            // codigo_navio
            // 
            this.codigo_navio.HeaderText = "Codigo";
            this.codigo_navio.Name = "codigo_navio";
            this.codigo_navio.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // altura
            // 
            this.altura.HeaderText = "Altura";
            this.altura.Name = "altura";
            this.altura.ReadOnly = true;
            // 
            // autonomia
            // 
            this.autonomia.HeaderText = "Autonomia";
            this.autonomia.Name = "autonomia";
            this.autonomia.ReadOnly = true;
            // 
            // desplazamiento
            // 
            this.desplazamiento.HeaderText = "Desplazamiento";
            this.desplazamiento.Name = "desplazamiento";
            this.desplazamiento.ReadOnly = true;
            // 
            // eslora
            // 
            this.eslora.HeaderText = "Eslora";
            this.eslora.Name = "eslora";
            this.eslora.ReadOnly = true;
            // 
            // manga
            // 
            this.manga.HeaderText = "Manga";
            this.manga.Name = "manga";
            this.manga.ReadOnly = true;
            // 
            // cantidad_pasajeros
            // 
            this.cantidad_pasajeros.HeaderText = "Cantidad Pasajeros";
            this.cantidad_pasajeros.Name = "cantidad_pasajeros";
            this.cantidad_pasajeros.ReadOnly = true;
            // 
            // cantidad_tripulacion
            // 
            this.cantidad_tripulacion.HeaderText = "Cantidad Tripulacion";
            this.cantidad_tripulacion.Name = "cantidad_tripulacion";
            this.cantidad_tripulacion.ReadOnly = true;
            // 
            // tipo_clasificacion
            // 
            this.tipo_clasificacion.HeaderText = "Clasificacion";
            this.tipo_clasificacion.Name = "tipo_clasificacion";
            this.tipo_clasificacion.ReadOnly = true;
            // 
            // cantidad_motores
            // 
            this.cantidad_motores.HeaderText = "Motores";
            this.cantidad_motores.Name = "cantidad_motores";
            this.cantidad_motores.ReadOnly = true;
            // 
            // frm_navios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Compania_naviera.Properties.Resources.navio;
            this.ClientSize = new System.Drawing.Size(707, 384);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_navios);
            this.Name = "frm_navios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta_navios";
            this.Load += new System.EventHandler(this.Navios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_navios)).EndInit();
            this.Busqueda.ResumeLayout(false);
            this.Busqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_navios;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox Busqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_navio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn autonomia;
        private System.Windows.Forms.DataGridViewTextBoxColumn desplazamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn eslora;
        private System.Windows.Forms.DataGridViewTextBoxColumn manga;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_pasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_tripulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_clasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_motores;
    }
}