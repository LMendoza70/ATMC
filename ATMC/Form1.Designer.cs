
namespace ATMC
{
    partial class Form1
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
            this.cuenta = new CuentaFree();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNumCuenta = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblValorSaldo = new System.Windows.Forms.Label();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(12, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(125, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Titular";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(406, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Cuenta Free";
            // 
            // lblNumCuenta
            // 
            this.lblNumCuenta.AutoSize = true;
            this.lblNumCuenta.Location = new System.Drawing.Point(12, 155);
            this.lblNumCuenta.Name = "lblNumCuenta";
            this.lblNumCuenta.Size = new System.Drawing.Size(125, 17);
            this.lblNumCuenta.TabIndex = 2;
            this.lblNumCuenta.Text = "Numero de cuenta";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Location = new System.Drawing.Point(15, 186);
            this.txtNumCuenta.MaxLength = 8;
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(405, 22);
            this.txtNumCuenta.TabIndex = 3;
            this.txtNumCuenta.Text = "00000000";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 251);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(56, 17);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo : ";
            // 
            // lblValorSaldo
            // 
            this.lblValorSaldo.AutoSize = true;
            this.lblValorSaldo.Location = new System.Drawing.Point(78, 251);
            this.lblValorSaldo.Name = "lblValorSaldo";
            this.lblValorSaldo.Size = new System.Drawing.Size(20, 17);
            this.lblValorSaldo.TabIndex = 5;
            //this.lblValorSaldo.Text = "$ "+ cuenta.Saldo;
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(15, 301);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(75, 23);
            this.btnDeposito.TabIndex = 6;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(169, 301);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(75, 23);
            this.btnRetiro.TabIndex = 7;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.MouseLeave += new System.EventHandler(this.btnRetiro_MouseLeave);
            this.btnRetiro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRetiro_MouseMove);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(345, 301);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(75, 23);
            this.btnEstado.TabIndex = 8;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 584);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.lblValorSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtNumCuenta);
            this.Controls.Add(this.lblNumCuenta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "CAjero ATM C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNumCuenta;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblValorSaldo;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnEstado;
        private CuentaFree cuenta;
    }
}

