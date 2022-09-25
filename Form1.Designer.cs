namespace EncryptoShy
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
            this.buttonConvert = new System.Windows.Forms.Button();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.Black;
            this.buttonConvert.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.ForeColor = System.Drawing.Color.Lime;
            this.buttonConvert.Location = new System.Drawing.Point(510, 172);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(223, 61);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.BackColor = System.Drawing.Color.Black;
            this.comboBoxMode.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMode.ForeColor = System.Drawing.Color.Lime;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "ZENIT_POLAR",
            "NATZU_JOLIP"});
            this.comboBoxMode.Location = new System.Drawing.Point(186, 27);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(318, 36);
            this.comboBoxMode.TabIndex = 1;
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMode.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelMode.Location = new System.Drawing.Point(12, 20);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(168, 28);
            this.labelMode.TabIndex = 2;
            this.labelMode.Text = "Encrypt Mode:";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelMessage.Location = new System.Drawing.Point(12, 62);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(108, 28);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "Message:";
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.BackColor = System.Drawing.Color.Black;
            this.richTextBoxInput.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInput.ForeColor = System.Drawing.Color.Lime;
            this.richTextBoxInput.Location = new System.Drawing.Point(126, 71);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(378, 162);
            this.richTextBoxInput.TabIndex = 4;
            this.richTextBoxInput.Text = "";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.BackColor = System.Drawing.Color.Black;
            this.richTextBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxOutput.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOutput.ForeColor = System.Drawing.Color.Lime;
            this.richTextBoxOutput.Location = new System.Drawing.Point(739, 27);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(472, 206);
            this.richTextBoxOutput.TabIndex = 5;
            this.richTextBoxOutput.Text = "";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.Lime;
            this.labelResult.Location = new System.Drawing.Point(597, 20);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(136, 39);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1223, 563);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.buttonConvert);
            this.Name = "Form1";
            this.Text = "EncryptoShy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Label labelResult;
    }
}

