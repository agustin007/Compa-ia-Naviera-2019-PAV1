namespace Compania_naviera.Presentacion.Operaciones.Viaje
{
    partial class frm_alta_viaje
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cmb_tripulacion = new System.Windows.Forms.ComboBox();
            this.dgv_asignacion = new System.Windows.Forms.DataGridView();
            this.cmb_navio = new System.Windows.Forms.ComboBox();
            this.cmb_itinerario = new System.Windows.Forms.ComboBox();
            this.txt_duracion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_viaje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgv_asignacion);
            this.groupBox1.Controls.Add(this.cmb_navio);
            this.groupBox1.Controls.Add(this.cmb_itinerario);
            this.groupBox1.Controls.Add(this.txt_duracion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_viaje);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viaje";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.cmb_tripulacion);
            this.groupBox2.Location = new System.Drawing.Point(30, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 61);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignar tripulacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tripulacion:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::Compania_naviera.Properties.Resources.btn_agregar;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Location = new System.Drawing.Point(318, 9);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(44, 44);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // cmb_tripulacion
            // 
            this.cmb_tripulacion.FormattingEnabled = true;
            this.cmb_tripulacion.Location = new System.Drawing.Point(86, 22);
            this.cmb_tripulacion.Name = "cmb_tripulacion";
            this.cmb_tripulacion.Size = new System.Drawing.Size(130, 21);
            this.cmb_tripulacion.TabIndex = 4;
            // 
            // dgv_asignacion
            // 
            this.dgv_asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asignacion.Location = new System.Drawing.Point(30, 194);
            this.dgv_asignacion.Name = "dgv_asignacion";
            this.dgv_asignacion.Size = new System.Drawing.Size(376, 131);
            this.dgv_asignacion.TabIndex = 8;
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
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(373, 393);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(85, 31);
            this.btn_aceptar.TabIndex = 10;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(272, 393);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(85, 31);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // frm_alta_viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Compania_naviera.Properties.Resources.fondo_viajes3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 446);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_alta_viaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_alta_viaje";
            this.Load += new System.EventHandler(this.Frm_alta_viaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_navio;
        private System.Windows.Forms.ComboBox cmb_itinerario;
        private System.Windows.Forms.TextBox txt_duracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_viaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cmb_tripulacion;
        private System.Windows.Forms.DataGridView dgv_asignacion;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}