
namespace OhMyPass
{
    partial class SetKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetKey));
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbRepetirPIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerOcultarRepetir = new System.Windows.Forms.Button();
            this.btnVerOcultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPIN
            // 
            this.tbPIN.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPIN.Location = new System.Drawing.Point(88, 61);
            this.tbPIN.MaxLength = 4;
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.PasswordChar = '*';
            this.tbPIN.Size = new System.Drawing.Size(458, 42);
            this.tbPIN.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(72, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 38);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(459, 211);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 38);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbRepetirPIN
            // 
            this.tbRepetirPIN.Font = new System.Drawing.Font("Lucida Bright", 21.75F);
            this.tbRepetirPIN.Location = new System.Drawing.Point(88, 149);
            this.tbRepetirPIN.MaxLength = 4;
            this.tbRepetirPIN.Name = "tbRepetirPIN";
            this.tbRepetirPIN.PasswordChar = '*';
            this.tbRepetirPIN.Size = new System.Drawing.Size(458, 42);
            this.tbRepetirPIN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Repite el PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(100, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Introduce un PIN para poder gestionar tus contraseñas";
            // 
            // btnVerOcultarRepetir
            // 
            this.btnVerOcultarRepetir.BackColor = System.Drawing.Color.White;
            this.btnVerOcultarRepetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerOcultarRepetir.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerOcultarRepetir.ForeColor = System.Drawing.Color.White;
            this.btnVerOcultarRepetir.Image = global::OhMyPass.Properties.Resources.ver;
            this.btnVerOcultarRepetir.Location = new System.Drawing.Point(504, 158);
            this.btnVerOcultarRepetir.Name = "btnVerOcultarRepetir";
            this.btnVerOcultarRepetir.Size = new System.Drawing.Size(34, 24);
            this.btnVerOcultarRepetir.TabIndex = 17;
            this.btnVerOcultarRepetir.UseVisualStyleBackColor = false;
            this.btnVerOcultarRepetir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerOcultar
            // 
            this.btnVerOcultar.BackColor = System.Drawing.Color.White;
            this.btnVerOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerOcultar.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerOcultar.ForeColor = System.Drawing.Color.White;
            this.btnVerOcultar.Image = global::OhMyPass.Properties.Resources.ver;
            this.btnVerOcultar.Location = new System.Drawing.Point(504, 69);
            this.btnVerOcultar.Name = "btnVerOcultar";
            this.btnVerOcultar.Size = new System.Drawing.Size(34, 25);
            this.btnVerOcultar.TabIndex = 2;
            this.btnVerOcultar.UseVisualStyleBackColor = false;
            this.btnVerOcultar.Click += new System.EventHandler(this.btnVerOcultar_Click);
            // 
            // SetKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(639, 261);
            this.Controls.Add(this.btnVerOcultarRepetir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRepetirPIN);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVerOcultar);
            this.Controls.Add(this.tbPIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduce PIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPIN;
        private System.Windows.Forms.Button btnVerOcultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbRepetirPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerOcultarRepetir;
    }
}