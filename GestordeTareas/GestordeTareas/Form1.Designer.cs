namespace GestordeTareas
{
    partial class cmbEstado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBienvenida = new System.Windows.Forms.Label();
            this.btnNombre = new System.Windows.Forms.Label();
            this.btnFecha = new System.Windows.Forms.Label();
            this.btnDescripcion = new System.Windows.Forms.Label();
            this.btnLugar = new System.Windows.Forms.Label();
            this.btnCodigo = new System.Windows.Forms.Label();
            this.btnEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrarTareas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBienvenida
            // 
            this.btnBienvenida.AutoSize = true;
            this.btnBienvenida.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBienvenida.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBienvenida.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBienvenida.Location = new System.Drawing.Point(265, 21);
            this.btnBienvenida.Name = "btnBienvenida";
            this.btnBienvenida.Size = new System.Drawing.Size(465, 32);
            this.btnBienvenida.TabIndex = 0;
            this.btnBienvenida.Text = "BIENVENIDO AL GESTOR DE TAREAS";
            this.btnBienvenida.Click += new System.EventHandler(this.btnBienvenida_Click);
            // 
            // btnNombre
            // 
            this.btnNombre.AutoSize = true;
            this.btnNombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNombre.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNombre.Location = new System.Drawing.Point(142, 89);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(89, 23);
            this.btnNombre.TabIndex = 1;
            this.btnNombre.Text = "NOMBRE";
            // 
            // btnFecha
            // 
            this.btnFecha.AutoSize = true;
            this.btnFecha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFecha.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecha.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFecha.Location = new System.Drawing.Point(426, 89);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(228, 23);
            this.btnFecha.TabIndex = 2;
            this.btnFecha.Text = "FECHA DE REALIZACION";
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.AutoSize = true;
            this.btnDescripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDescripcion.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDescripcion.Location = new System.Drawing.Point(252, 89);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(140, 23);
            this.btnDescripcion.TabIndex = 3;
            this.btnDescripcion.Text = "DESCRIPCION";
            // 
            // btnLugar
            // 
            this.btnLugar.AutoSize = true;
            this.btnLugar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLugar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLugar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLugar.Location = new System.Drawing.Point(693, 89);
            this.btnLugar.Name = "btnLugar";
            this.btnLugar.Size = new System.Drawing.Size(71, 23);
            this.btnLugar.TabIndex = 4;
            this.btnLugar.Text = "LUGAR";
            // 
            // btnCodigo
            // 
            this.btnCodigo.AutoSize = true;
            this.btnCodigo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCodigo.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCodigo.Location = new System.Drawing.Point(12, 89);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(85, 23);
            this.btnCodigo.TabIndex = 5;
            this.btnCodigo.Text = "CODIGO";
            // 
            // btnEstado
            // 
            this.btnEstado.AutoSize = true;
            this.btnEstado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEstado.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEstado.Location = new System.Drawing.Point(850, 89);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(83, 23);
            this.btnEstado.TabIndex = 6;
            this.btnEstado.Text = "ESTADO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(9, 133);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(686, 133);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(88, 20);
            this.txtLugar.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(246, 115);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(146, 59);
            this.txtDescripcion.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 133);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(88, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(28, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(173, 58);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "AGREGAR TAREA";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Location = new System.Drawing.Point(228, 192);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(173, 56);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "EDITAR TAREA";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(418, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 55);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "ELIMINAR TAREA";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Items.AddRange(new object[] {
            "",
            "NO REALIZADA",
            "EN PROCESO",
            "TERMINADA"});
            this.cmb_Estado.Location = new System.Drawing.Point(792, 132);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(196, 21);
            this.cmb_Estado.TabIndex = 16;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Fecha,
            this.Lugar,
            this.Estado});
            this.dgvTareas.Location = new System.Drawing.Point(16, 328);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(972, 185);
            this.dgvTareas.TabIndex = 17;
            this.dgvTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(430, 133);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(194, 20);
            this.dtpFecha.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(620, 192);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(173, 56);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "BUSCAR TAREA";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMostrarTareas
            // 
            this.btnMostrarTareas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarTareas.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTareas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrarTareas.Location = new System.Drawing.Point(815, 193);
            this.btnMostrarTareas.Name = "btnMostrarTareas";
            this.btnMostrarTareas.Size = new System.Drawing.Size(173, 56);
            this.btnMostrarTareas.TabIndex = 20;
            this.btnMostrarTareas.Text = "MOSTRAR TAREAS";
            this.btnMostrarTareas.UseVisualStyleBackColor = false;
            this.btnMostrarTareas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // cmbEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 525);
            this.Controls.Add(this.btnMostrarTareas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnCodigo);
            this.Controls.Add(this.btnLugar);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.btnBienvenida);
            this.Name = "cmbEstado";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnBienvenida;
        private System.Windows.Forms.Label btnNombre;
        private System.Windows.Forms.Label btnFecha;
        private System.Windows.Forms.Label btnDescripcion;
        private System.Windows.Forms.Label btnLugar;
        private System.Windows.Forms.Label btnCodigo;
        private System.Windows.Forms.Label btnEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}

