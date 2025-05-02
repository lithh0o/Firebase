namespace appFirebase
{
    partial class DispControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            imgDisp = new PictureBox();
            lblDisp = new Label();
            btnAct = new Button();
            btnDes = new Button();
            btnError = new Button();
            ((System.ComponentModel.ISupportInitialize)imgDisp).BeginInit();
            SuspendLayout();
            // 
            // imgDisp
            // 
            imgDisp.Image = Properties.Resources.gifBlack;
            imgDisp.Location = new Point(3, 67);
            imgDisp.Name = "imgDisp";
            imgDisp.Size = new Size(148, 160);
            imgDisp.SizeMode = PictureBoxSizeMode.StretchImage;
            imgDisp.TabIndex = 0;
            imgDisp.TabStop = false;
            // 
            // lblDisp
            // 
            lblDisp.AutoSize = true;
            lblDisp.Font = new Font("Harlow Solid Italic", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDisp.Location = new Point(6, 6);
            lblDisp.Name = "lblDisp";
            lblDisp.Size = new Size(145, 55);
            lblDisp.TabIndex = 1;
            lblDisp.Text = "11 - 12";
            // 
            // btnAct
            // 
            btnAct.BackColor = Color.SeaGreen;
            btnAct.Font = new Font("Britannic Bold", 9F);
            btnAct.Location = new Point(153, 62);
            btnAct.Name = "btnAct";
            btnAct.Size = new Size(124, 44);
            btnAct.TabIndex = 2;
            btnAct.Text = "ACTIVAR";
            btnAct.UseVisualStyleBackColor = false;
            btnAct.Click += btnAct_Click;
            // 
            // btnDes
            // 
            btnDes.BackColor = Color.Silver;
            btnDes.Font = new Font("Britannic Bold", 9F);
            btnDes.Location = new Point(153, 120);
            btnDes.Name = "btnDes";
            btnDes.Size = new Size(124, 44);
            btnDes.TabIndex = 3;
            btnDes.Text = "DESACTIVAR";
            btnDes.UseVisualStyleBackColor = false;
            btnDes.Click += btnDes_Click;
            // 
            // btnError
            // 
            btnError.BackColor = Color.IndianRed;
            btnError.Font = new Font("Britannic Bold", 9F);
            btnError.Location = new Point(153, 178);
            btnError.Name = "btnError";
            btnError.Size = new Size(124, 44);
            btnError.TabIndex = 4;
            btnError.Text = "ERROR";
            btnError.UseVisualStyleBackColor = false;
            btnError.Click += btnError_Click;
            // 
            // DispControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnError);
            Controls.Add(btnDes);
            Controls.Add(btnAct);
            Controls.Add(lblDisp);
            Controls.Add(imgDisp);
            Name = "DispControl";
            Size = new Size(280, 230);
            ((System.ComponentModel.ISupportInitialize)imgDisp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAct;
        private Button btnDes;
        private Button btnError;
        public Label lblDisp;
        public PictureBox imgDisp;
    }
}
