namespace SoyTuQuiroApp
{
    partial class Main
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
            this.clientsButton = new System.Windows.Forms.Button();
            this.servicesButton = new System.Windows.Forms.Button();
            this.visitsButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsButton
            // 
            this.clientsButton.Location = new System.Drawing.Point(12, 194);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(228, 113);
            this.clientsButton.TabIndex = 0;
            this.clientsButton.Text = "Clientes";
            this.clientsButton.UseVisualStyleBackColor = true;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // servicesButton
            // 
            this.servicesButton.Location = new System.Drawing.Point(12, 325);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(228, 113);
            this.servicesButton.TabIndex = 1;
            this.servicesButton.Text = "Servicios";
            this.servicesButton.UseVisualStyleBackColor = true;
            // 
            // visitsButton
            // 
            this.visitsButton.Location = new System.Drawing.Point(258, 194);
            this.visitsButton.Name = "visitsButton";
            this.visitsButton.Size = new System.Drawing.Size(228, 113);
            this.visitsButton.TabIndex = 2;
            this.visitsButton.Text = "Visitas";
            this.visitsButton.UseVisualStyleBackColor = true;
            this.visitsButton.Click += new System.EventHandler(this.visitsButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(258, 325);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(228, 113);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "Historial";
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoyTuQuiroApp.Properties.Resources.Nombre_Largo_Nueva_Q;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.visitsButton);
            this.Controls.Add(this.servicesButton);
            this.Controls.Add(this.clientsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "STQ Center";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button servicesButton;
        private System.Windows.Forms.Button visitsButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

