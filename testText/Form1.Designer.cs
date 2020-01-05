namespace testText
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Port_Combox = new System.Windows.Forms.ComboBox();
            this.Baud_Combox = new System.Windows.Forms.ComboBox();
            this.Data_Combox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Output_btn = new System.Windows.Forms.Button();
            this.Input_btn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 203);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Port_Combox
            // 
            this.Port_Combox.FormattingEnabled = true;
            this.Port_Combox.Location = new System.Drawing.Point(82, 28);
            this.Port_Combox.Name = "Port_Combox";
            this.Port_Combox.Size = new System.Drawing.Size(121, 20);
            this.Port_Combox.TabIndex = 1;
            this.Port_Combox.Text = "COM3";
            // 
            // Baud_Combox
            // 
            this.Baud_Combox.FormattingEnabled = true;
            this.Baud_Combox.Items.AddRange(new object[] {
            "115200"});
            this.Baud_Combox.Location = new System.Drawing.Point(82, 69);
            this.Baud_Combox.Name = "Baud_Combox";
            this.Baud_Combox.Size = new System.Drawing.Size(121, 20);
            this.Baud_Combox.TabIndex = 2;
            this.Baud_Combox.Text = "115200";
            // 
            // Data_Combox
            // 
            this.Data_Combox.FormattingEnabled = true;
            this.Data_Combox.Items.AddRange(new object[] {
            "8"});
            this.Data_Combox.Location = new System.Drawing.Point(82, 113);
            this.Data_Combox.Name = "Data_Combox";
            this.Data_Combox.Size = new System.Drawing.Size(121, 20);
            this.Data_Combox.TabIndex = 3;
            this.Data_Combox.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "baudrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "data";
            // 
            // Output_btn
            // 
            this.Output_btn.Location = new System.Drawing.Point(30, 159);
            this.Output_btn.Name = "Output_btn";
            this.Output_btn.Size = new System.Drawing.Size(78, 72);
            this.Output_btn.TabIndex = 7;
            this.Output_btn.Text = "내보내기";
            this.Output_btn.UseVisualStyleBackColor = true;
            this.Output_btn.Click += new System.EventHandler(this.Output_btn_Click);
            // 
            // Input_btn
            // 
            this.Input_btn.Location = new System.Drawing.Point(125, 159);
            this.Input_btn.Name = "Input_btn";
            this.Input_btn.Size = new System.Drawing.Size(78, 72);
            this.Input_btn.TabIndex = 8;
            this.Input_btn.Text = "읽기";
            this.Input_btn.UseVisualStyleBackColor = true;
            this.Input_btn.Click += new System.EventHandler(this.Input_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 252);
            this.Controls.Add(this.Input_btn);
            this.Controls.Add(this.Output_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data_Combox);
            this.Controls.Add(this.Baud_Combox);
            this.Controls.Add(this.Port_Combox);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Port_Combox;
        private System.Windows.Forms.ComboBox Baud_Combox;
        private System.Windows.Forms.ComboBox Data_Combox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Output_btn;
        private System.Windows.Forms.Button Input_btn;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

