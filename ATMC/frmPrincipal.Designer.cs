
namespace ATMC
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFrm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFrmEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTareas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmTareas
            // 
            this.tsmTareas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFrm1,
            this.tsmFrmEmpresa,
            this.baseDeDatosToolStripMenuItem});
            this.tsmTareas.Name = "tsmTareas";
            this.tsmTareas.Size = new System.Drawing.Size(64, 24);
            this.tsmTareas.Text = "Tareas";
            // 
            // tsmFrm1
            // 
            this.tsmFrm1.Name = "tsmFrm1";
            this.tsmFrm1.Size = new System.Drawing.Size(275, 26);
            this.tsmFrm1.Text = "Formulario 1";
            this.tsmFrm1.Click += new System.EventHandler(this.tsmFrm1_Click);
            // 
            // tsmFrmEmpresa
            // 
            this.tsmFrmEmpresa.Name = "tsmFrmEmpresa";
            this.tsmFrmEmpresa.Size = new System.Drawing.Size(275, 26);
            this.tsmFrmEmpresa.Text = "Formulario Cuenta empresa";
            this.tsmFrmEmpresa.Click += new System.EventHandler(this.tsmFrmEmpresa_Click);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.baseDeDatosToolStripMenuItem.Text = "Base de datos";
            this.baseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.baseDeDatosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 883);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmTareas;
        private System.Windows.Forms.ToolStripMenuItem tsmFrm1;
        private System.Windows.Forms.ToolStripMenuItem tsmFrmEmpresa;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
    }
}