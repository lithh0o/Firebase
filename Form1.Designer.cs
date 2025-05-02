namespace appFirebase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtDisp = new TextBox();
            txtEst = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            btnFirebase = new Button();
            btnDes = new Button();
            btnAct = new Button();
            label4 = new Label();
            txtTime = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1 = new TabControl();
            tabDisp = new TabPage();
            tabConfig = new TabPage();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            lblEstacion = new Label();
            tabControl1.SuspendLayout();
            tabDisp.SuspendLayout();
            tabConfig.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1212, 545);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // txtDisp
            // 
            txtDisp.BackColor = SystemColors.InfoText;
            txtDisp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisp.ForeColor = SystemColors.ScrollBar;
            txtDisp.Location = new Point(182, 41);
            txtDisp.Name = "txtDisp";
            txtDisp.Size = new Size(150, 39);
            txtDisp.TabIndex = 1;
            txtDisp.Text = "4";
            // 
            // txtEst
            // 
            txtEst.BackColor = SystemColors.InfoText;
            txtEst.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEst.ForeColor = SystemColors.ScrollBar;
            txtEst.Location = new Point(182, 90);
            txtEst.Name = "txtEst";
            txtEst.Size = new Size(150, 39);
            txtEst.TabIndex = 2;
            txtEst.Text = "1200";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 3;
            label1.Text = "# DISP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 4;
            label2.Text = "ESTACION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(6, 148);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 6;
            label3.Text = "USUARIO";
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.InfoText;
            txtUser.CharacterCasing = CharacterCasing.Upper;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = SystemColors.ScrollBar;
            txtUser.Location = new Point(182, 141);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(150, 39);
            txtUser.TabIndex = 5;
            txtUser.Text = "HPO";
            // 
            // btnFirebase
            // 
            btnFirebase.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFirebase.Location = new Point(182, 209);
            btnFirebase.Name = "btnFirebase";
            btnFirebase.Size = new Size(150, 49);
            btnFirebase.TabIndex = 7;
            btnFirebase.Text = "CARGAR";
            btnFirebase.UseVisualStyleBackColor = true;
            btnFirebase.Click += btnFirebaseClick;
            // 
            // btnDes
            // 
            btnDes.BackColor = Color.DimGray;
            btnDes.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDes.Location = new Point(1070, 595);
            btnDes.Name = "btnDes";
            btnDes.Size = new Size(175, 49);
            btnDes.TabIndex = 8;
            btnDes.Text = "DESACTIVAR";
            btnDes.UseVisualStyleBackColor = false;
            btnDes.Click += btnDesactivar;
            // 
            // btnAct
            // 
            btnAct.BackColor = Color.DimGray;
            btnAct.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAct.Location = new Point(889, 595);
            btnAct.Name = "btnAct";
            btnAct.Size = new Size(175, 49);
            btnAct.TabIndex = 9;
            btnAct.Text = "ACTIVAR";
            btnAct.UseVisualStyleBackColor = false;
            btnAct.Click += btnActivar;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(108, 41);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 11;
            label4.Text = "time";
            // 
            // txtTime
            // 
            txtTime.BackColor = SystemColors.InfoText;
            txtTime.CharacterCasing = CharacterCasing.Upper;
            txtTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTime.ForeColor = SystemColors.ScrollBar;
            txtTime.Location = new Point(69, 76);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(150, 39);
            txtTime.TabIndex = 10;
            txtTime.Text = "5000";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabDisp);
            tabControl1.Controls.Add(tabConfig);
            tabControl1.Location = new Point(12, 21);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1256, 562);
            tabControl1.TabIndex = 12;
            // 
            // tabDisp
            // 
            tabDisp.BackColor = Color.Black;
            tabDisp.Controls.Add(flowLayoutPanel1);
            tabDisp.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tabDisp.Location = new Point(34, 4);
            tabDisp.Name = "tabDisp";
            tabDisp.Padding = new Padding(3);
            tabDisp.Size = new Size(1218, 554);
            tabDisp.TabIndex = 0;
            tabDisp.Text = "DISPENSARIOS";
            tabDisp.UseVisualStyleBackColor = true;
            // 
            // tabConfig
            // 
            tabConfig.BackColor = Color.Black;
            tabConfig.Controls.Add(groupBox2);
            tabConfig.Controls.Add(groupBox1);
            tabConfig.Location = new Point(34, 4);
            tabConfig.Name = "tabConfig";
            tabConfig.Padding = new Padding(3);
            tabConfig.Size = new Size(1218, 554);
            tabConfig.TabIndex = 1;
            tabConfig.Text = "CONFIGURACION";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTime);
            groupBox2.ForeColor = SystemColors.ControlDarkDark;
            groupBox2.Location = new Point(377, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 150);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "TIMER";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnFirebase);
            groupBox1.Controls.Add(txtDisp);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEst);
            groupBox1.ForeColor = SystemColors.ControlDark;
            groupBox1.Location = new Point(24, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 297);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "FIREBASE";
            // 
            // lblEstacion
            // 
            lblEstacion.AutoSize = true;
            lblEstacion.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblEstacion.ForeColor = SystemColors.ButtonShadow;
            lblEstacion.Location = new Point(76, 603);
            lblEstacion.Name = "lblEstacion";
            lblEstacion.Size = new Size(149, 32);
            lblEstacion.TabIndex = 13;
            lblEstacion.Text = "ESTACION: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1273, 656);
            Controls.Add(lblEstacion);
            Controls.Add(tabControl1);
            Controls.Add(btnAct);
            Controls.Add(btnDes);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabDisp.ResumeLayout(false);
            tabConfig.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtDisp;
        private TextBox txtEst;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private Button btnFirebase;
        private Button btnDes;
        private Button btnAct;
        private Label label4;
        private TextBox txtTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabControl tabControl1;
        private TabPage tabDisp;
        private TabPage tabConfig;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblEstacion;
    }
}
