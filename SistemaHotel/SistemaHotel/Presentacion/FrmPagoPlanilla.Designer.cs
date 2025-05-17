namespace SistemaHotel.Presentacion
{
    partial class FrmPagoPlanilla
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxEstadoPP = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnEdiitar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.dgvCodigoPagoPlanilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodigoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaPagoPlanilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarioSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago Planilla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Pago Planilla";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(38, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Pago Planilla";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(39, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código Empleado";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(164, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(39, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Horas Extras";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(163, 200);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(38, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Usuario Sistema";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(347, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Estado: ";
            // 
            // cboxEstadoPP
            // 
            this.cboxEstadoPP.FormattingEnabled = true;
            this.cboxEstadoPP.Items.AddRange(new object[] {
            "Pendiente",
            "Proceso",
            "Pagado",
            "Rechazado"});
            this.cboxEstadoPP.Location = new System.Drawing.Point(371, 18);
            this.cboxEstadoPP.Name = "cboxEstadoPP";
            this.cboxEstadoPP.Size = new System.Drawing.Size(90, 21);
            this.cboxEstadoPP.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(347, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Salario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(347, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(347, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Monto Total: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(397, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Imprimir dato";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(397, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Imprimir dato";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(423, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Imprimir dato";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdiitar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.DtpFechaVencimiento);
            this.groupBox1.Controls.Add(this.cboxEstadoPP);
            this.groupBox1.Location = new System.Drawing.Point(28, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 181);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // DtpFechaVencimiento
            // 
            this.DtpFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaVencimiento.Location = new System.Drawing.Point(133, 84);
            this.DtpFechaVencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.DtpFechaVencimiento.Name = "DtpFechaVencimiento";
            this.DtpFechaVencimiento.Size = new System.Drawing.Size(102, 21);
            this.DtpFechaVencimiento.TabIndex = 21;
            // 
            // btnEdiitar
            // 
            this.btnEdiitar.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btnEdiitar.IconColor = System.Drawing.Color.Black;
            this.btnEdiitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdiitar.IconSize = 25;
            this.btnEdiitar.Location = new System.Drawing.Point(596, 109);
            this.btnEdiitar.Name = "btnEdiitar";
            this.btnEdiitar.Size = new System.Drawing.Size(110, 36);
            this.btnEdiitar.TabIndex = 24;
            this.btnEdiitar.Text = "Editar";
            this.btnEdiitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdiitar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.Location = new System.Drawing.Point(596, 74);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 36);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(596, 39);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 36);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(617, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(95, 15);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "Imprimir Fecha";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(524, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "Fecha actual:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodigoPagoPlanilla,
            this.dgvCodigoEmpleado,
            this.dgvFechaPagoPlanilla,
            this.dgvSalario,
            this.dgvBono,
            this.dgvHorasExtras,
            this.dgvMontoTotal,
            this.dgvEstado,
            this.dgvUsuarioSistema,
            this.dgvFechaSistema});
            this.dataGridView1.Location = new System.Drawing.Point(24, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 150);
            this.dataGridView1.TabIndex = 35;
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 25;
            this.btnSalir.Location = new System.Drawing.Point(409, 408);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.Location = new System.Drawing.Point(315, 408);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvCodigoPagoPlanilla
            // 
            this.dgvCodigoPagoPlanilla.HeaderText = "Codigo Pago Planilla";
            this.dgvCodigoPagoPlanilla.Name = "dgvCodigoPagoPlanilla";
            // 
            // dgvCodigoEmpleado
            // 
            this.dgvCodigoEmpleado.HeaderText = "Código Empleado";
            this.dgvCodigoEmpleado.Name = "dgvCodigoEmpleado";
            // 
            // dgvFechaPagoPlanilla
            // 
            this.dgvFechaPagoPlanilla.HeaderText = "Fecha Pago Planilla";
            this.dgvFechaPagoPlanilla.Name = "dgvFechaPagoPlanilla";
            // 
            // dgvSalario
            // 
            this.dgvSalario.HeaderText = "Salario";
            this.dgvSalario.Name = "dgvSalario";
            // 
            // dgvBono
            // 
            this.dgvBono.HeaderText = "Bono";
            this.dgvBono.Name = "dgvBono";
            // 
            // dgvHorasExtras
            // 
            this.dgvHorasExtras.HeaderText = "HorasExtras";
            this.dgvHorasExtras.Name = "dgvHorasExtras";
            // 
            // dgvMontoTotal
            // 
            this.dgvMontoTotal.HeaderText = "MontoTotal";
            this.dgvMontoTotal.Name = "dgvMontoTotal";
            // 
            // dgvEstado
            // 
            this.dgvEstado.HeaderText = "Estado";
            this.dgvEstado.Name = "dgvEstado";
            // 
            // dgvUsuarioSistema
            // 
            this.dgvUsuarioSistema.HeaderText = "UsuarioSistema";
            this.dgvUsuarioSistema.Name = "dgvUsuarioSistema";
            // 
            // dgvFechaSistema
            // 
            this.dgvFechaSistema.HeaderText = "Fecha Sistema";
            this.dgvFechaSistema.Name = "dgvFechaSistema";
            // 
            // FrmPagoPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPagoPlanilla";
            this.Text = "FrmPagoPlanilla";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxEstadoPP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnEdiitar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.DateTimePicker DtpFechaVencimiento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoPagoPlanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaPagoPlanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHorasExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarioSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaSistema;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}