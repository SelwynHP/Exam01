
namespace WinFormsApp1
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLotto649 = new System.Windows.Forms.Label();
            this.labelLottoMax = new System.Windows.Forms.Label();
            this.pictureBoxLotto649 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLottoMax = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxTemperatureConvert = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoneyExchange = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBoxCalculator = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBoxIpv4Validator = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLotto649)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLottoMax)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperatureConvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoneyExchange)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalculator)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpv4Validator)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 369);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generated Numbers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLotto649);
            this.groupBox1.Controls.Add(this.labelLottoMax);
            this.groupBox1.Controls.Add(this.pictureBoxLotto649);
            this.groupBox1.Controls.Add(this.pictureBoxLottoMax);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lotto";
            // 
            // labelLotto649
            // 
            this.labelLotto649.AutoSize = true;
            this.labelLotto649.Location = new System.Drawing.Point(267, 201);
            this.labelLotto649.Name = "labelLotto649";
            this.labelLotto649.Size = new System.Drawing.Size(53, 15);
            this.labelLotto649.TabIndex = 3;
            this.labelLotto649.Text = "Lotto649";
            this.labelLotto649.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLottoMax
            // 
            this.labelLottoMax.AutoSize = true;
            this.labelLottoMax.Location = new System.Drawing.Point(107, 201);
            this.labelLottoMax.Name = "labelLottoMax";
            this.labelLottoMax.Size = new System.Drawing.Size(61, 15);
            this.labelLottoMax.TabIndex = 2;
            this.labelLottoMax.Text = "Lotto Max";
            this.labelLottoMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxLotto649
            // 
            this.pictureBoxLotto649.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLotto649.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLotto649.Image")));
            this.pictureBoxLotto649.Location = new System.Drawing.Point(218, 44);
            this.pictureBoxLotto649.Name = "pictureBoxLotto649";
            this.pictureBoxLotto649.Size = new System.Drawing.Size(150, 154);
            this.pictureBoxLotto649.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLotto649.TabIndex = 1;
            this.pictureBoxLotto649.TabStop = false;
            this.pictureBoxLotto649.Click += new System.EventHandler(this.pictureBoxLotto649_Click);
            // 
            // pictureBoxLottoMax
            // 
            this.pictureBoxLottoMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLottoMax.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLottoMax.Image")));
            this.pictureBoxLottoMax.Location = new System.Drawing.Point(62, 44);
            this.pictureBoxLottoMax.Name = "pictureBoxLottoMax";
            this.pictureBoxLottoMax.Size = new System.Drawing.Size(150, 154);
            this.pictureBoxLottoMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLottoMax.TabIndex = 0;
            this.pictureBoxLottoMax.TabStop = false;
            this.pictureBoxLottoMax.Click += new System.EventHandler(this.pictureBoxLottoMax_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conversions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBoxTemperatureConvert);
            this.groupBox2.Controls.Add(this.pictureBoxMoneyExchange);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temperature Convert";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Money Exchange";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxTemperatureConvert
            // 
            this.pictureBoxTemperatureConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTemperatureConvert.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTemperatureConvert.Image")));
            this.pictureBoxTemperatureConvert.Location = new System.Drawing.Point(218, 44);
            this.pictureBoxTemperatureConvert.Name = "pictureBoxTemperatureConvert";
            this.pictureBoxTemperatureConvert.Size = new System.Drawing.Size(150, 154);
            this.pictureBoxTemperatureConvert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTemperatureConvert.TabIndex = 1;
            this.pictureBoxTemperatureConvert.TabStop = false;
            this.pictureBoxTemperatureConvert.Click += new System.EventHandler(this.pictureBoxTemperatureConvert_Click);
            // 
            // pictureBoxMoneyExchange
            // 
            this.pictureBoxMoneyExchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMoneyExchange.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMoneyExchange.Image")));
            this.pictureBoxMoneyExchange.Location = new System.Drawing.Point(62, 44);
            this.pictureBoxMoneyExchange.Name = "pictureBoxMoneyExchange";
            this.pictureBoxMoneyExchange.Size = new System.Drawing.Size(150, 154);
            this.pictureBoxMoneyExchange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMoneyExchange.TabIndex = 0;
            this.pictureBoxMoneyExchange.TabStop = false;
            this.pictureBoxMoneyExchange.Click += new System.EventHandler(this.pictureBoxMoneyExchange_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBoxCalculator);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Simple Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCalculator
            // 
            this.pictureBoxCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCalculator.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCalculator.Image")));
            this.pictureBoxCalculator.Location = new System.Drawing.Point(253, 57);
            this.pictureBoxCalculator.Name = "pictureBoxCalculator";
            this.pictureBoxCalculator.Size = new System.Drawing.Size(150, 154);
            this.pictureBoxCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCalculator.TabIndex = 1;
            this.pictureBoxCalculator.TabStop = false;
            this.pictureBoxCalculator.Click += new System.EventHandler(this.pictureBoxCalculator_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBoxIpv4Validator);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 341);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IPv4 Validator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBoxIpv4Validator
            // 
            this.pictureBoxIpv4Validator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxIpv4Validator.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIpv4Validator.Image")));
            this.pictureBoxIpv4Validator.Location = new System.Drawing.Point(309, 93);
            this.pictureBoxIpv4Validator.Name = "pictureBoxIpv4Validator";
            this.pictureBoxIpv4Validator.Size = new System.Drawing.Size(150, 154);
            this.pictureBoxIpv4Validator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIpv4Validator.TabIndex = 1;
            this.pictureBoxIpv4Validator.TabStop = false;
            this.pictureBoxIpv4Validator.Click += new System.EventHandler(this.pictureBoxIpv4Validator_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(709, 396);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 438);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLotto649)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLottoMax)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperatureConvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoneyExchange)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalculator)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpv4Validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLotto649;
        private System.Windows.Forms.Label labelLottoMax;
        private System.Windows.Forms.PictureBox pictureBoxLotto649;
        private System.Windows.Forms.PictureBox pictureBoxLottoMax;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxTemperatureConvert;
        private System.Windows.Forms.PictureBox pictureBoxMoneyExchange;
        private System.Windows.Forms.PictureBox pictureBoxCalculator;
        private System.Windows.Forms.PictureBox pictureBoxIpv4Validator;
    }
}

