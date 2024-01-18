namespace TPLTASKBUSCAR
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkLast = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkCountry = new System.Windows.Forms.CheckBox();
            this.chkIP = new System.Windows.Forms.CheckBox();
            this.chkid = new System.Windows.Forms.CheckBox();
            this.chkFirst = new System.Windows.Forms.CheckBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // chkLast
            // 
            this.chkLast.AutoSize = true;
            this.chkLast.Location = new System.Drawing.Point(511, 129);
            this.chkLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLast.Name = "chkLast";
            this.chkLast.Size = new System.Drawing.Size(112, 24);
            this.chkLast.TabIndex = 0;
            this.chkLast.Text = "Last Name";
            this.chkLast.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(635, 129);
            this.chkEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(74, 24);
            this.chkEmail.TabIndex = 1;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkCountry
            // 
            this.chkCountry.AutoSize = true;
            this.chkCountry.Location = new System.Drawing.Point(721, 129);
            this.chkCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCountry.Name = "chkCountry";
            this.chkCountry.Size = new System.Drawing.Size(90, 24);
            this.chkCountry.TabIndex = 2;
            this.chkCountry.Text = "Country";
            this.chkCountry.UseVisualStyleBackColor = true;
            // 
            // chkIP
            // 
            this.chkIP.AutoSize = true;
            this.chkIP.Location = new System.Drawing.Point(823, 129);
            this.chkIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIP.Name = "chkIP";
            this.chkIP.Size = new System.Drawing.Size(50, 24);
            this.chkIP.TabIndex = 3;
            this.chkIP.Text = "IP";
            this.chkIP.UseVisualStyleBackColor = true;
            // 
            // chkid
            // 
            this.chkid.AutoSize = true;
            this.chkid.Location = new System.Drawing.Point(323, 129);
            this.chkid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkid.Name = "chkid";
            this.chkid.Size = new System.Drawing.Size(52, 24);
            this.chkid.TabIndex = 4;
            this.chkid.Text = "ID";
            this.chkid.UseVisualStyleBackColor = true;
            // 
            // chkFirst
            // 
            this.chkFirst.AutoSize = true;
            this.chkFirst.Location = new System.Drawing.Point(388, 129);
            this.chkFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFirst.Name = "chkFirst";
            this.chkFirst.Size = new System.Drawing.Size(112, 24);
            this.chkFirst.TabIndex = 5;
            this.chkFirst.Text = "First Name";
            this.chkFirst.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(256, 89);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(552, 26);
            this.txtbuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(820, 83);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(255, 176);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(676, 154);
            this.txtResult.TabIndex = 8;
            this.txtResult.Text = "";
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 402);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.chkFirst);
            this.Controls.Add(this.chkid);
            this.Controls.Add(this.chkIP);
            this.Controls.Add(this.chkCountry);
            this.Controls.Add(this.chkEmail);
            this.Controls.Add(this.chkLast);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLast;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkCountry;
        private System.Windows.Forms.CheckBox chkIP;
        private System.Windows.Forms.CheckBox chkid;
        private System.Windows.Forms.CheckBox chkFirst;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox txtResult;

    }
}

