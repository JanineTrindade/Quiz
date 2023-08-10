namespace TrabQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelquest = new System.Windows.Forms.Label();
            this.rdoAltA = new System.Windows.Forms.RadioButton();
            this.rdoAltB = new System.Windows.Forms.RadioButton();
            this.rdoAltC = new System.Windows.Forms.RadioButton();
            this.rdoAltD = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelcont = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoAltNada = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUIZ";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "MARVEL",
            "STAR WARS",
            "DC COMICS"});
            this.comboBox.Location = new System.Drawing.Point(308, 116);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 1;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ESCOLHA O TEMA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelquest
            // 
            this.labelquest.AutoSize = true;
            this.labelquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelquest.Location = new System.Drawing.Point(46, 16);
            this.labelquest.Name = "labelquest";
            this.labelquest.Size = new System.Drawing.Size(109, 20);
            this.labelquest.TabIndex = 3;
            this.labelquest.Text = "QUESTÃO...";
            // 
            // rdoAltA
            // 
            this.rdoAltA.AutoSize = true;
            this.rdoAltA.Location = new System.Drawing.Point(75, 73);
            this.rdoAltA.Name = "rdoAltA";
            this.rdoAltA.Size = new System.Drawing.Size(14, 13);
            this.rdoAltA.TabIndex = 4;
            this.rdoAltA.UseVisualStyleBackColor = true;
            this.rdoAltA.CheckedChanged += new System.EventHandler(this.rdoAltA_CheckedChanged);
            // 
            // rdoAltB
            // 
            this.rdoAltB.AutoSize = true;
            this.rdoAltB.Location = new System.Drawing.Point(75, 105);
            this.rdoAltB.Name = "rdoAltB";
            this.rdoAltB.Size = new System.Drawing.Size(14, 13);
            this.rdoAltB.TabIndex = 5;
            this.rdoAltB.UseVisualStyleBackColor = true;
            this.rdoAltB.CheckedChanged += new System.EventHandler(this.rdoAltB_CheckedChanged);
            // 
            // rdoAltC
            // 
            this.rdoAltC.AutoSize = true;
            this.rdoAltC.Location = new System.Drawing.Point(75, 139);
            this.rdoAltC.Name = "rdoAltC";
            this.rdoAltC.Size = new System.Drawing.Size(14, 13);
            this.rdoAltC.TabIndex = 6;
            this.rdoAltC.UseVisualStyleBackColor = true;
            this.rdoAltC.CheckedChanged += new System.EventHandler(this.rdoAltC_CheckedChanged);
            // 
            // rdoAltD
            // 
            this.rdoAltD.AutoSize = true;
            this.rdoAltD.Location = new System.Drawing.Point(75, 172);
            this.rdoAltD.Name = "rdoAltD";
            this.rdoAltD.Size = new System.Drawing.Size(14, 13);
            this.rdoAltD.TabIndex = 7;
            this.rdoAltD.UseVisualStyleBackColor = true;
            this.rdoAltD.CheckedChanged += new System.EventHandler(this.rdoAltD_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(302, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 80);
            this.button1.TabIndex = 8;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(367, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.labelcont);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(65, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLACAR";
            this.groupBox1.Visible = false;
            // 
            // labelcont
            // 
            this.labelcont.AutoSize = true;
            this.labelcont.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcont.Location = new System.Drawing.Point(64, 32);
            this.labelcont.Name = "labelcont";
            this.labelcont.Size = new System.Drawing.Size(0, 33);
            this.labelcont.TabIndex = 11;
            this.labelcont.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoAltNada);
            this.groupBox2.Controls.Add(this.labelquest);
            this.groupBox2.Controls.Add(this.rdoAltA);
            this.groupBox2.Controls.Add(this.rdoAltB);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rdoAltC);
            this.groupBox2.Controls.Add(this.rdoAltD);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(65, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 242);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // rdoAltNada
            // 
            this.rdoAltNada.AutoSize = true;
            this.rdoAltNada.Checked = true;
            this.rdoAltNada.Location = new System.Drawing.Point(75, 203);
            this.rdoAltNada.Name = "rdoAltNada";
            this.rdoAltNada.Size = new System.Drawing.Size(14, 13);
            this.rdoAltNada.TabIndex = 9;
            this.rdoAltNada.TabStop = true;
            this.rdoAltNada.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Quiz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelquest;
        private System.Windows.Forms.RadioButton rdoAltA;
        private System.Windows.Forms.RadioButton rdoAltB;
        private System.Windows.Forms.RadioButton rdoAltC;
        private System.Windows.Forms.RadioButton rdoAltD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelcont;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoAltNada;
    }
}

