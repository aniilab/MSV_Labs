namespace NumericMethodsLab1
{
    partial class NumericMethods
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumericMethods));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dichotomyAprior = new System.Windows.Forms.Label();
            this.solDichotomy = new System.Windows.Forms.Label();
            this.apost_dichotomy = new System.Windows.Forms.Label();
            this.apost_newton = new System.Windows.Forms.Label();
            this.sol_newton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SI_aprior = new System.Windows.Forms.Label();
            this.SI_sol = new System.Windows.Forms.Label();
            this.SI_apost = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(732, -39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(958, 224);
            this.label1.TabIndex = 2;
            this.label1.Text = "Усі методи виконуються на проміжку [-1, 0.5]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1126, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(765, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Апріорна оцінка:      n  = ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dichotomyAprior
            // 
            this.dichotomyAprior.AutoSize = true;
            this.dichotomyAprior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dichotomyAprior.Location = new System.Drawing.Point(1067, 233);
            this.dichotomyAprior.Name = "dichotomyAprior";
            this.dichotomyAprior.Size = new System.Drawing.Size(55, 29);
            this.dichotomyAprior.TabIndex = 7;
            this.dichotomyAprior.Text = "      ";
            this.dichotomyAprior.Click += new System.EventHandler(this.dichotomyAprior_Click);
            // 
            // solDichotomy
            // 
            this.solDichotomy.AutoSize = true;
            this.solDichotomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solDichotomy.Location = new System.Drawing.Point(765, 262);
            this.solDichotomy.Name = "solDichotomy";
            this.solDichotomy.Size = new System.Drawing.Size(76, 29);
            this.solDichotomy.TabIndex = 9;
            this.solDichotomy.Text = "         ";
            // 
            // apost_dichotomy
            // 
            this.apost_dichotomy.AutoSize = true;
            this.apost_dichotomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apost_dichotomy.Location = new System.Drawing.Point(765, 291);
            this.apost_dichotomy.Name = "apost_dichotomy";
            this.apost_dichotomy.Size = new System.Drawing.Size(76, 29);
            this.apost_dichotomy.TabIndex = 10;
            this.apost_dichotomy.Text = "         ";
            // 
            // apost_newton
            // 
            this.apost_newton.AutoSize = true;
            this.apost_newton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apost_newton.Location = new System.Drawing.Point(765, 524);
            this.apost_newton.Name = "apost_newton";
            this.apost_newton.Size = new System.Drawing.Size(76, 29);
            this.apost_newton.TabIndex = 13;
            this.apost_newton.Text = "         ";
            // 
            // sol_newton
            // 
            this.sol_newton.AutoSize = true;
            this.sol_newton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sol_newton.Location = new System.Drawing.Point(765, 495);
            this.sol_newton.Name = "sol_newton";
            this.sol_newton.Size = new System.Drawing.Size(76, 29);
            this.sol_newton.TabIndex = 12;
            this.sol_newton.Text = "         ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(765, 690);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Апріорна оцінка:      n  = ";
            // 
            // SI_aprior
            // 
            this.SI_aprior.AutoSize = true;
            this.SI_aprior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SI_aprior.Location = new System.Drawing.Point(1068, 690);
            this.SI_aprior.Name = "SI_aprior";
            this.SI_aprior.Size = new System.Drawing.Size(55, 29);
            this.SI_aprior.TabIndex = 16;
            this.SI_aprior.Text = "      ";
            // 
            // SI_sol
            // 
            this.SI_sol.AutoSize = true;
            this.SI_sol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SI_sol.Location = new System.Drawing.Point(765, 719);
            this.SI_sol.Name = "SI_sol";
            this.SI_sol.Size = new System.Drawing.Size(76, 29);
            this.SI_sol.TabIndex = 17;
            this.SI_sol.Text = "         ";
            // 
            // SI_apost
            // 
            this.SI_apost.AutoSize = true;
            this.SI_apost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SI_apost.Location = new System.Drawing.Point(765, 748);
            this.SI_apost.Name = "SI_apost";
            this.SI_apost.Size = new System.Drawing.Size(76, 29);
            this.SI_apost.TabIndex = 18;
            this.SI_apost.Text = "         ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(726, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 56);
            this.button2.TabIndex = 21;
            this.button2.Text = "Метод дихотомії (ділення проміжку навпіл)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(726, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(572, 56);
            this.button3.TabIndex = 22;
            this.button3.Text = "Модифікований метод Ньютона\r\n";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(726, 631);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(572, 56);
            this.button4.TabIndex = 23;
            this.button4.Text = "Метод простої ітерації";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.photo_2022_04_09_20_01_33;
            this.pictureBox5.Location = new System.Drawing.Point(79, 803);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(452, 211);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.photo_2022_04_09_19_50_52;
            this.pictureBox4.Location = new System.Drawing.Point(118, 712);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(363, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.photo_2022_04_09_19_32_05;
            this.pictureBox3.Location = new System.Drawing.Point(966, 923);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(399, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.photo_2022_04_09_18_28_13;
            this.pictureBox2.Location = new System.Drawing.Point(89, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(467, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-27, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 572);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(765, 833);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Апріорна оцінка:      n  = ";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // NumericMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1789, 1050);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.SI_apost);
            this.Controls.Add(this.SI_sol);
            this.Controls.Add(this.SI_aprior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apost_newton);
            this.Controls.Add(this.sol_newton);
            this.Controls.Add(this.apost_dichotomy);
            this.Controls.Add(this.solDichotomy);
            this.Controls.Add(this.dichotomyAprior);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NumericMethods";
            this.Text = "Numeric Methods";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dichotomyAprior;
        private System.Windows.Forms.Label solDichotomy;
        private System.Windows.Forms.Label apost_dichotomy;
        private System.Windows.Forms.Label apost_newton;
        private System.Windows.Forms.Label sol_newton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SI_aprior;
        private System.Windows.Forms.Label SI_sol;
        private System.Windows.Forms.Label SI_apost;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
    }
}

