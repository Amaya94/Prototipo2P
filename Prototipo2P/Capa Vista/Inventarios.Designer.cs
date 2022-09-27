
namespace Capa_Vista
{
    partial class Inventarios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ConsultaI = new System.Windows.Forms.TabPage();
            this.IngresoI = new System.Windows.Forms.TabPage();
            this.dgvInventarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consultarInv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.TxtCodigoL = new System.Windows.Forms.TextBox();
            this.TxtCodigoM = new System.Windows.Forms.TextBox();
            this.TxtExistenciaP = new System.Windows.Forms.TextBox();
            this.TxtEstatusP = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ConsultaI.SuspendLayout();
            this.IngresoI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ConsultaI);
            this.tabControl1.Controls.Add(this.IngresoI);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ConsultaI
            // 
            this.ConsultaI.Controls.Add(this.btn_consultarInv);
            this.ConsultaI.Controls.Add(this.label1);
            this.ConsultaI.Controls.Add(this.dgvInventarios);
            this.ConsultaI.Location = new System.Drawing.Point(4, 22);
            this.ConsultaI.Name = "ConsultaI";
            this.ConsultaI.Padding = new System.Windows.Forms.Padding(3);
            this.ConsultaI.Size = new System.Drawing.Size(792, 424);
            this.ConsultaI.TabIndex = 0;
            this.ConsultaI.Text = "Consultar Inventario";
            this.ConsultaI.UseVisualStyleBackColor = true;
            this.ConsultaI.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // IngresoI
            // 
            this.IngresoI.Controls.Add(this.btn_cancelar);
            this.IngresoI.Controls.Add(this.btn_guardar);
            this.IngresoI.Controls.Add(this.TxtEstatusP);
            this.IngresoI.Controls.Add(this.TxtExistenciaP);
            this.IngresoI.Controls.Add(this.TxtCodigoM);
            this.IngresoI.Controls.Add(this.TxtCodigoL);
            this.IngresoI.Controls.Add(this.txtNombreP);
            this.IngresoI.Controls.Add(this.txtCodigoP);
            this.IngresoI.Controls.Add(this.label8);
            this.IngresoI.Controls.Add(this.label7);
            this.IngresoI.Controls.Add(this.label6);
            this.IngresoI.Controls.Add(this.label5);
            this.IngresoI.Controls.Add(this.label4);
            this.IngresoI.Controls.Add(this.label3);
            this.IngresoI.Controls.Add(this.label2);
            this.IngresoI.Location = new System.Drawing.Point(4, 22);
            this.IngresoI.Name = "IngresoI";
            this.IngresoI.Padding = new System.Windows.Forms.Padding(3);
            this.IngresoI.Size = new System.Drawing.Size(792, 424);
            this.IngresoI.TabIndex = 1;
            this.IngresoI.Text = "Ingresar Nuevo ";
            this.IngresoI.UseVisualStyleBackColor = true;
            // 
            // dgvInventarios
            // 
            this.dgvInventarios.AllowUserToAddRows = false;
            this.dgvInventarios.AllowUserToDeleteRows = false;
            this.dgvInventarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarios.Location = new System.Drawing.Point(32, 122);
            this.dgvInventarios.Name = "dgvInventarios";
            this.dgvInventarios.Size = new System.Drawing.Size(734, 210);
            this.dgvInventarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventarios";
            // 
            // btn_consultarInv
            // 
            this.btn_consultarInv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarInv.Location = new System.Drawing.Point(32, 78);
            this.btn_consultarInv.Name = "btn_consultarInv";
            this.btn_consultarInv.Size = new System.Drawing.Size(165, 38);
            this.btn_consultarInv.TabIndex = 2;
            this.btn_consultarInv.Text = "Consultar";
            this.btn_consultarInv.UseVisualStyleBackColor = true;
            this.btn_consultarInv.Click += new System.EventHandler(this.btn_consultarInv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Codigo Linea";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Codigo Marca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Existencia Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(404, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Estatus Produto";
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoP.Location = new System.Drawing.Point(209, 114);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(158, 26);
            this.txtCodigoP.TabIndex = 9;
            this.txtCodigoP.Tag = "codigo_producto";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreP.Location = new System.Drawing.Point(209, 164);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(158, 26);
            this.txtNombreP.TabIndex = 10;
            this.txtNombreP.Tag = "nombre_producto";
            // 
            // TxtCodigoL
            // 
            this.TxtCodigoL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoL.Location = new System.Drawing.Point(209, 209);
            this.TxtCodigoL.Name = "TxtCodigoL";
            this.TxtCodigoL.Size = new System.Drawing.Size(158, 26);
            this.TxtCodigoL.TabIndex = 11;
            this.TxtCodigoL.Tag = "codigo_linea";
            // 
            // TxtCodigoM
            // 
            this.TxtCodigoM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoM.Location = new System.Drawing.Point(594, 114);
            this.TxtCodigoM.Name = "TxtCodigoM";
            this.TxtCodigoM.Size = new System.Drawing.Size(158, 26);
            this.TxtCodigoM.TabIndex = 12;
            this.TxtCodigoM.Tag = "codigo_marca";
            // 
            // TxtExistenciaP
            // 
            this.TxtExistenciaP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExistenciaP.Location = new System.Drawing.Point(594, 167);
            this.TxtExistenciaP.Name = "TxtExistenciaP";
            this.TxtExistenciaP.Size = new System.Drawing.Size(158, 26);
            this.TxtExistenciaP.TabIndex = 13;
            this.TxtExistenciaP.Tag = "existencia_producto";
            // 
            // TxtEstatusP
            // 
            this.TxtEstatusP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstatusP.Location = new System.Drawing.Point(594, 217);
            this.TxtEstatusP.Name = "TxtEstatusP";
            this.TxtEstatusP.Size = new System.Drawing.Size(158, 26);
            this.TxtEstatusP.TabIndex = 14;
            this.TxtEstatusP.Tag = "estatus_producto";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(423, 346);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(165, 38);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(594, 346);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(165, 38);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Inventarios";
            this.Text = "Inventarios";
            this.tabControl1.ResumeLayout(false);
            this.ConsultaI.ResumeLayout(false);
            this.ConsultaI.PerformLayout();
            this.IngresoI.ResumeLayout(false);
            this.IngresoI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ConsultaI;
        private System.Windows.Forms.Button btn_consultarInv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventarios;
        private System.Windows.Forms.TabPage IngresoI;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox TxtEstatusP;
        private System.Windows.Forms.TextBox TxtExistenciaP;
        private System.Windows.Forms.TextBox TxtCodigoM;
        private System.Windows.Forms.TextBox TxtCodigoL;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}