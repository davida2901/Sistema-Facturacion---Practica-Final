
namespace SistemaFact
{
    partial class FrmReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.GrfPrecios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GrfVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GrfPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrfVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // GrfPrecios
            // 
            chartArea1.Name = "ChartArea1";
            this.GrfPrecios.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GrfPrecios.Legends.Add(legend1);
            this.GrfPrecios.Location = new System.Drawing.Point(12, 61);
            this.GrfPrecios.Name = "GrfPrecios";
            this.GrfPrecios.Size = new System.Drawing.Size(380, 332);
            this.GrfPrecios.TabIndex = 0;
            this.GrfPrecios.Text = "chart1";
            // 
            // GrfVentas
            // 
            chartArea2.Name = "ChartArea1";
            this.GrfVentas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GrfVentas.Legends.Add(legend2);
            this.GrfVentas.Location = new System.Drawing.Point(398, 61);
            this.GrfVentas.Name = "GrfVentas";
            this.GrfVentas.Size = new System.Drawing.Size(416, 332);
            this.GrfVentas.TabIndex = 1;
            this.GrfVentas.Text = "chart2";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 443);
            this.Controls.Add(this.GrfVentas);
            this.Controls.Add(this.GrfPrecios);
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrfPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrfVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GrfPrecios;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrfVentas;
    }
}