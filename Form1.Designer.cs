namespace BodySort
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
            this.radioButton_newBody = new System.Windows.Forms.RadioButton();
            this.radioButton_existBody = new System.Windows.Forms.RadioButton();
            this.button_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton_newBody
            // 
            this.radioButton_newBody.AutoSize = true;
            this.radioButton_newBody.Checked = true;
            this.radioButton_newBody.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButton_newBody.Location = new System.Drawing.Point(46, 55);
            this.radioButton_newBody.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_newBody.Name = "radioButton_newBody";
            this.radioButton_newBody.Size = new System.Drawing.Size(179, 21);
            this.radioButton_newBody.TabIndex = 0;
            this.radioButton_newBody.TabStop = true;
            this.radioButton_newBody.Text = "Assemle into a new body";
            this.radioButton_newBody.UseVisualStyleBackColor = true;
            // 
            // radioButton_existBody
            // 
            this.radioButton_existBody.AutoSize = true;
            this.radioButton_existBody.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButton_existBody.Location = new System.Drawing.Point(46, 85);
            this.radioButton_existBody.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_existBody.Name = "radioButton_existBody";
            this.radioButton_existBody.Size = new System.Drawing.Size(137, 21);
            this.radioButton_existBody.TabIndex = 1;
            this.radioButton_existBody.Text = "Select target body";
            this.radioButton_existBody.UseVisualStyleBackColor = true;
            // 
            // button_Start
            // 
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Start.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Start.Location = new System.Drawing.Point(86, 129);
            this.button_Start.Margin = new System.Windows.Forms.Padding(4);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(125, 29);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Assemble";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select the option:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(271, 182);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.radioButton_existBody);
            this.Controls.Add(this.radioButton_newBody);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BodySort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_newBody;
        private System.Windows.Forms.RadioButton radioButton_existBody;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label1;
    }
}

