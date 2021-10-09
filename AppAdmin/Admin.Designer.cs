namespace AppAdmin
{
    partial class Admin
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
            this.rbCompras = new System.Windows.Forms.RadioButton();
            this.rbSouvenirs = new System.Windows.Forms.RadioButton();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvSouvenirs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSouvenirs)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCompras
            // 
            this.rbCompras.AutoSize = true;
            this.rbCompras.Location = new System.Drawing.Point(12, 38);
            this.rbCompras.Name = "rbCompras";
            this.rbCompras.Size = new System.Drawing.Size(66, 17);
            this.rbCompras.TabIndex = 0;
            this.rbCompras.TabStop = true;
            this.rbCompras.Text = "Compras";
            this.rbCompras.UseVisualStyleBackColor = true;
            this.rbCompras.CheckedChanged += new System.EventHandler(this.rbCompras_CheckedChanged);
            // 
            // rbSouvenirs
            // 
            this.rbSouvenirs.AutoSize = true;
            this.rbSouvenirs.Location = new System.Drawing.Point(12, 61);
            this.rbSouvenirs.Name = "rbSouvenirs";
            this.rbSouvenirs.Size = new System.Drawing.Size(72, 17);
            this.rbSouvenirs.TabIndex = 1;
            this.rbSouvenirs.TabStop = true;
            this.rbSouvenirs.Text = "Souvenirs";
            this.rbSouvenirs.UseVisualStyleBackColor = true;
            this.rbSouvenirs.CheckedChanged += new System.EventHandler(this.rbSouvenirs_CheckedChanged);
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(190, 12);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(442, 255);
            this.dgvCompras.TabIndex = 2;
            this.dgvCompras.Visible = false;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(190, 313);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(101, 39);
            this.btnAlta.TabIndex = 3;
            this.btnAlta.Text = "Agregar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(365, 313);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(101, 39);
            this.btnBaja.TabIndex = 4;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(531, 313);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 39);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvSouvenirs
            // 
            this.dgvSouvenirs.AllowUserToAddRows = false;
            this.dgvSouvenirs.AllowUserToDeleteRows = false;
            this.dgvSouvenirs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSouvenirs.Location = new System.Drawing.Point(190, 12);
            this.dgvSouvenirs.Name = "dgvSouvenirs";
            this.dgvSouvenirs.Size = new System.Drawing.Size(442, 255);
            this.dgvSouvenirs.TabIndex = 6;
            this.dgvSouvenirs.Visible = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSouvenirs);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.rbSouvenirs);
            this.Controls.Add(this.rbCompras);
            this.Name = "Admin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSouvenirs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCompras;
        private System.Windows.Forms.RadioButton rbSouvenirs;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvSouvenirs;
    }
}

