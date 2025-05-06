namespace TempCleaner
{
    partial class TempCleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempCleaner));
            this.BtProcess = new System.Windows.Forms.Button();
            this.TxtRoute = new System.Windows.Forms.TextBox();
            this.PBProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BtProcess
            // 
            this.BtProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtProcess.Location = new System.Drawing.Point(328, 54);
            this.BtProcess.Name = "BtProcess";
            this.BtProcess.Size = new System.Drawing.Size(75, 23);
            this.BtProcess.TabIndex = 0;
            this.BtProcess.Text = "Process";
            this.BtProcess.UseVisualStyleBackColor = true;
            this.BtProcess.Click += new System.EventHandler(this.BtProcess_Click);
            // 
            // TxtRoute
            // 
            this.TxtRoute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRoute.Location = new System.Drawing.Point(53, 54);
            this.TxtRoute.Name = "TxtRoute";
            this.TxtRoute.ReadOnly = true;
            this.TxtRoute.Size = new System.Drawing.Size(269, 22);
            this.TxtRoute.TabIndex = 1;
            // 
            // PBProgress
            // 
            this.PBProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBProgress.Location = new System.Drawing.Point(53, 115);
            this.PBProgress.Name = "PBProgress";
            this.PBProgress.Size = new System.Drawing.Size(350, 13);
            this.PBProgress.TabIndex = 2;
            // 
            // TempCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 192);
            this.Controls.Add(this.PBProgress);
            this.Controls.Add(this.TxtRoute);
            this.Controls.Add(this.BtProcess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(498, 239);
            this.Name = "TempCleaner";
            this.Text = "Temp Cleaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtProcess;
        private System.Windows.Forms.TextBox TxtRoute;
        private System.Windows.Forms.ProgressBar PBProgress;
    }
}

