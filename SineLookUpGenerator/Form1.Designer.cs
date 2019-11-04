namespace SineLookUpGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaxVoltageMSG = new System.Windows.Forms.Label();
            this.lblNoOfPointsMsg = new System.Windows.Forms.Label();
            this.lblVoltageMsg = new System.Windows.Forms.Label();
            this.lblNoPerRowMsg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVoltage = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.radioHex = new System.Windows.Forms.RadioButton();
            this.radioDecimal = new System.Windows.Forms.RadioButton();
            this.txtNoPerRow = new System.Windows.Forms.TextBox();
            this.txtMaxVoltage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoOfPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richtxtResults = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaxVoltageMSG);
            this.groupBox1.Controls.Add(this.lblNoOfPointsMsg);
            this.groupBox1.Controls.Add(this.lblVoltageMsg);
            this.groupBox1.Controls.Add(this.lblNoPerRowMsg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtVoltage);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.radioHex);
            this.groupBox1.Controls.Add(this.radioDecimal);
            this.groupBox1.Controls.Add(this.txtNoPerRow);
            this.groupBox1.Controls.Add(this.txtMaxVoltage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNoOfPoints);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sine Look Up Table Generator Input";
            // 
            // lblMaxVoltageMSG
            // 
            this.lblMaxVoltageMSG.AutoSize = true;
            this.lblMaxVoltageMSG.ForeColor = System.Drawing.Color.Red;
            this.lblMaxVoltageMSG.Location = new System.Drawing.Point(236, 101);
            this.lblMaxVoltageMSG.Name = "lblMaxVoltageMSG";
            this.lblMaxVoltageMSG.Size = new System.Drawing.Size(50, 13);
            this.lblMaxVoltageMSG.TabIndex = 14;
            this.lblMaxVoltageMSG.Text = "Message";
            // 
            // lblNoOfPointsMsg
            // 
            this.lblNoOfPointsMsg.AutoSize = true;
            this.lblNoOfPointsMsg.ForeColor = System.Drawing.Color.Red;
            this.lblNoOfPointsMsg.Location = new System.Drawing.Point(236, 33);
            this.lblNoOfPointsMsg.Name = "lblNoOfPointsMsg";
            this.lblNoOfPointsMsg.Size = new System.Drawing.Size(50, 13);
            this.lblNoOfPointsMsg.TabIndex = 13;
            this.lblNoOfPointsMsg.Text = "Message";
            // 
            // lblVoltageMsg
            // 
            this.lblVoltageMsg.AutoSize = true;
            this.lblVoltageMsg.ForeColor = System.Drawing.Color.Red;
            this.lblVoltageMsg.Location = new System.Drawing.Point(236, 65);
            this.lblVoltageMsg.Name = "lblVoltageMsg";
            this.lblVoltageMsg.Size = new System.Drawing.Size(50, 13);
            this.lblVoltageMsg.TabIndex = 12;
            this.lblVoltageMsg.Text = "Message";
            // 
            // lblNoPerRowMsg
            // 
            this.lblNoPerRowMsg.AutoSize = true;
            this.lblNoPerRowMsg.ForeColor = System.Drawing.Color.Red;
            this.lblNoPerRowMsg.Location = new System.Drawing.Point(236, 132);
            this.lblNoPerRowMsg.Name = "lblNoPerRowMsg";
            this.lblNoPerRowMsg.Size = new System.Drawing.Size(50, 13);
            this.lblNoPerRowMsg.TabIndex = 11;
            this.lblNoPerRowMsg.Text = "Message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Voltage Value";
            // 
            // txtVoltage
            // 
            this.txtVoltage.Location = new System.Drawing.Point(130, 62);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.Size = new System.Drawing.Size(100, 20);
            this.txtVoltage.TabIndex = 9;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(239, 205);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // radioHex
            // 
            this.radioHex.AutoSize = true;
            this.radioHex.Location = new System.Drawing.Point(358, 178);
            this.radioHex.Name = "radioHex";
            this.radioHex.Size = new System.Drawing.Size(44, 17);
            this.radioHex.TabIndex = 7;
            this.radioHex.TabStop = true;
            this.radioHex.Text = "Hex";
            this.radioHex.UseVisualStyleBackColor = true;
            // 
            // radioDecimal
            // 
            this.radioDecimal.AutoSize = true;
            this.radioDecimal.Location = new System.Drawing.Point(130, 178);
            this.radioDecimal.Name = "radioDecimal";
            this.radioDecimal.Size = new System.Drawing.Size(63, 17);
            this.radioDecimal.TabIndex = 6;
            this.radioDecimal.TabStop = true;
            this.radioDecimal.Text = "Decimal";
            this.radioDecimal.UseVisualStyleBackColor = true;
            // 
            // txtNoPerRow
            // 
            this.txtNoPerRow.Location = new System.Drawing.Point(130, 129);
            this.txtNoPerRow.Name = "txtNoPerRow";
            this.txtNoPerRow.Size = new System.Drawing.Size(100, 20);
            this.txtNoPerRow.TabIndex = 5;
            // 
            // txtMaxVoltage
            // 
            this.txtMaxVoltage.Location = new System.Drawing.Point(130, 94);
            this.txtMaxVoltage.Name = "txtMaxVoltage";
            this.txtMaxVoltage.Size = new System.Drawing.Size(100, 20);
            this.txtMaxVoltage.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numbers Per Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Voltage Value";
            // 
            // txtNoOfPoints
            // 
            this.txtNoOfPoints.Location = new System.Drawing.Point(130, 30);
            this.txtNoOfPoints.Name = "txtNoOfPoints";
            this.txtNoOfPoints.Size = new System.Drawing.Size(100, 20);
            this.txtNoOfPoints.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of points";
            // 
            // richtxtResults
            // 
            this.richtxtResults.BackColor = System.Drawing.Color.White;
            this.richtxtResults.Location = new System.Drawing.Point(37, 288);
            this.richtxtResults.Name = "richtxtResults";
            this.richtxtResults.ReadOnly = true;
            this.richtxtResults.Size = new System.Drawing.Size(540, 192);
            this.richtxtResults.TabIndex = 1;
            this.richtxtResults.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rerults";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richtxtResults);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sine Look Up Table Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton radioHex;
        private System.Windows.Forms.RadioButton radioDecimal;
        private System.Windows.Forms.TextBox txtNoPerRow;
        private System.Windows.Forms.TextBox txtMaxVoltage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoOfPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richtxtResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVoltage;
        private System.Windows.Forms.Label lblVoltageMsg;
        private System.Windows.Forms.Label lblNoPerRowMsg;
        private System.Windows.Forms.Label lblMaxVoltageMSG;
        private System.Windows.Forms.Label lblNoOfPointsMsg;
    }
}

