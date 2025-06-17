
namespace ATMC
{
    partial class frmCuentaempresa
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
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbPOO = new System.Windows.Forms.CheckBox();
            this.chbWeb = new System.Windows.Forms.CheckBox();
            this.chbTuto = new System.Windows.Forms.CheckBox();
            this.chbSis = new System.Windows.Forms.CheckBox();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbPOO = new System.Windows.Forms.RadioButton();
            this.rdbWeb = new System.Windows.Forms.RadioButton();
            this.rdbTuto = new System.Windows.Forms.RadioButton();
            this.rdbSis = new System.Windows.Forms.RadioButton();
            this.btnfav = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtvCategorias = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(147, 66);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(121, 24);
            this.cmbCategorias.TabIndex = 0;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(12, 134);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(235, 22);
            this.txtid.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 202);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Materias que le gustan ";
            // 
            // chbPOO
            // 
            this.chbPOO.AutoSize = true;
            this.chbPOO.Location = new System.Drawing.Point(24, 308);
            this.chbPOO.Name = "chbPOO";
            this.chbPOO.Size = new System.Drawing.Size(248, 21);
            this.chbPOO.TabIndex = 6;
            this.chbPOO.Text = "Programacion orientada a objetos ";
            this.chbPOO.UseVisualStyleBackColor = true;
            this.chbPOO.CheckedChanged += new System.EventHandler(this.chbPOO_CheckedChanged);
            // 
            // chbWeb
            // 
            this.chbWeb.AutoSize = true;
            this.chbWeb.Location = new System.Drawing.Point(24, 335);
            this.chbWeb.Name = "chbWeb";
            this.chbWeb.Size = new System.Drawing.Size(128, 21);
            this.chbWeb.TabIndex = 7;
            this.chbWeb.Text = "Desarrollo Web";
            this.chbWeb.UseVisualStyleBackColor = true;
            // 
            // chbTuto
            // 
            this.chbTuto.AutoSize = true;
            this.chbTuto.Location = new System.Drawing.Point(24, 362);
            this.chbTuto.Name = "chbTuto";
            this.chbTuto.Size = new System.Drawing.Size(82, 21);
            this.chbTuto.TabIndex = 8;
            this.chbTuto.Text = "Tutorias";
            this.chbTuto.UseVisualStyleBackColor = true;
            // 
            // chbSis
            // 
            this.chbSis.AutoSize = true;
            this.chbSis.Location = new System.Drawing.Point(22, 389);
            this.chbSis.Name = "chbSis";
            this.chbSis.Size = new System.Drawing.Size(158, 21);
            this.chbSis.TabIndex = 9;
            this.chbSis.Text = "sistemas Operativos";
            this.chbSis.UseVisualStyleBackColor = true;
            // 
            // btnMaterias
            // 
            this.btnMaterias.Location = new System.Drawing.Point(24, 445);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(75, 23);
            this.btnMaterias.TabIndex = 10;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Materia Favorita";
            // 
            // rdbPOO
            // 
            this.rdbPOO.AutoSize = true;
            this.rdbPOO.Location = new System.Drawing.Point(24, 534);
            this.rdbPOO.Name = "rdbPOO";
            this.rdbPOO.Size = new System.Drawing.Size(249, 21);
            this.rdbPOO.TabIndex = 12;
            this.rdbPOO.TabStop = true;
            this.rdbPOO.Text = "Programacion Orientada a Objetos";
            this.rdbPOO.UseVisualStyleBackColor = true;
            // 
            // rdbWeb
            // 
            this.rdbWeb.AutoSize = true;
            this.rdbWeb.Location = new System.Drawing.Point(24, 562);
            this.rdbWeb.Name = "rdbWeb";
            this.rdbWeb.Size = new System.Drawing.Size(127, 21);
            this.rdbWeb.TabIndex = 13;
            this.rdbWeb.TabStop = true;
            this.rdbWeb.Text = "Desarrollo Web";
            this.rdbWeb.UseVisualStyleBackColor = true;
            // 
            // rdbTuto
            // 
            this.rdbTuto.AutoSize = true;
            this.rdbTuto.Location = new System.Drawing.Point(24, 589);
            this.rdbTuto.Name = "rdbTuto";
            this.rdbTuto.Size = new System.Drawing.Size(81, 21);
            this.rdbTuto.TabIndex = 14;
            this.rdbTuto.TabStop = true;
            this.rdbTuto.Text = "Tutorias";
            this.rdbTuto.UseVisualStyleBackColor = true;
            // 
            // rdbSis
            // 
            this.rdbSis.AutoSize = true;
            this.rdbSis.Location = new System.Drawing.Point(24, 616);
            this.rdbSis.Name = "rdbSis";
            this.rdbSis.Size = new System.Drawing.Size(159, 21);
            this.rdbSis.TabIndex = 15;
            this.rdbSis.TabStop = true;
            this.rdbSis.Text = "Sistemas Operativos";
            this.rdbSis.UseVisualStyleBackColor = true;
            // 
            // btnfav
            // 
            this.btnfav.Location = new System.Drawing.Point(24, 656);
            this.btnfav.Name = "btnfav";
            this.btnfav.Size = new System.Drawing.Size(128, 23);
            this.btnfav.TabIndex = 16;
            this.btnfav.Text = "Materia ok";
            this.btnfav.UseVisualStyleBackColor = true;
            this.btnfav.Click += new System.EventHandler(this.btnfav_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 21);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 21);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Muejer";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(336, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // dtvCategorias
            // 
            this.dtvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCategorias.Location = new System.Drawing.Point(342, 445);
            this.dtvCategorias.Name = "dtvCategorias";
            this.dtvCategorias.RowHeadersWidth = 51;
            this.dtvCategorias.RowTemplate.Height = 24;
            this.dtvCategorias.Size = new System.Drawing.Size(778, 223);
            this.dtvCategorias.TabIndex = 21;
            this.dtvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvCategorias_CellClick);
            this.dtvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvCategorias_CellContentClick);
            this.dtvCategorias.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvCategorias_CellEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nombre";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(342, 257);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(317, 22);
            this.txtCliente.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cuenta";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(342, 322);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(317, 22);
            this.txtCuenta.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(342, 398);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(317, 22);
            this.txtSaldo.TabIndex = 27;
            // 
            // frmCuentaempresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 749);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtvCategorias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnfav);
            this.Controls.Add(this.rdbSis);
            this.Controls.Add(this.rdbTuto);
            this.Controls.Add(this.rdbWeb);
            this.Controls.Add(this.rdbPOO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMaterias);
            this.Controls.Add(this.chbSis);
            this.Controls.Add(this.chbTuto);
            this.Controls.Add(this.chbWeb);
            this.Controls.Add(this.chbPOO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cmbCategorias);
            this.Name = "frmCuentaempresa";
            this.Text = "frmCuentaempresa";
            this.Load += new System.EventHandler(this.frmCuentaempresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbPOO;
        private System.Windows.Forms.CheckBox chbWeb;
        private System.Windows.Forms.CheckBox chbTuto;
        private System.Windows.Forms.CheckBox chbSis;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbPOO;
        private System.Windows.Forms.RadioButton rdbWeb;
        private System.Windows.Forms.RadioButton rdbTuto;
        private System.Windows.Forms.RadioButton rdbSis;
        private System.Windows.Forms.Button btnfav;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtvCategorias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSaldo;
    }
}