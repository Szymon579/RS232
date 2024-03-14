namespace RS232
{
    partial class MainForm
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
            panel1 = new Panel();
            menuStrip8 = new MenuStrip();
            modeComboBox = new ToolStripComboBox();
            label8 = new Label();
            menuStrip7 = new MenuStrip();
            stopBitsComboBox = new ToolStripComboBox();
            label7 = new Label();
            menuStrip6 = new MenuStrip();
            terminatorComboBox = new ToolStripComboBox();
            label6 = new Label();
            menuStrip5 = new MenuStrip();
            controlComboBox = new ToolStripComboBox();
            label5 = new Label();
            menuStrip4 = new MenuStrip();
            parityComboBox = new ToolStripComboBox();
            label4 = new Label();
            menuStrip3 = new MenuStrip();
            dataBitsComboBox = new ToolStripComboBox();
            label3 = new Label();
            menuStrip2 = new MenuStrip();
            speedComboBox = new ToolStripComboBox();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            portComboBox = new ToolStripComboBox();
            panel2 = new Panel();
            button4 = new Button();
            pingButton = new Button();
            receiveButton = new Button();
            transmitButton = new Button();
            textBox = new RichTextBox();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            menuStrip8.SuspendLayout();
            menuStrip7.SuspendLayout();
            menuStrip6.SuspendLayout();
            menuStrip5.SuspendLayout();
            menuStrip4.SuspendLayout();
            menuStrip3.SuspendLayout();
            menuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip8);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(menuStrip7);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(menuStrip6);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(menuStrip5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(menuStrip4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(menuStrip3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(menuStrip2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 94);
            panel1.TabIndex = 0;
            // 
            // menuStrip8
            // 
            menuStrip8.Dock = DockStyle.None;
            menuStrip8.Items.AddRange(new ToolStripItem[] { modeComboBox });
            menuStrip8.Location = new Point(405, 57);
            menuStrip8.Name = "menuStrip8";
            menuStrip8.Size = new Size(251, 27);
            menuStrip8.TabIndex = 14;
            menuStrip8.Text = "menuStrip8";
            // 
            // modeComboBox
            // 
            modeComboBox.Items.AddRange(new object[] { "Text", "Binary" });
            modeComboBox.Name = "modeComboBox";
            modeComboBox.Size = new Size(121, 23);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(405, 42);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 15;
            label8.Text = "Mode:";
            // 
            // menuStrip7
            // 
            menuStrip7.Dock = DockStyle.None;
            menuStrip7.Items.AddRange(new ToolStripItem[] { stopBitsComboBox });
            menuStrip7.Location = new Point(405, 15);
            menuStrip7.Name = "menuStrip7";
            menuStrip7.Size = new Size(131, 27);
            menuStrip7.TabIndex = 12;
            menuStrip7.Text = "menuStrip7";
            // 
            // stopBitsComboBox
            // 
            stopBitsComboBox.Items.AddRange(new object[] { "1 bit", "2 bits" });
            stopBitsComboBox.Name = "stopBitsComboBox";
            stopBitsComboBox.Size = new Size(121, 23);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(405, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 13;
            label7.Text = "Stop bits:";
            // 
            // menuStrip6
            // 
            menuStrip6.Dock = DockStyle.None;
            menuStrip6.Items.AddRange(new ToolStripItem[] { terminatorComboBox });
            menuStrip6.Location = new Point(271, 57);
            menuStrip6.Name = "menuStrip6";
            menuStrip6.Size = new Size(131, 27);
            menuStrip6.TabIndex = 10;
            menuStrip6.Text = "menuStrip6";
            // 
            // terminatorComboBox
            // 
            terminatorComboBox.Items.AddRange(new object[] { "None", "CR", "Lf", "CR-LF" });
            terminatorComboBox.Name = "terminatorComboBox";
            terminatorComboBox.Size = new Size(121, 23);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 42);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 11;
            label6.Text = "Terminator:";
            // 
            // menuStrip5
            // 
            menuStrip5.Dock = DockStyle.None;
            menuStrip5.Items.AddRange(new ToolStripItem[] { controlComboBox });
            menuStrip5.Location = new Point(137, 57);
            menuStrip5.Name = "menuStrip5";
            menuStrip5.Size = new Size(131, 27);
            menuStrip5.TabIndex = 8;
            menuStrip5.Text = "menuStrip5";
            // 
            // controlComboBox
            // 
            controlComboBox.Items.AddRange(new object[] { "None", "Software", "Hardware" });
            controlComboBox.Name = "controlComboBox";
            controlComboBox.Size = new Size(121, 23);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 42);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Control:";
            // 
            // menuStrip4
            // 
            menuStrip4.Dock = DockStyle.None;
            menuStrip4.Items.AddRange(new ToolStripItem[] { parityComboBox });
            menuStrip4.Location = new Point(3, 57);
            menuStrip4.Name = "menuStrip4";
            menuStrip4.Size = new Size(131, 27);
            menuStrip4.TabIndex = 6;
            menuStrip4.Text = "menuStrip4";
            // 
            // parityComboBox
            // 
            parityComboBox.Items.AddRange(new object[] { "None", "Even", "Odd" });
            parityComboBox.Name = "parityComboBox";
            parityComboBox.Size = new Size(121, 23);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 42);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Parity:";
            // 
            // menuStrip3
            // 
            menuStrip3.Dock = DockStyle.None;
            menuStrip3.Items.AddRange(new ToolStripItem[] { dataBitsComboBox });
            menuStrip3.Location = new Point(271, 15);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(131, 27);
            menuStrip3.TabIndex = 4;
            menuStrip3.Text = "menuStrip3";
            // 
            // dataBitsComboBox
            // 
            dataBitsComboBox.Items.AddRange(new object[] { "7 bits", "8 bits" });
            dataBitsComboBox.Name = "dataBitsComboBox";
            dataBitsComboBox.Size = new Size(121, 23);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Data bits:";
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { speedComboBox });
            menuStrip2.Location = new Point(137, 15);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(131, 27);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // speedComboBox
            // 
            speedComboBox.Items.AddRange(new object[] { "110 bit/s", "300 bit/s", "1200 bit/s", "2400 bit/s", "4800 bit/s", "9600 bit/s", "19200 bit/s", "38400 bit/s", "57600 bit/s", "115200 bit/s" });
            speedComboBox.Name = "speedComboBox";
            speedComboBox.Size = new Size(121, 23);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Speed:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "Port:";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { portComboBox });
            menuStrip1.Location = new Point(3, 15);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(131, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // portComboBox
            // 
            portComboBox.Items.AddRange(new object[] { "COM0", "COM1", "COM2" });
            portComboBox.Name = "portComboBox";
            portComboBox.Size = new Size(121, 23);
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(pingButton);
            panel2.Controls.Add(receiveButton);
            panel2.Controls.Add(transmitButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 266);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(405, 6);
            button4.Name = "button4";
            button4.Size = new Size(131, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // pingButton
            // 
            pingButton.Location = new Point(271, 6);
            pingButton.Name = "pingButton";
            pingButton.Size = new Size(131, 23);
            pingButton.TabIndex = 2;
            pingButton.Text = "Ping";
            pingButton.UseVisualStyleBackColor = true;
            pingButton.Click += pingButton_Click;
            // 
            // receiveButton
            // 
            receiveButton.Location = new Point(137, 6);
            receiveButton.Name = "receiveButton";
            receiveButton.Size = new Size(131, 23);
            receiveButton.TabIndex = 1;
            receiveButton.Text = "Receive";
            receiveButton.UseVisualStyleBackColor = true;
            receiveButton.Click += receiveButton_Click;
            // 
            // transmitButton
            // 
            transmitButton.Location = new Point(3, 6);
            transmitButton.Name = "transmitButton";
            transmitButton.Size = new Size(131, 23);
            transmitButton.TabIndex = 0;
            transmitButton.Text = "Transmit";
            transmitButton.UseVisualStyleBackColor = true;
            transmitButton.Click += transmitButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(10, 139);
            textBox.Name = "textBox";
            textBox.Size = new Size(542, 231);
            textBox.TabIndex = 2;
            textBox.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(10, 348);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(542, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(66, 17);
            statusLabel.Text = "statusLabel";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 380);
            Controls.Add(statusStrip1);
            Controls.Add(textBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Padding = new Padding(10);
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip8.ResumeLayout(false);
            menuStrip8.PerformLayout();
            menuStrip7.ResumeLayout(false);
            menuStrip7.PerformLayout();
            menuStrip6.ResumeLayout(false);
            menuStrip6.PerformLayout();
            menuStrip5.ResumeLayout(false);
            menuStrip5.PerformLayout();
            menuStrip4.ResumeLayout(false);
            menuStrip4.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private RichTextBox textBox;
        private MenuStrip menuStrip8;
        private ToolStripComboBox modeComboBox;
        private Label label8;
        private MenuStrip menuStrip7;
        private ToolStripComboBox stopBitsComboBox;
        private Label label7;
        private MenuStrip menuStrip6;
        private ToolStripComboBox terminatorComboBox;
        private Label label6;
        private MenuStrip menuStrip5;
        private ToolStripComboBox controlComboBox;
        private Label label5;
        private MenuStrip menuStrip4;
        private ToolStripComboBox parityComboBox;
        private Label label4;
        private MenuStrip menuStrip3;
        private ToolStripComboBox dataBitsComboBox;
        private Label label3;
        private MenuStrip menuStrip2;
        private ToolStripComboBox speedComboBox;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripComboBox portComboBox;
        private Button button4;
        private Button pingButton;
        private Button receiveButton;
        private Button transmitButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
    }
}
