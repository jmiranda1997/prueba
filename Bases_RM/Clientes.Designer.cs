﻿namespace Bases_RM
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.TxtNit = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtDeuda = new System.Windows.Forms.TextBox();
            this.lbNit = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbDeuda = new System.Windows.Forms.Label();
            this.arbolClientes = new System.Windows.Forms.TreeView();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.lbClasi = new System.Windows.Forms.Label();
            this.lbLimiq = new System.Windows.Forms.Label();
            this.TxtLimic = new System.Windows.Forms.TextBox();
            this.btnMG = new System.Windows.Forms.Button();
            this.btnEC = new System.Windows.Forms.Button();
            this.lbClasi2 = new System.Windows.Forms.Label();
            this.lbDias = new System.Windows.Forms.Label();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.menuOpciones = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeDeudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.btnAbono = new System.Windows.Forms.Button();
            this.btnDeuda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtApe = new System.Windows.Forms.TextBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.filtrosGB = new System.Windows.Forms.GroupBox();
            this.rbtnGeneral = new System.Windows.Forms.RadioButton();
            this.rbtnSucursal = new System.Windows.Forms.RadioButton();
            this.menuOpciones.SuspendLayout();
            this.filtrosGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(329, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(323, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtNit
            // 
            this.TxtNit.Enabled = false;
            this.TxtNit.Location = new System.Drawing.Point(329, 51);
            this.TxtNit.Name = "TxtNit";
            this.TxtNit.Size = new System.Drawing.Size(323, 20);
            this.TxtNit.TabIndex = 1;
            // 
            // TxtNom
            // 
            this.TxtNom.Enabled = false;
            this.TxtNom.Location = new System.Drawing.Point(329, 81);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(125, 20);
            this.TxtNom.TabIndex = 2;
            // 
            // TxtDeuda
            // 
            this.TxtDeuda.Enabled = false;
            this.TxtDeuda.Location = new System.Drawing.Point(329, 112);
            this.TxtDeuda.Name = "TxtDeuda";
            this.TxtDeuda.Size = new System.Drawing.Size(125, 20);
            this.TxtDeuda.TabIndex = 3;
            this.TxtDeuda.Text = "0.00";
            this.TxtDeuda.TextChanged += new System.EventHandler(this.TxtDeuda_TextChanged);
            // 
            // lbNit
            // 
            this.lbNit.AutoSize = true;
            this.lbNit.Location = new System.Drawing.Point(272, 51);
            this.lbNit.Name = "lbNit";
            this.lbNit.Size = new System.Drawing.Size(51, 13);
            this.lbNit.TabIndex = 4;
            this.lbNit.Text = "NIT/DPI:";
            this.lbNit.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(272, 84);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(52, 13);
            this.lbNom.TabIndex = 5;
            this.lbNom.Text = "Nombres:";
            this.lbNom.Click += new System.EventHandler(this.lbNom_Click);
            // 
            // lbDeuda
            // 
            this.lbDeuda.AutoSize = true;
            this.lbDeuda.Location = new System.Drawing.Point(271, 115);
            this.lbDeuda.Name = "lbDeuda";
            this.lbDeuda.Size = new System.Drawing.Size(39, 13);
            this.lbDeuda.TabIndex = 6;
            this.lbDeuda.Text = "Deuda";
            this.lbDeuda.Click += new System.EventHandler(this.lbDeuda_Click);
            // 
            // arbolClientes
            // 
            this.arbolClientes.Location = new System.Drawing.Point(12, 21);
            this.arbolClientes.Name = "arbolClientes";
            this.arbolClientes.Size = new System.Drawing.Size(236, 239);
            this.arbolClientes.TabIndex = 7;
            this.arbolClientes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.arbolClientes_AfterSelect);
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(465, 115);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(34, 13);
            this.lbSaldo.TabIndex = 8;
            this.lbSaldo.Text = "Saldo";
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Enabled = false;
            this.TxtSaldo.Location = new System.Drawing.Point(518, 115);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(134, 20);
            this.TxtSaldo.TabIndex = 9;
            this.TxtSaldo.Text = "0.00";
            // 
            // lbClasi
            // 
            this.lbClasi.AutoSize = true;
            this.lbClasi.Location = new System.Drawing.Point(272, 175);
            this.lbClasi.Name = "lbClasi";
            this.lbClasi.Size = new System.Drawing.Size(69, 13);
            this.lbClasi.TabIndex = 10;
            this.lbClasi.Text = "Clasificación:";
            // 
            // lbLimiq
            // 
            this.lbLimiq.AutoSize = true;
            this.lbLimiq.Location = new System.Drawing.Point(272, 205);
            this.lbLimiq.Name = "lbLimiq";
            this.lbLimiq.Size = new System.Drawing.Size(90, 13);
            this.lbLimiq.TabIndex = 11;
            this.lbLimiq.Text = "Límite de Crédito:";
            this.lbLimiq.Click += new System.EventHandler(this.lbLimiq_Click);
            // 
            // TxtLimic
            // 
            this.TxtLimic.Enabled = false;
            this.TxtLimic.Location = new System.Drawing.Point(368, 202);
            this.TxtLimic.Name = "TxtLimic";
            this.TxtLimic.Size = new System.Drawing.Size(122, 20);
            this.TxtLimic.TabIndex = 13;
            this.TxtLimic.Leave += new System.EventHandler(this.TxtLimic_Leave);
            // 
            // btnMG
            // 
            this.btnMG.Location = new System.Drawing.Point(431, 272);
            this.btnMG.Name = "btnMG";
            this.btnMG.Size = new System.Drawing.Size(102, 23);
            this.btnMG.TabIndex = 14;
            this.btnMG.Text = "Modificar";
            this.btnMG.UseVisualStyleBackColor = true;
            this.btnMG.Click += new System.EventHandler(this.btnMG_Click);
            // 
            // btnEC
            // 
            this.btnEC.Location = new System.Drawing.Point(539, 272);
            this.btnEC.Name = "btnEC";
            this.btnEC.Size = new System.Drawing.Size(102, 23);
            this.btnEC.TabIndex = 15;
            this.btnEC.Text = "Eliminar";
            this.btnEC.UseVisualStyleBackColor = true;
            this.btnEC.Click += new System.EventHandler(this.btnEC_Click);
            // 
            // lbClasi2
            // 
            this.lbClasi2.AutoSize = true;
            this.lbClasi2.Location = new System.Drawing.Point(344, 175);
            this.lbClasi2.Name = "lbClasi2";
            this.lbClasi2.Size = new System.Drawing.Size(40, 13);
            this.lbClasi2.TabIndex = 16;
            this.lbClasi2.Text = "Normal";
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Location = new System.Drawing.Point(272, 231);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(84, 13);
            this.lbDias.TabIndex = 17;
            this.lbDias.Text = "Días de Crédito:";
            // 
            // TxtDias
            // 
            this.TxtDias.Enabled = false;
            this.TxtDias.Location = new System.Drawing.Point(368, 228);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(122, 20);
            this.TxtDias.TabIndex = 18;
            // 
            // menuOpciones
            // 
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(673, 24);
            this.menuOpciones.TabIndex = 19;
            this.menuOpciones.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportarToolStripMenuItem.Text = "&Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeDeudasToolStripMenuItem,
            this.registroDePagosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // registroDeDeudasToolStripMenuItem
            // 
            this.registroDeDeudasToolStripMenuItem.Name = "registroDeDeudasToolStripMenuItem";
            this.registroDeDeudasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registroDeDeudasToolStripMenuItem.Text = "Registro de Deudas";
            this.registroDeDeudasToolStripMenuItem.Click += new System.EventHandler(this.registroDeDeudasToolStripMenuItem_Click);
            // 
            // registroDePagosToolStripMenuItem
            // 
            this.registroDePagosToolStripMenuItem.Name = "registroDePagosToolStripMenuItem";
            this.registroDePagosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registroDePagosToolStripMenuItem.Text = "Registro de Pagos";
            this.registroDePagosToolStripMenuItem.Click += new System.EventHandler(this.registroDePagosToolStripMenuItem_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(272, 24);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(43, 13);
            this.lbBuscar.TabIndex = 20;
            this.lbBuscar.Text = "Buscar:";
            this.lbBuscar.Click += new System.EventHandler(this.lbBuscar_Click);
            // 
            // btnAbono
            // 
            this.btnAbono.Location = new System.Drawing.Point(269, 272);
            this.btnAbono.Name = "btnAbono";
            this.btnAbono.Size = new System.Drawing.Size(75, 23);
            this.btnAbono.TabIndex = 21;
            this.btnAbono.Text = "Abono";
            this.btnAbono.UseVisualStyleBackColor = true;
            this.btnAbono.Click += new System.EventHandler(this.btnAbono_Click);
            // 
            // btnDeuda
            // 
            this.btnDeuda.Location = new System.Drawing.Point(350, 272);
            this.btnDeuda.Name = "btnDeuda";
            this.btnDeuda.Size = new System.Drawing.Size(75, 23);
            this.btnDeuda.TabIndex = 22;
            this.btnDeuda.Text = "Deuda";
            this.btnDeuda.UseVisualStyleBackColor = true;
            this.btnDeuda.Click += new System.EventHandler(this.btnDeuda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Apellidos:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TxtApe
            // 
            this.TxtApe.Enabled = false;
            this.TxtApe.Location = new System.Drawing.Point(518, 81);
            this.TxtApe.Name = "TxtApe";
            this.TxtApe.Size = new System.Drawing.Size(134, 20);
            this.TxtApe.TabIndex = 23;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(272, 147);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(107, 13);
            this.lblSucursal.TabIndex = 25;
            this.lblSucursal.Text = "Sucursal de la deuda";
            // 
            // cbSucursal
            // 
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(385, 144);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(267, 21);
            this.cbSucursal.TabIndex = 26;
            this.cbSucursal.SelectedIndexChanged += new System.EventHandler(this.cbSucursal_SelectedIndexChanged);
            // 
            // filtrosGB
            // 
            this.filtrosGB.Controls.Add(this.rbtnGeneral);
            this.filtrosGB.Controls.Add(this.rbtnSucursal);
            this.filtrosGB.Location = new System.Drawing.Point(12, 272);
            this.filtrosGB.Name = "filtrosGB";
            this.filtrosGB.Size = new System.Drawing.Size(198, 44);
            this.filtrosGB.TabIndex = 27;
            this.filtrosGB.TabStop = false;
            this.filtrosGB.Text = "Filtros";
            this.filtrosGB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnGeneral
            // 
            this.rbtnGeneral.AutoSize = true;
            this.rbtnGeneral.Checked = true;
            this.rbtnGeneral.Location = new System.Drawing.Point(108, 19);
            this.rbtnGeneral.Name = "rbtnGeneral";
            this.rbtnGeneral.Size = new System.Drawing.Size(62, 17);
            this.rbtnGeneral.TabIndex = 1;
            this.rbtnGeneral.TabStop = true;
            this.rbtnGeneral.Text = "General";
            this.rbtnGeneral.UseVisualStyleBackColor = true;
            // 
            // rbtnSucursal
            // 
            this.rbtnSucursal.AutoSize = true;
            this.rbtnSucursal.Location = new System.Drawing.Point(6, 19);
            this.rbtnSucursal.Name = "rbtnSucursal";
            this.rbtnSucursal.Size = new System.Drawing.Size(66, 17);
            this.rbtnSucursal.TabIndex = 0;
            this.rbtnSucursal.Text = "Sucursal";
            this.rbtnSucursal.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 328);
            this.Controls.Add(this.filtrosGB);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtApe);
            this.Controls.Add(this.btnDeuda);
            this.Controls.Add(this.btnAbono);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.TxtDias);
            this.Controls.Add(this.lbDias);
            this.Controls.Add(this.lbClasi2);
            this.Controls.Add(this.btnEC);
            this.Controls.Add(this.btnMG);
            this.Controls.Add(this.TxtLimic);
            this.Controls.Add(this.lbLimiq);
            this.Controls.Add(this.lbClasi);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.arbolClientes);
            this.Controls.Add(this.lbDeuda);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbNit);
            this.Controls.Add(this.TxtDeuda);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtNit);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.menuOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuOpciones;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.menuOpciones.ResumeLayout(false);
            this.menuOpciones.PerformLayout();
            this.filtrosGB.ResumeLayout(false);
            this.filtrosGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox TxtNit;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtDeuda;
        private System.Windows.Forms.Label lbNit;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbDeuda;
        private System.Windows.Forms.TreeView arbolClientes;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Label lbClasi;
        private System.Windows.Forms.Label lbLimiq;
        private System.Windows.Forms.TextBox TxtLimic;
        private System.Windows.Forms.Button btnMG;
        private System.Windows.Forms.Button btnEC;
        private System.Windows.Forms.Label lbClasi2;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.MenuStrip menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button btnAbono;
        private System.Windows.Forms.Button btnDeuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtApe;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.GroupBox filtrosGB;
        private System.Windows.Forms.RadioButton rbtnGeneral;
        private System.Windows.Forms.RadioButton rbtnSucursal;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeDeudasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDePagosToolStripMenuItem;
    }
}