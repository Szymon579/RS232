﻿namespace RS232
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
            paramsPanel = new Panel();
            modeCombo = new ComboBox();
            terminatorCombo = new ComboBox();
            controlCombo = new ComboBox();
            parityCombo = new ComboBox();
            stopBitsCombo = new ComboBox();
            dataBitsCombo = new ComboBox();
            boudRateCombo = new ComboBox();
            portCombo = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pingButton = new Button();
            echoCheckBox = new CheckBox();
            radioGroupBox = new GroupBox();
            transceiveRadioButton = new RadioButton();
            receiveRadioButton = new RadioButton();
            transmitRadioButton = new RadioButton();
            inputTextBox = new TextBox();
            sendButton = new Button();
            textBox = new RichTextBox();
            stopButton = new Button();
            startButton = new Button();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            paramsPanel.SuspendLayout();
            panel2.SuspendLayout();
            radioGroupBox.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // paramsPanel
            // 
            paramsPanel.Controls.Add(modeCombo);
            paramsPanel.Controls.Add(terminatorCombo);
            paramsPanel.Controls.Add(controlCombo);
            paramsPanel.Controls.Add(parityCombo);
            paramsPanel.Controls.Add(stopBitsCombo);
            paramsPanel.Controls.Add(dataBitsCombo);
            paramsPanel.Controls.Add(boudRateCombo);
            paramsPanel.Controls.Add(portCombo);
            paramsPanel.Controls.Add(label8);
            paramsPanel.Controls.Add(label7);
            paramsPanel.Controls.Add(label6);
            paramsPanel.Controls.Add(label5);
            paramsPanel.Controls.Add(label4);
            paramsPanel.Controls.Add(label3);
            paramsPanel.Controls.Add(label2);
            paramsPanel.Controls.Add(label1);
            paramsPanel.Dock = DockStyle.Top;
            paramsPanel.Location = new Point(10, 10);
            paramsPanel.Name = "paramsPanel";
            paramsPanel.Size = new Size(548, 94);
            paramsPanel.TabIndex = 0;
            // 
            // modeCombo
            // 
            modeCombo.FormattingEnabled = true;
            modeCombo.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            modeCombo.Location = new Point(412, 62);
            modeCombo.Name = "modeCombo";
            modeCombo.Size = new Size(121, 23);
            modeCombo.TabIndex = 22;
            // 
            // terminatorCombo
            // 
            terminatorCombo.FormattingEnabled = true;
            terminatorCombo.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            terminatorCombo.Location = new Point(278, 62);
            terminatorCombo.Name = "terminatorCombo";
            terminatorCombo.Size = new Size(121, 23);
            terminatorCombo.TabIndex = 21;
            // 
            // controlCombo
            // 
            controlCombo.FormattingEnabled = true;
            controlCombo.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            controlCombo.Location = new Point(144, 62);
            controlCombo.Name = "controlCombo";
            controlCombo.Size = new Size(121, 23);
            controlCombo.TabIndex = 20;
            // 
            // parityCombo
            // 
            parityCombo.FormattingEnabled = true;
            parityCombo.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            parityCombo.Location = new Point(10, 62);
            parityCombo.Name = "parityCombo";
            parityCombo.Size = new Size(121, 23);
            parityCombo.TabIndex = 19;
            // 
            // stopBitsCombo
            // 
            stopBitsCombo.FormattingEnabled = true;
            stopBitsCombo.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            stopBitsCombo.Location = new Point(412, 18);
            stopBitsCombo.Name = "stopBitsCombo";
            stopBitsCombo.Size = new Size(121, 23);
            stopBitsCombo.TabIndex = 18;
            // 
            // dataBitsCombo
            // 
            dataBitsCombo.FormattingEnabled = true;
            dataBitsCombo.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            dataBitsCombo.Location = new Point(278, 18);
            dataBitsCombo.Name = "dataBitsCombo";
            dataBitsCombo.Size = new Size(121, 23);
            dataBitsCombo.TabIndex = 17;
            // 
            // boudRateCombo
            // 
            boudRateCombo.FormattingEnabled = true;
            boudRateCombo.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            boudRateCombo.Location = new Point(144, 18);
            boudRateCombo.Name = "boudRateCombo";
            boudRateCombo.Size = new Size(121, 23);
            boudRateCombo.TabIndex = 16;
            // 
            // portCombo
            // 
            portCombo.FormattingEnabled = true;
            portCombo.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            portCombo.Location = new Point(10, 18);
            portCombo.Name = "portCombo";
            portCombo.Size = new Size(121, 23);
            portCombo.TabIndex = 4;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(405, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 13;
            label7.Text = "Stop bits:";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 42);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Control:";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Data bits:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Boud rate:";
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
            // panel2
            // 
            panel2.Controls.Add(pingButton);
            panel2.Controls.Add(echoCheckBox);
            panel2.Controls.Add(radioGroupBox);
            panel2.Controls.Add(inputTextBox);
            panel2.Controls.Add(sendButton);
            panel2.Controls.Add(textBox);
            panel2.Controls.Add(stopButton);
            panel2.Controls.Add(startButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(548, 344);
            panel2.TabIndex = 1;
            // 
            // pingButton
            // 
            pingButton.Location = new Point(278, 16);
            pingButton.Name = "pingButton";
            pingButton.Size = new Size(81, 32);
            pingButton.TabIndex = 10;
            pingButton.Text = "Ping";
            pingButton.UseVisualStyleBackColor = true;
            pingButton.Click += pingButton_Click;
            // 
            // echoCheckBox
            // 
            echoCheckBox.AutoSize = true;
            echoCheckBox.Location = new Point(493, 293);
            echoCheckBox.Name = "echoCheckBox";
            echoCheckBox.Size = new Size(52, 19);
            echoCheckBox.TabIndex = 9;
            echoCheckBox.Text = "Echo";
            echoCheckBox.UseVisualStyleBackColor = true;
            // 
            // radioGroupBox
            // 
            radioGroupBox.Controls.Add(transceiveRadioButton);
            radioGroupBox.Controls.Add(receiveRadioButton);
            radioGroupBox.Controls.Add(transmitRadioButton);
            radioGroupBox.Location = new Point(10, 9);
            radioGroupBox.Name = "radioGroupBox";
            radioGroupBox.Size = new Size(262, 39);
            radioGroupBox.TabIndex = 8;
            radioGroupBox.TabStop = false;
            // 
            // transceiveRadioButton
            // 
            transceiveRadioButton.AutoSize = true;
            transceiveRadioButton.Location = new Point(173, 14);
            transceiveRadioButton.Name = "transceiveRadioButton";
            transceiveRadioButton.Size = new Size(83, 19);
            transceiveRadioButton.TabIndex = 8;
            transceiveRadioButton.TabStop = true;
            transceiveRadioButton.Text = "Transceiver";
            transceiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // receiveRadioButton
            // 
            receiveRadioButton.AutoSize = true;
            receiveRadioButton.Location = new Point(98, 14);
            receiveRadioButton.Name = "receiveRadioButton";
            receiveRadioButton.Size = new Size(69, 19);
            receiveRadioButton.TabIndex = 7;
            receiveRadioButton.TabStop = true;
            receiveRadioButton.Text = "Receiver";
            receiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // transmitRadioButton
            // 
            transmitRadioButton.AutoSize = true;
            transmitRadioButton.Location = new Point(8, 14);
            transmitRadioButton.Name = "transmitRadioButton";
            transmitRadioButton.Size = new Size(84, 19);
            transmitRadioButton.TabIndex = 6;
            transmitRadioButton.TabStop = true;
            transmitRadioButton.Text = "Transmitter";
            transmitRadioButton.UseVisualStyleBackColor = true;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(10, 291);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(389, 23);
            inputTextBox.TabIndex = 5;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(405, 291);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(82, 23);
            sendButton.TabIndex = 4;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(3, 54);
            textBox.Name = "textBox";
            textBox.Size = new Size(542, 231);
            textBox.TabIndex = 2;
            textBox.Text = "";
            // 
            // stopButton
            // 
            stopButton.Location = new Point(452, 16);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(81, 32);
            stopButton.TabIndex = 3;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(365, 16);
            startButton.Name = "startButton";
            startButton.Size = new Size(81, 32);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(10, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(548, 22);
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
            ClientSize = new Size(568, 458);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Controls.Add(paramsPanel);
            Name = "MainForm";
            Padding = new Padding(10);
            Text = "RS232";
            paramsPanel.ResumeLayout(false);
            paramsPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            radioGroupBox.ResumeLayout(false);
            radioGroupBox.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel paramsPanel;
        private Panel panel2;
        private RichTextBox textBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button stopButton;
        private Button startButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ComboBox portCombo;
        private ComboBox modeCombo;
        private ComboBox terminatorCombo;
        private ComboBox controlCombo;
        private ComboBox parityCombo;
        private ComboBox stopBitsCombo;
        private ComboBox dataBitsCombo;
        private ComboBox boudRateCombo;
        private Button sendButton;
        private TextBox inputTextBox;
        private RadioButton receiveRadioButton;
        private RadioButton transmitRadioButton;
        private GroupBox radioGroupBox;
        private CheckBox echoCheckBox;
        private Button pingButton;
        private RadioButton transceiveRadioButton;
    }
}
