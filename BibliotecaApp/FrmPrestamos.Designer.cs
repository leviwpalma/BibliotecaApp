namespace BibliotecaApp
{
    partial class FrmPrestamos
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
            this.dtpPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.Libro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLibrosPrestamo = new System.Windows.Forms.DataGridView();
            this.dgvUsuariosPrestamo = new System.Windows.Forms.DataGridView();
            this.txtBuscarLibro = new System.Windows.Forms.TextBox();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarPrestamo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosPrestamo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpPrestamo
            // 
            this.dtpPrestamo.Location = new System.Drawing.Point(645, 242);
            this.dtpPrestamo.Name = "dtpPrestamo";
            this.dtpPrestamo.Size = new System.Drawing.Size(200, 22);
            this.dtpPrestamo.TabIndex = 1;
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Location = new System.Drawing.Point(645, 323);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(200, 22);
            this.dtpDevolucion.TabIndex = 2;
            // 
            // btnPrestar
            // 
            this.btnPrestar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestar.ForeColor = System.Drawing.Color.White;
            this.btnPrestar.Location = new System.Drawing.Point(631, 111);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(105, 41);
            this.btnPrestar.TabIndex = 3;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = false;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.Orange;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Location = new System.Drawing.Point(742, 111);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(102, 41);
            this.btnDevolver.TabIndex = 4;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPrestamos.Location = new System.Drawing.Point(0, 383);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.Size = new System.Drawing.Size(857, 186);
            this.dgvPrestamos.TabIndex = 5;
            // 
            // Libro
            // 
            this.Libro.AutoSize = true;
            this.Libro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Libro.Location = new System.Drawing.Point(12, 78);
            this.Libro.Name = "Libro";
            this.Libro.Size = new System.Drawing.Size(113, 25);
            this.Libro.TabIndex = 7;
            this.Libro.Text = "Buscar Libro";
            this.Libro.Click += new System.EventHandler(this.Libro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(664, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de prestamo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(664, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha de devolucion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvLibrosPrestamo
            // 
            this.dgvLibrosPrestamo.BackgroundColor = System.Drawing.Color.White;
            this.dgvLibrosPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrosPrestamo.Location = new System.Drawing.Point(12, 102);
            this.dgvLibrosPrestamo.Name = "dgvLibrosPrestamo";
            this.dgvLibrosPrestamo.RowHeadersWidth = 51;
            this.dgvLibrosPrestamo.RowTemplate.Height = 24;
            this.dgvLibrosPrestamo.Size = new System.Drawing.Size(597, 88);
            this.dgvLibrosPrestamo.TabIndex = 11;
            // 
            // dgvUsuariosPrestamo
            // 
            this.dgvUsuariosPrestamo.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuariosPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosPrestamo.Location = new System.Drawing.Point(12, 224);
            this.dgvUsuariosPrestamo.Name = "dgvUsuariosPrestamo";
            this.dgvUsuariosPrestamo.RowHeadersWidth = 51;
            this.dgvUsuariosPrestamo.RowTemplate.Height = 24;
            this.dgvUsuariosPrestamo.Size = new System.Drawing.Size(597, 121);
            this.dgvUsuariosPrestamo.TabIndex = 12;
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.Location = new System.Drawing.Point(100, 72);
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.Size = new System.Drawing.Size(193, 22);
            this.txtBuscarLibro.TabIndex = 13;
            this.txtBuscarLibro.TextChanged += new System.EventHandler(this.txtBuscarLibro_TextChanged);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(133, 196);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(222, 22);
            this.txtBuscarUsuario.TabIndex = 14;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Buscar Prestamo";
            // 
            // txtBuscarPrestamo
            // 
            this.txtBuscarPrestamo.Location = new System.Drawing.Point(133, 351);
            this.txtBuscarPrestamo.Name = "txtBuscarPrestamo";
            this.txtBuscarPrestamo.Size = new System.Drawing.Size(226, 22);
            this.txtBuscarPrestamo.TabIndex = 16;
            this.txtBuscarPrestamo.TextChanged += new System.EventHandler(this.txtBuscarPrestamo_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 66);
            this.panel1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(226, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gestion de prestamos";
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(857, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBuscarPrestamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.txtBuscarLibro);
            this.Controls.Add(this.dgvUsuariosPrestamo);
            this.Controls.Add(this.dgvLibrosPrestamo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Libro);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.dtpDevolucion);
            this.Controls.Add(this.dtpPrestamo);
            this.Name = "FrmPrestamos";
            this.Text = "FrmPrestamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosPrestamo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpPrestamo;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label Libro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLibrosPrestamo;
        private System.Windows.Forms.DataGridView dgvUsuariosPrestamo;
        private System.Windows.Forms.TextBox txtBuscarLibro;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarPrestamo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}