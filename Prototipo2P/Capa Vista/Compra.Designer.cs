
namespace Capa_Vista
{
    partial class Compra
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
            this.Compras = new System.Windows.Forms.TabControl();
            this.Proveedores = new System.Windows.Forms.TabPage();
            this.Solicitud = new System.Windows.Forms.TabPage();
            this.btn_consultaProv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.Compras.SuspendLayout();
            this.Proveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // Compras
            // 
            this.Compras.Controls.Add(this.Proveedores);
            this.Compras.Controls.Add(this.Solicitud);
            this.Compras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Compras.Location = new System.Drawing.Point(0, 0);
            this.Compras.Name = "Compras";
            this.Compras.SelectedIndex = 0;
            this.Compras.Size = new System.Drawing.Size(800, 450);
            this.Compras.TabIndex = 0;
            // 
            // Proveedores
            // 
            this.Proveedores.Controls.Add(this.btn_consultaProv);
            this.Proveedores.Controls.Add(this.label1);
            this.Proveedores.Controls.Add(this.dgvProveedores);
            this.Proveedores.Location = new System.Drawing.Point(4, 22);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Padding = new System.Windows.Forms.Padding(3);
            this.Proveedores.Size = new System.Drawing.Size(792, 424);
            this.Proveedores.TabIndex = 0;
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.UseVisualStyleBackColor = true;
            // 
            // Solicitud
            // 
            this.Solicitud.Location = new System.Drawing.Point(4, 22);
            this.Solicitud.Name = "Solicitud";
            this.Solicitud.Padding = new System.Windows.Forms.Padding(3);
            this.Solicitud.Size = new System.Drawing.Size(792, 424);
            this.Solicitud.TabIndex = 1;
            this.Solicitud.Text = "Nueva Orden De Compra";
            this.Solicitud.UseVisualStyleBackColor = true;
            // 
            // btn_consultaProv
            // 
            this.btn_consultaProv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultaProv.Location = new System.Drawing.Point(29, 117);
            this.btn_consultaProv.Name = "btn_consultaProv";
            this.btn_consultaProv.Size = new System.Drawing.Size(165, 38);
            this.btn_consultaProv.TabIndex = 5;
            this.btn_consultaProv.Text = "Consultar";
            this.btn_consultaProv.UseVisualStyleBackColor = true;
            this.btn_consultaProv.Click += new System.EventHandler(this.btn_consultaProv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proveedores ";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(29, 161);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(734, 210);
            this.dgvProveedores.TabIndex = 3;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Compras);
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.Compras.ResumeLayout(false);
            this.Proveedores.ResumeLayout(false);
            this.Proveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Compras;
        private System.Windows.Forms.TabPage Proveedores;
        private System.Windows.Forms.TabPage Solicitud;
        private System.Windows.Forms.Button btn_consultaProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProveedores;
    }
}