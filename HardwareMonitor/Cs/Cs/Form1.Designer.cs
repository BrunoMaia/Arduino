namespace Cs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.combo_portaSerial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.combo_intervalo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cpu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_gpu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_gabinete = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_portaSerial
            // 
            this.combo_portaSerial.BackColor = System.Drawing.Color.White;
            this.combo_portaSerial.FormattingEnabled = true;
            this.combo_portaSerial.Location = new System.Drawing.Point(21, 35);
            this.combo_portaSerial.Name = "combo_portaSerial";
            this.combo_portaSerial.Size = new System.Drawing.Size(121, 21);
            this.combo_portaSerial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Porta serial:";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(21, 75);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "Conectar";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(324, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel1.Text = "Aguardando...";
            // 
            // combo_intervalo
            // 
            this.combo_intervalo.FormattingEnabled = true;
            this.combo_intervalo.Items.AddRange(new object[] {
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "3500"});
            this.combo_intervalo.Location = new System.Drawing.Point(183, 35);
            this.combo_intervalo.Name = "combo_intervalo";
            this.combo_intervalo.Size = new System.Drawing.Size(121, 21);
            this.combo_intervalo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Intervalo:";
            // 
            // textBox_cpu
            // 
            this.textBox_cpu.BackColor = System.Drawing.Color.White;
            this.textBox_cpu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_cpu.Enabled = false;
            this.textBox_cpu.Location = new System.Drawing.Point(21, 165);
            this.textBox_cpu.Name = "textBox_cpu";
            this.textBox_cpu.Size = new System.Drawing.Size(100, 13);
            this.textBox_cpu.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Temperatura CPU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Temperatura GPU:";
            // 
            // textBox_gpu
            // 
            this.textBox_gpu.BackColor = System.Drawing.Color.White;
            this.textBox_gpu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_gpu.Enabled = false;
            this.textBox_gpu.Location = new System.Drawing.Point(21, 219);
            this.textBox_gpu.Name = "textBox_gpu";
            this.textBox_gpu.Size = new System.Drawing.Size(100, 13);
            this.textBox_gpu.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Temperatura Gabinete:";
            // 
            // textBox_gabinete
            // 
            this.textBox_gabinete.BackColor = System.Drawing.Color.White;
            this.textBox_gabinete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_gabinete.Enabled = false;
            this.textBox_gabinete.Location = new System.Drawing.Point(183, 165);
            this.textBox_gabinete.Name = "textBox_gabinete";
            this.textBox_gabinete.Size = new System.Drawing.Size(113, 13);
            this.textBox_gabinete.TabIndex = 11;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "HardwareMonitor";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 301);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_gabinete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_gpu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_cpu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_intervalo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_portaSerial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 340);
            this.MinimumSize = new System.Drawing.Size(340, 340);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HardwareMonitor -- BETA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_portaSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox combo_intervalo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cpu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_gpu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_gabinete;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

