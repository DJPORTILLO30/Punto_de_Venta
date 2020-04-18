namespace Punto_de_venta
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            resources.ApplyResources(this.txt1, "txt1");
            this.txt1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt1.Name = "txt1";
            // 
            // user
            // 
            resources.ApplyResources(this.user, "user");
            this.user.Name = "user";
            // 
            // txt2
            // 
            resources.ApplyResources(this.txt2, "txt2");
            this.txt2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt2.Name = "txt2";
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            // 
            // txt3
            // 
            resources.ApplyResources(this.txt3, "txt3");
            this.txt3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt3.Name = "txt3";
            // 
            // log
            // 
            resources.ApplyResources(this.log, "log");
            this.log.Name = "log";
            this.log.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(141)))));
            this.Controls.Add(this.log);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.user);
            this.Controls.Add(this.txt1);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.Button log;
    }
}

