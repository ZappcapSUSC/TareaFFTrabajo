namespace Presentacion
{
    partial class Main
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
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.dgvEmpleadosAsignados = new System.Windows.Forms.DataGridView();
            this.btnNuevaTarea = new System.Windows.Forms.Button();
            this.btnNuevoEmpleado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.txtTareaIDSeleccionada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarTarea = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesasignarEmpleado = new System.Windows.Forms.Button();
            this.btnAsignarEmpleado = new System.Windows.Forms.Button();
            this.dgvEmpleadosLibres = new System.Windows.Forms.DataGridView();
            this.txtEmpleadoIDSeleccionado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvEmpleadosCompletos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosAsignados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosLibres)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosCompletos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTareas
            // 
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(16, 57);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(417, 228);
            this.dgvTareas.TabIndex = 0;
            this.dgvTareas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellDoubleClick);
            this.dgvTareas.SelectionChanged += new System.EventHandler(this.dgvTareas_SelectionChanged);
            // 
            // dgvEmpleadosAsignados
            // 
            this.dgvEmpleadosAsignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleadosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosAsignados.Location = new System.Drawing.Point(38, 57);
            this.dgvEmpleadosAsignados.MultiSelect = false;
            this.dgvEmpleadosAsignados.Name = "dgvEmpleadosAsignados";
            this.dgvEmpleadosAsignados.ReadOnly = true;
            this.dgvEmpleadosAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleadosAsignados.Size = new System.Drawing.Size(230, 228);
            this.dgvEmpleadosAsignados.TabIndex = 1;
            this.dgvEmpleadosAsignados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleadosAsignados_CellDoubleClick);
            // 
            // btnNuevaTarea
            // 
            this.btnNuevaTarea.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevaTarea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNuevaTarea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNuevaTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaTarea.Location = new System.Drawing.Point(16, 312);
            this.btnNuevaTarea.Name = "btnNuevaTarea";
            this.btnNuevaTarea.Size = new System.Drawing.Size(134, 23);
            this.btnNuevaTarea.TabIndex = 2;
            this.btnNuevaTarea.Text = "Nueva Tarea";
            this.btnNuevaTarea.UseVisualStyleBackColor = false;
            this.btnNuevaTarea.Click += new System.EventHandler(this.btnNuevaTarea_Click);
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNuevoEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(272, 321);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(107, 23);
            this.btnNuevoEmpleado.TabIndex = 3;
            this.btnNuevoEmpleado.Text = "Nuevo Empleado";
            this.btnNuevoEmpleado.UseVisualStyleBackColor = false;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarTarea);
            this.groupBox1.Controls.Add(this.txtTareaIDSeleccionada);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnModificarTarea);
            this.groupBox1.Controls.Add(this.dgvTareas);
            this.groupBox1.Controls.Add(this.btnNuevaTarea);
            this.groupBox1.Location = new System.Drawing.Point(18, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 366);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administracion de tareas";
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarTarea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarTarea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTarea.Location = new System.Drawing.Point(330, 312);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(103, 23);
            this.btnEliminarTarea.TabIndex = 4;
            this.btnEliminarTarea.Text = "Eliminar tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // txtTareaIDSeleccionada
            // 
            this.txtTareaIDSeleccionada.Location = new System.Drawing.Point(322, 19);
            this.txtTareaIDSeleccionada.Name = "txtTareaIDSeleccionada";
            this.txtTareaIDSeleccionada.ReadOnly = true;
            this.txtTareaIDSeleccionada.Size = new System.Drawing.Size(111, 20);
            this.txtTareaIDSeleccionada.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Tarea Seleccionada:";
            // 
            // btnModificarTarea
            // 
            this.btnModificarTarea.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificarTarea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificarTarea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModificarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTarea.Location = new System.Drawing.Point(174, 312);
            this.btnModificarTarea.Name = "btnModificarTarea";
            this.btnModificarTarea.Size = new System.Drawing.Size(126, 23);
            this.btnModificarTarea.TabIndex = 3;
            this.btnModificarTarea.Text = "Modificar tarea";
            this.btnModificarTarea.UseVisualStyleBackColor = false;
            this.btnModificarTarea.Click += new System.EventHandler(this.btnModificarTarea_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDesasignarEmpleado);
            this.groupBox2.Controls.Add(this.btnAsignarEmpleado);
            this.groupBox2.Controls.Add(this.dgvEmpleadosLibres);
            this.groupBox2.Controls.Add(this.dgvEmpleadosAsignados);
            this.groupBox2.Location = new System.Drawing.Point(506, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 366);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignacion de empleados";
            // 
            // btnDesasignarEmpleado
            // 
            this.btnDesasignarEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDesasignarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDesasignarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDesasignarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesasignarEmpleado.Location = new System.Drawing.Point(292, 171);
            this.btnDesasignarEmpleado.Name = "btnDesasignarEmpleado";
            this.btnDesasignarEmpleado.Size = new System.Drawing.Size(83, 23);
            this.btnDesasignarEmpleado.TabIndex = 16;
            this.btnDesasignarEmpleado.Text = "Desasignar >";
            this.btnDesasignarEmpleado.UseVisualStyleBackColor = false;
            this.btnDesasignarEmpleado.Click += new System.EventHandler(this.btnDesasignarEmpleado_Click);
            // 
            // btnAsignarEmpleado
            // 
            this.btnAsignarEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAsignarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAsignarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAsignarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarEmpleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAsignarEmpleado.Location = new System.Drawing.Point(292, 127);
            this.btnAsignarEmpleado.Name = "btnAsignarEmpleado";
            this.btnAsignarEmpleado.Size = new System.Drawing.Size(83, 23);
            this.btnAsignarEmpleado.TabIndex = 15;
            this.btnAsignarEmpleado.Text = "< Asignar";
            this.btnAsignarEmpleado.UseVisualStyleBackColor = false;
            this.btnAsignarEmpleado.Click += new System.EventHandler(this.btnAsignarEmpleado_Click);
            // 
            // dgvEmpleadosLibres
            // 
            this.dgvEmpleadosLibres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleadosLibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosLibres.Location = new System.Drawing.Point(400, 57);
            this.dgvEmpleadosLibres.MultiSelect = false;
            this.dgvEmpleadosLibres.Name = "dgvEmpleadosLibres";
            this.dgvEmpleadosLibres.ReadOnly = true;
            this.dgvEmpleadosLibres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleadosLibres.Size = new System.Drawing.Size(235, 228);
            this.dgvEmpleadosLibres.TabIndex = 12;
            this.dgvEmpleadosLibres.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleadosLibres_CellDoubleClick);
            // 
            // txtEmpleadoIDSeleccionado
            // 
            this.txtEmpleadoIDSeleccionado.Location = new System.Drawing.Point(810, 30);
            this.txtEmpleadoIDSeleccionado.Name = "txtEmpleadoIDSeleccionado";
            this.txtEmpleadoIDSeleccionado.ReadOnly = true;
            this.txtEmpleadoIDSeleccionado.Size = new System.Drawing.Size(86, 20);
            this.txtEmpleadoIDSeleccionado.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID empleado(a) seleccionada:";
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(600, 321);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(103, 23);
            this.btnEliminarEmpleado.TabIndex = 11;
            this.btnEliminarEmpleado.Text = "Eliminar empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEmpleado.Location = new System.Drawing.Point(436, 321);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(109, 23);
            this.btnModificarEmpleado.TabIndex = 10;
            this.btnModificarEmpleado.Text = "Modificar empleado";
            this.btnModificarEmpleado.UseVisualStyleBackColor = false;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvEmpleadosCompletos);
            this.groupBox3.Controls.Add(this.btnEliminarEmpleado);
            this.groupBox3.Controls.Add(this.btnModificarEmpleado);
            this.groupBox3.Controls.Add(this.txtEmpleadoIDSeleccionado);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnNuevoEmpleado);
            this.groupBox3.Location = new System.Drawing.Point(107, 446);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(972, 358);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administracion de empleados";
            // 
            // dgvEmpleadosCompletos
            // 
            this.dgvEmpleadosCompletos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleadosCompletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosCompletos.Location = new System.Drawing.Point(272, 76);
            this.dgvEmpleadosCompletos.MultiSelect = false;
            this.dgvEmpleadosCompletos.Name = "dgvEmpleadosCompletos";
            this.dgvEmpleadosCompletos.ReadOnly = true;
            this.dgvEmpleadosCompletos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleadosCompletos.Size = new System.Drawing.Size(431, 217);
            this.dgvEmpleadosCompletos.TabIndex = 15;
            this.dgvEmpleadosCompletos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleadosCompletos_CellDoubleClick);
            this.dgvEmpleadosCompletos.SelectionChanged += new System.EventHandler(this.dgvEmpleadosCompletos_SelectionChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 835);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosAsignados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosLibres)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosCompletos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.DataGridView dgvEmpleadosAsignados;
        private System.Windows.Forms.Button btnNuevaTarea;
        private System.Windows.Forms.Button btnNuevoEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTareaIDSeleccionada;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.Button btnModificarTarea;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleadosLibres;
        private System.Windows.Forms.TextBox txtEmpleadoIDSeleccionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDesasignarEmpleado;
        private System.Windows.Forms.Button btnAsignarEmpleado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvEmpleadosCompletos;
    }
}

