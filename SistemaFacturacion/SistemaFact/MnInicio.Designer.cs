
namespace SistemaFact
{
    partial class MnInicio
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
            this.MnPrincipal = new System.Windows.Forms.MenuStrip();
            this.INICIO = new System.Windows.Forms.ToolStripMenuItem();
            this.LOGIN = new System.Windows.Forms.ToolStripMenuItem();
            this.SALIR = new System.Windows.Forms.ToolStripMenuItem();
            this.CONSULTA = new System.Windows.Forms.ToolStripMenuItem();
            this.REPORTES = new System.Windows.Forms.ToolStripMenuItem();
            this.FACTURAR = new System.Windows.Forms.ToolStripMenuItem();
            this.ADMINISTRACION = new System.Windows.Forms.ToolStripMenuItem();
            this.MANTENIMIENTO = new System.Windows.Forms.ToolStripMenuItem();
            this.CONFIGURACION = new System.Windows.Forms.ToolStripMenuItem();
            this.AYUDA = new System.Windows.Forms.ToolStripMenuItem();
            this.MnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnPrincipal
            // 
            this.MnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.INICIO,
            this.CONSULTA,
            this.REPORTES,
            this.FACTURAR,
            this.ADMINISTRACION,
            this.MANTENIMIENTO,
            this.CONFIGURACION,
            this.AYUDA});
            this.MnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnPrincipal.Name = "MnPrincipal";
            this.MnPrincipal.ShowItemToolTips = true;
            this.MnPrincipal.Size = new System.Drawing.Size(990, 24);
            this.MnPrincipal.TabIndex = 0;
            this.MnPrincipal.Text = "menuStrip1";
            // 
            // INICIO
            // 
            this.INICIO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LOGIN,
            this.SALIR});
            this.INICIO.Name = "INICIO";
            this.INICIO.Size = new System.Drawing.Size(54, 20);
            this.INICIO.Text = "INICIO";
            this.INICIO.Click += new System.EventHandler(this.INICIO_Click);
            // 
            // LOGIN
            // 
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(180, 22);
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // SALIR
            // 
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(180, 22);
            this.SALIR.Text = "SALIR";
            this.SALIR.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // CONSULTA
            // 
            this.CONSULTA.Name = "CONSULTA";
            this.CONSULTA.Size = new System.Drawing.Size(77, 20);
            this.CONSULTA.Text = "CONSULTA";
            this.CONSULTA.Click += new System.EventHandler(this.CONSULTA_Click);
            // 
            // REPORTES
            // 
            this.REPORTES.Name = "REPORTES";
            this.REPORTES.Size = new System.Drawing.Size(72, 20);
            this.REPORTES.Text = "REPORTES";
            this.REPORTES.Click += new System.EventHandler(this.REPORTES_Click);
            // 
            // FACTURAR
            // 
            this.FACTURAR.Name = "FACTURAR";
            this.FACTURAR.Size = new System.Drawing.Size(76, 20);
            this.FACTURAR.Text = "FACTURAR";
            this.FACTURAR.Click += new System.EventHandler(this.FACTURAR_Click);
            // 
            // ADMINISTRACION
            // 
            this.ADMINISTRACION.Name = "ADMINISTRACION";
            this.ADMINISTRACION.Size = new System.Drawing.Size(117, 20);
            this.ADMINISTRACION.Text = "ADMINISTRACION";
            this.ADMINISTRACION.Click += new System.EventHandler(this.ADMINISTRACION_Click);
            // 
            // MANTENIMIENTO
            // 
            this.MANTENIMIENTO.Name = "MANTENIMIENTO";
            this.MANTENIMIENTO.Size = new System.Drawing.Size(114, 20);
            this.MANTENIMIENTO.Text = "MANTENIMIENTO";
            this.MANTENIMIENTO.Click += new System.EventHandler(this.MANTENIMIENTO_Click);
            // 
            // CONFIGURACION
            // 
            this.CONFIGURACION.Name = "CONFIGURACION";
            this.CONFIGURACION.Size = new System.Drawing.Size(114, 20);
            this.CONFIGURACION.Text = "CONFIGURACION";
            this.CONFIGURACION.Click += new System.EventHandler(this.CONFIGURACION_Click);
            // 
            // AYUDA
            // 
            this.AYUDA.Name = "AYUDA";
            this.AYUDA.Size = new System.Drawing.Size(57, 20);
            this.AYUDA.Text = "AYUDA";
            this.AYUDA.Click += new System.EventHandler(this.AYUDA_Click);
            // 
            // MnInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 504);
            this.Controls.Add(this.MnPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnPrincipal;
            this.Name = "MnInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Facturacion";
            this.Load += new System.EventHandler(this.MnInicio_Load);
            this.MnPrincipal.ResumeLayout(false);
            this.MnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem INICIO;
        private System.Windows.Forms.ToolStripMenuItem LOGIN;
        private System.Windows.Forms.ToolStripMenuItem SALIR;
        private System.Windows.Forms.ToolStripMenuItem CONSULTA;
        private System.Windows.Forms.ToolStripMenuItem REPORTES;
        private System.Windows.Forms.ToolStripMenuItem FACTURAR;
        private System.Windows.Forms.ToolStripMenuItem ADMINISTRACION;
        private System.Windows.Forms.ToolStripMenuItem MANTENIMIENTO;
        private System.Windows.Forms.ToolStripMenuItem CONFIGURACION;
        private System.Windows.Forms.ToolStripMenuItem AYUDA;

    }
}

