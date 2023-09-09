namespace Password_generator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Groupbox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_auto = new System.Windows.Forms.CheckBox();
            this.label_strip = new System.Windows.Forms.Label();
            this.label_stripbar = new System.Windows.Forms.Label();
            this.checkBox_symbols = new System.Windows.Forms.CheckBox();
            this.checkBox_letters = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_copy = new System.Windows.Forms.Button();
            this.label_isCopy = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.Groupbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(0, 157);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Minimum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(287, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.UseWaitCursor = true;
            this.trackBar1.Value = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Groupbox1
            // 
            this.Groupbox1.Controls.Add(this.checkBox_auto);
            this.Groupbox1.Controls.Add(this.label_strip);
            this.Groupbox1.Controls.Add(this.label_stripbar);
            this.Groupbox1.Controls.Add(this.checkBox_symbols);
            this.Groupbox1.Controls.Add(this.checkBox_letters);
            this.Groupbox1.Controls.Add(this.trackBar1);
            this.Groupbox1.Location = new System.Drawing.Point(12, 12);
            this.Groupbox1.Name = "Groupbox1";
            this.Groupbox1.Size = new System.Drawing.Size(524, 240);
            this.Groupbox1.TabIndex = 2;
            this.Groupbox1.TabStop = false;
            this.Groupbox1.Text = "Параметры";
            // 
            // checkBox_auto
            // 
            this.checkBox_auto.AutoSize = true;
            this.checkBox_auto.Location = new System.Drawing.Point(9, 31);
            this.checkBox_auto.Name = "checkBox_auto";
            this.checkBox_auto.Size = new System.Drawing.Size(131, 20);
            this.checkBox_auto.TabIndex = 8;
            this.checkBox_auto.Text = "Автоматически";
            this.checkBox_auto.UseVisualStyleBackColor = true;
            this.checkBox_auto.CheckedChanged += new System.EventHandler(this.checkBox_auto_CheckedChanged);
            // 
            // label_strip
            // 
            this.label_strip.AutoSize = true;
            this.label_strip.Location = new System.Drawing.Point(160, 138);
            this.label_strip.Name = "label_strip";
            this.label_strip.Size = new System.Drawing.Size(14, 16);
            this.label_strip.TabIndex = 7;
            this.label_strip.Text = "8";
            // 
            // label_stripbar
            // 
            this.label_stripbar.AutoSize = true;
            this.label_stripbar.Location = new System.Drawing.Point(6, 138);
            this.label_stripbar.Name = "label_stripbar";
            this.label_stripbar.Size = new System.Drawing.Size(148, 16);
            this.label_stripbar.TabIndex = 6;
            this.label_stripbar.Text = "Количесво символов:";
            // 
            // checkBox_symbols
            // 
            this.checkBox_symbols.AutoSize = true;
            this.checkBox_symbols.Location = new System.Drawing.Point(9, 83);
            this.checkBox_symbols.Name = "checkBox_symbols";
            this.checkBox_symbols.Size = new System.Drawing.Size(145, 20);
            this.checkBox_symbols.TabIndex = 4;
            this.checkBox_symbols.Text = "Символы (@*;$!#?)";
            this.checkBox_symbols.UseVisualStyleBackColor = true;
            // 
            // checkBox_letters
            // 
            this.checkBox_letters.AutoSize = true;
            this.checkBox_letters.Location = new System.Drawing.Point(9, 57);
            this.checkBox_letters.Name = "checkBox_letters";
            this.checkBox_letters.Size = new System.Drawing.Size(98, 20);
            this.checkBox_letters.TabIndex = 3;
            this.checkBox_letters.Text = "Буквы (Aa)";
            this.checkBox_letters.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_isCopy);
            this.groupBox2.Controls.Add(this.textBox_password);
            this.groupBox2.Controls.Add(this.button_copy);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пароль:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(9, 48);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(443, 22);
            this.textBox_password.TabIndex = 1;
            // 
            // button_copy
            // 
            this.button_copy.Image = ((System.Drawing.Image)(resources.GetObject("button_copy.Image")));
            this.button_copy.Location = new System.Drawing.Point(458, 41);
            this.button_copy.Name = "button_copy";
            this.button_copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_copy.Size = new System.Drawing.Size(37, 37);
            this.button_copy.TabIndex = 4;
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // label_isCopy
            // 
            this.label_isCopy.AutoSize = true;
            this.label_isCopy.Location = new System.Drawing.Point(412, 18);
            this.label_isCopy.Name = "label_isCopy";
            this.label_isCopy.Size = new System.Drawing.Size(0, 16);
            this.label_isCopy.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Groupbox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Генератор пароля";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.Groupbox1.ResumeLayout(false);
            this.Groupbox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox Groupbox1;
        private System.Windows.Forms.Label label_stripbar;
        private System.Windows.Forms.CheckBox checkBox_symbols;
        private System.Windows.Forms.CheckBox checkBox_letters;
        private System.Windows.Forms.Label label_strip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.CheckBox checkBox_auto;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Label label_isCopy;
        private System.Windows.Forms.Timer timer1;
    }
}

