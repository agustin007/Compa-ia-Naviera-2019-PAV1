﻿namespace Compania_naviera.Presentacion.Operaciones.Viaje
{
    partial class frm_viaje
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
            this.cmb_navio = new System.Windows.Forms.ComboBox();
            this.cmb_itinerario = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_duracion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_viaje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_viajes = new System.Windows.Forms.DataGridView();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_detalle = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viajes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_navio);
            this.groupBox1.Controls.Add(this.cmb_itinerario);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_duracion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_viaje);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viaje";
            // 
            // cmb_navio
            // 
            this.cmb_navio.FormattingEnabled = true;
            this.cmb_navio.Location = new System.Drawing.Point(113, 66);
            this.cmb_navio.Name = "cmb_navio";
            this.cmb_navio.Size = new System.Drawing.Size(100, 21);
            this.cmb_navio.TabIndex = 4;
            // 
            // cmb_itinerario
            // 
            this.cmb_itinerario.FormattingEnabled = true;
            this.cmb_itinerario.Location = new System.Drawing.Point(306, 66);
            this.cmb_itinerario.Name = "cmb_itinerario";
            this.cmb_itinerario.Size = new System.Drawing.Size(100, 21);
            this.cmb_itinerario.TabIndex = 3;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::Compania_naviera.Properties.Resources.boton_buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(461, 38);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(45, 44);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // txt_duracion
            // 
            this.txt_duracion.Location = new System.Drawing.Point(306, 30);
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Size = new System.Drawing.Size(100, 20);
            this.txt_duracion.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Itinerario:";
            // 
            // txt_viaje
            // 
            this.txt_viaje.Location = new System.Drawing.Point(113, 30);
            this.txt_viaje.Name = "txt_viaje";
            this.txt_viaje.Size = new System.Drawing.Size(100, 20);
            this.txt_viaje.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Navio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Duracion: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de viaje:";
            // 
            // dgv_viajes
            // 
            this.dgv_viajes.AllowUserToAddRows = false;
            this.dgv_viajes.AllowUserToDeleteRows = false;
            this.dgv_viajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_viajes.Location = new System.Drawing.Point(20, 165);
            this.dgv_viajes.Name = "dgv_viajes";
            this.dgv_viajes.ReadOnly = true;
            this.dgv_viajes.Size = new System.Drawing.Size(528, 158);
            this.dgv_viajes.TabIndex = 1;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::Compania_naviera.Properties.Resources.btn_modificar;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(71, 329);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(45, 44);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::Compania_naviera.Properties.Resources.boton_exit;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Location = new System.Drawing.Point(503, 329);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(45, 44);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // btn_detalle
            // 
            this.btn_detalle.Image = global::Compania_naviera.Properties.Resources.comentar;
            this.btn_detalle.Location = new System.Drawing.Point(299, 329);
            this.btn_detalle.Name = "btn_detalle";
            this.btn_detalle.Size = new System.Drawing.Size(45, 44);
            this.btn_detalle.TabIndex = 2;
            this.btn_detalle.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = global::Compania_naviera.Properties.Resources.btn_nuevo;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(21, 329);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(45, 44);
            this.btn_nuevo.TabIndex = 7;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // frm_viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Compania_naviera.Properties.Resources.fondo_viajes1;
            this.ClientSize = new System.Drawing.Size(573, 392);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_detalle);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_viajes);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_viaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_viaje";
            this.Load += new System.EventHandler(this.Frm_viaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_duracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_viaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_viajes;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_detalle;
        private System.Windows.Forms.ComboBox cmb_navio;
        private System.Windows.Forms.ComboBox cmb_itinerario;
        private System.Windows.Forms.Button btn_nuevo;
    }
}