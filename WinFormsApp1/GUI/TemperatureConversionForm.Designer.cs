
namespace WinFormsApp1.GUI
{
    partial class TemperatureConversionForm
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxTemp1 = new System.Windows.Forms.TextBox();
            this.textBoxTemp2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCtoF = new System.Windows.Forms.RadioButton();
            this.radioButtonFtoC = new System.Windows.Forms.RadioButton();
            this.labelTemp1 = new System.Windows.Forms.Label();
            this.labelTemp2 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(199, 240);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(106, 240);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(75, 23);
            this.buttonReadFile.TabIndex = 11;
            this.buttonReadFile.Text = "&Read File";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(12, 240);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 10;
            this.buttonConvert.Text = "&Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // textBoxTemp1
            // 
            this.textBoxTemp1.Location = new System.Drawing.Point(27, 92);
            this.textBoxTemp1.Name = "textBoxTemp1";
            this.textBoxTemp1.Size = new System.Drawing.Size(100, 23);
            this.textBoxTemp1.TabIndex = 13;
            // 
            // textBoxTemp2
            // 
            this.textBoxTemp2.Location = new System.Drawing.Point(157, 92);
            this.textBoxTemp2.Name = "textBoxTemp2";
            this.textBoxTemp2.ReadOnly = true;
            this.textBoxTemp2.Size = new System.Drawing.Size(100, 23);
            this.textBoxTemp2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "to";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonCtoF
            // 
            this.radioButtonCtoF.AutoSize = true;
            this.radioButtonCtoF.Location = new System.Drawing.Point(106, 12);
            this.radioButtonCtoF.Name = "radioButtonCtoF";
            this.radioButtonCtoF.Size = new System.Drawing.Size(85, 19);
            this.radioButtonCtoF.TabIndex = 16;
            this.radioButtonCtoF.TabStop = true;
            this.radioButtonCtoF.Text = "from C to F";
            this.radioButtonCtoF.UseVisualStyleBackColor = true;
            this.radioButtonCtoF.CheckedChanged += new System.EventHandler(this.radioButtonCtoF_CheckedChanged);
            // 
            // radioButtonFtoC
            // 
            this.radioButtonFtoC.AutoSize = true;
            this.radioButtonFtoC.Location = new System.Drawing.Point(106, 37);
            this.radioButtonFtoC.Name = "radioButtonFtoC";
            this.radioButtonFtoC.Size = new System.Drawing.Size(85, 19);
            this.radioButtonFtoC.TabIndex = 17;
            this.radioButtonFtoC.TabStop = true;
            this.radioButtonFtoC.Text = "from F to C";
            this.radioButtonFtoC.UseVisualStyleBackColor = true;
            // 
            // labelTemp1
            // 
            this.labelTemp1.AutoSize = true;
            this.labelTemp1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTemp1.Location = new System.Drawing.Point(67, 118);
            this.labelTemp1.Name = "labelTemp1";
            this.labelTemp1.Size = new System.Drawing.Size(20, 21);
            this.labelTemp1.TabIndex = 18;
            this.labelTemp1.Text = "C";
            // 
            // labelTemp2
            // 
            this.labelTemp2.AutoSize = true;
            this.labelTemp2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTemp2.Location = new System.Drawing.Point(197, 118);
            this.labelTemp2.Name = "labelTemp2";
            this.labelTemp2.Size = new System.Drawing.Size(20, 21);
            this.labelTemp2.TabIndex = 19;
            this.labelTemp2.Text = "C";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMessage.Location = new System.Drawing.Point(12, 157);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.Size = new System.Drawing.Size(262, 77);
            this.textBoxMessage.TabIndex = 20;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 139);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(53, 15);
            this.labelMessage.TabIndex = 21;
            this.labelMessage.Text = "Message";
            // 
            // TemperatureConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(300, 291);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelTemp2);
            this.Controls.Add(this.labelTemp1);
            this.Controls.Add(this.radioButtonFtoC);
            this.Controls.Add(this.radioButtonCtoF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTemp2);
            this.Controls.Add(this.textBoxTemp1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.buttonConvert);
            this.Name = "TemperatureConversionForm";
            this.Text = "Temperature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textBoxTemp1;
        private System.Windows.Forms.TextBox textBoxTemp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonCtoF;
        private System.Windows.Forms.RadioButton radioButtonFtoC;
        private System.Windows.Forms.Label labelTemp1;
        private System.Windows.Forms.Label labelTemp2;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label labelMessage;
    }
}