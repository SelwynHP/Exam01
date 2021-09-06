
namespace WinFormsApp1.GUI
{
    partial class MoneyExchangeForm
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
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.radioButtonFromKRW = new System.Windows.Forms.RadioButton();
            this.radioButtonFromGBP = new System.Windows.Forms.RadioButton();
            this.radioButtonFromEUR = new System.Windows.Forms.RadioButton();
            this.radioButtonFromUSD = new System.Windows.Forms.RadioButton();
            this.radioButtonFromCAD = new System.Windows.Forms.RadioButton();
            this.groupBoxTo = new System.Windows.Forms.GroupBox();
            this.radioButtonToKRW = new System.Windows.Forms.RadioButton();
            this.radioButtonToGBP = new System.Windows.Forms.RadioButton();
            this.radioButtonToEUR = new System.Windows.Forms.RadioButton();
            this.radioButtonToUSD = new System.Windows.Forms.RadioButton();
            this.radioButtonToCAD = new System.Windows.Forms.RadioButton();
            this.textBoxFromAmount = new System.Windows.Forms.TextBox();
            this.textBoxToAmount = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxFrom.SuspendLayout();
            this.groupBoxTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFrom
            // 
            this.groupBoxFrom.Controls.Add(this.radioButtonFromKRW);
            this.groupBoxFrom.Controls.Add(this.radioButtonFromGBP);
            this.groupBoxFrom.Controls.Add(this.radioButtonFromEUR);
            this.groupBoxFrom.Controls.Add(this.radioButtonFromUSD);
            this.groupBoxFrom.Controls.Add(this.radioButtonFromCAD);
            this.groupBoxFrom.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFrom.Name = "groupBoxFrom";
            this.groupBoxFrom.Size = new System.Drawing.Size(141, 162);
            this.groupBoxFrom.TabIndex = 0;
            this.groupBoxFrom.TabStop = false;
            this.groupBoxFrom.Text = "From";
            // 
            // radioButtonFromKRW
            // 
            this.radioButtonFromKRW.AutoSize = true;
            this.radioButtonFromKRW.Location = new System.Drawing.Point(6, 122);
            this.radioButtonFromKRW.Name = "radioButtonFromKRW";
            this.radioButtonFromKRW.Size = new System.Drawing.Size(50, 19);
            this.radioButtonFromKRW.TabIndex = 4;
            this.radioButtonFromKRW.TabStop = true;
            this.radioButtonFromKRW.Text = "KRW";
            this.radioButtonFromKRW.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromGBP
            // 
            this.radioButtonFromGBP.AutoSize = true;
            this.radioButtonFromGBP.Location = new System.Drawing.Point(6, 97);
            this.radioButtonFromGBP.Name = "radioButtonFromGBP";
            this.radioButtonFromGBP.Size = new System.Drawing.Size(47, 19);
            this.radioButtonFromGBP.TabIndex = 3;
            this.radioButtonFromGBP.TabStop = true;
            this.radioButtonFromGBP.Text = "GBP";
            this.radioButtonFromGBP.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromEUR
            // 
            this.radioButtonFromEUR.AutoSize = true;
            this.radioButtonFromEUR.Location = new System.Drawing.Point(6, 72);
            this.radioButtonFromEUR.Name = "radioButtonFromEUR";
            this.radioButtonFromEUR.Size = new System.Drawing.Size(46, 19);
            this.radioButtonFromEUR.TabIndex = 2;
            this.radioButtonFromEUR.TabStop = true;
            this.radioButtonFromEUR.Text = "EUR";
            this.radioButtonFromEUR.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromUSD
            // 
            this.radioButtonFromUSD.AutoSize = true;
            this.radioButtonFromUSD.Location = new System.Drawing.Point(6, 47);
            this.radioButtonFromUSD.Name = "radioButtonFromUSD";
            this.radioButtonFromUSD.Size = new System.Drawing.Size(47, 19);
            this.radioButtonFromUSD.TabIndex = 1;
            this.radioButtonFromUSD.TabStop = true;
            this.radioButtonFromUSD.Text = "USD";
            this.radioButtonFromUSD.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromCAD
            // 
            this.radioButtonFromCAD.AutoSize = true;
            this.radioButtonFromCAD.Location = new System.Drawing.Point(6, 22);
            this.radioButtonFromCAD.Name = "radioButtonFromCAD";
            this.radioButtonFromCAD.Size = new System.Drawing.Size(49, 19);
            this.radioButtonFromCAD.TabIndex = 0;
            this.radioButtonFromCAD.TabStop = true;
            this.radioButtonFromCAD.Text = "CAD";
            this.radioButtonFromCAD.UseVisualStyleBackColor = true;
            // 
            // groupBoxTo
            // 
            this.groupBoxTo.Controls.Add(this.radioButtonToKRW);
            this.groupBoxTo.Controls.Add(this.radioButtonToGBP);
            this.groupBoxTo.Controls.Add(this.radioButtonToEUR);
            this.groupBoxTo.Controls.Add(this.radioButtonToUSD);
            this.groupBoxTo.Controls.Add(this.radioButtonToCAD);
            this.groupBoxTo.Location = new System.Drawing.Point(217, 12);
            this.groupBoxTo.Name = "groupBoxTo";
            this.groupBoxTo.Size = new System.Drawing.Size(141, 162);
            this.groupBoxTo.TabIndex = 1;
            this.groupBoxTo.TabStop = false;
            this.groupBoxTo.Text = "To";
            // 
            // radioButtonToKRW
            // 
            this.radioButtonToKRW.AutoSize = true;
            this.radioButtonToKRW.Location = new System.Drawing.Point(6, 122);
            this.radioButtonToKRW.Name = "radioButtonToKRW";
            this.radioButtonToKRW.Size = new System.Drawing.Size(50, 19);
            this.radioButtonToKRW.TabIndex = 4;
            this.radioButtonToKRW.TabStop = true;
            this.radioButtonToKRW.Text = "KRW";
            this.radioButtonToKRW.UseVisualStyleBackColor = true;
            // 
            // radioButtonToGBP
            // 
            this.radioButtonToGBP.AutoSize = true;
            this.radioButtonToGBP.Location = new System.Drawing.Point(6, 97);
            this.radioButtonToGBP.Name = "radioButtonToGBP";
            this.radioButtonToGBP.Size = new System.Drawing.Size(47, 19);
            this.radioButtonToGBP.TabIndex = 3;
            this.radioButtonToGBP.TabStop = true;
            this.radioButtonToGBP.Text = "GBP";
            this.radioButtonToGBP.UseVisualStyleBackColor = true;
            // 
            // radioButtonToEUR
            // 
            this.radioButtonToEUR.AutoSize = true;
            this.radioButtonToEUR.Location = new System.Drawing.Point(6, 72);
            this.radioButtonToEUR.Name = "radioButtonToEUR";
            this.radioButtonToEUR.Size = new System.Drawing.Size(46, 19);
            this.radioButtonToEUR.TabIndex = 2;
            this.radioButtonToEUR.TabStop = true;
            this.radioButtonToEUR.Text = "EUR";
            this.radioButtonToEUR.UseVisualStyleBackColor = true;
            // 
            // radioButtonToUSD
            // 
            this.radioButtonToUSD.AutoSize = true;
            this.radioButtonToUSD.Location = new System.Drawing.Point(6, 47);
            this.radioButtonToUSD.Name = "radioButtonToUSD";
            this.radioButtonToUSD.Size = new System.Drawing.Size(47, 19);
            this.radioButtonToUSD.TabIndex = 1;
            this.radioButtonToUSD.TabStop = true;
            this.radioButtonToUSD.Text = "USD";
            this.radioButtonToUSD.UseVisualStyleBackColor = true;
            // 
            // radioButtonToCAD
            // 
            this.radioButtonToCAD.AutoSize = true;
            this.radioButtonToCAD.Location = new System.Drawing.Point(6, 22);
            this.radioButtonToCAD.Name = "radioButtonToCAD";
            this.radioButtonToCAD.Size = new System.Drawing.Size(49, 19);
            this.radioButtonToCAD.TabIndex = 0;
            this.radioButtonToCAD.TabStop = true;
            this.radioButtonToCAD.Text = "CAD";
            this.radioButtonToCAD.UseVisualStyleBackColor = true;
            // 
            // textBoxFromAmount
            // 
            this.textBoxFromAmount.Location = new System.Drawing.Point(12, 180);
            this.textBoxFromAmount.Name = "textBoxFromAmount";
            this.textBoxFromAmount.Size = new System.Drawing.Size(141, 23);
            this.textBoxFromAmount.TabIndex = 5;
            // 
            // textBoxToAmount
            // 
            this.textBoxToAmount.Location = new System.Drawing.Point(217, 180);
            this.textBoxToAmount.Name = "textBoxToAmount";
            this.textBoxToAmount.ReadOnly = true;
            this.textBoxToAmount.Size = new System.Drawing.Size(141, 23);
            this.textBoxToAmount.TabIndex = 6;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(12, 218);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 7;
            this.buttonConvert.Text = "&Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(147, 218);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(75, 23);
            this.buttonReadFile.TabIndex = 8;
            this.buttonReadFile.Text = "&Read File";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(283, 218);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MoneyExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 260);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxToAmount);
            this.Controls.Add(this.textBoxFromAmount);
            this.Controls.Add(this.groupBoxTo);
            this.Controls.Add(this.groupBoxFrom);
            this.Name = "MoneyExchangeForm";
            this.Text = "Money Exchange";
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxFrom.PerformLayout();
            this.groupBoxTo.ResumeLayout(false);
            this.groupBoxTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFrom;
        private System.Windows.Forms.RadioButton radioButtonFromKRW;
        private System.Windows.Forms.RadioButton radioButtonFromGBP;
        private System.Windows.Forms.RadioButton radioButtonFromEUR;
        private System.Windows.Forms.RadioButton radioButtonFromUSD;
        private System.Windows.Forms.RadioButton radioButtonFromCAD;
        private System.Windows.Forms.GroupBox groupBoxTo;
        private System.Windows.Forms.RadioButton radioButtonToKRW;
        private System.Windows.Forms.RadioButton radioButtonToGBP;
        private System.Windows.Forms.RadioButton radioButtonToEUR;
        private System.Windows.Forms.RadioButton radioButtonToUSD;
        private System.Windows.Forms.RadioButton radioButtonToCAD;
        private System.Windows.Forms.TextBox textBoxFromAmount;
        private System.Windows.Forms.TextBox textBoxToAmount;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Button buttonExit;
    }
}