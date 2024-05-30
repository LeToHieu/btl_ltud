namespace MathSol
{
    partial class Form4
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
            this.output_help_label = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.RichTextBox();
            this.textBoxExample = new System.Windows.Forms.TextBox();
            this.clearAll = new System.Windows.Forms.Button();
            this.caculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_richTextBox = new System.Windows.Forms.RichTextBox();
            this.dummy = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // output_help_label
            // 
            this.output_help_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.output_help_label.AutoSize = true;
            this.output_help_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_help_label.ForeColor = System.Drawing.Color.Black;
            this.output_help_label.Location = new System.Drawing.Point(61, 200);
            this.output_help_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.output_help_label.Name = "output_help_label";
            this.output_help_label.Size = new System.Drawing.Size(15, 24);
            this.output_help_label.TabIndex = 35;
            this.output_help_label.Text = " ";
            // 
            // output_label
            // 
            this.output_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.output_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.output_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_label.ForeColor = System.Drawing.Color.Black;
            this.output_label.Location = new System.Drawing.Point(61, 226);
            this.output_label.Margin = new System.Windows.Forms.Padding(2);
            this.output_label.Name = "output_label";
            this.output_label.ReadOnly = true;
            this.output_label.Size = new System.Drawing.Size(385, 119);
            this.output_label.TabIndex = 34;
            this.output_label.Text = "";
            // 
            // textBoxExample
            // 
            this.textBoxExample.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxExample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBoxExample.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExample.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxExample.Location = new System.Drawing.Point(65, 87);
            this.textBoxExample.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxExample.Multiline = true;
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.Size = new System.Drawing.Size(218, 24);
            this.textBoxExample.TabIndex = 33;
            this.textBoxExample.Text = "VD: 1, 2, 5, -6, 77.22, 21";
            this.textBoxExample.Enter += new System.EventHandler(this.hiddenExample);
            // 
            // clearAll
            // 
            this.clearAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAll.ForeColor = System.Drawing.Color.White;
            this.clearAll.Location = new System.Drawing.Point(451, 125);
            this.clearAll.Margin = new System.Windows.Forms.Padding(2);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(91, 40);
            this.clearAll.TabIndex = 32;
            this.clearAll.Text = "Clear";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // caculate
            // 
            this.caculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.caculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.caculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caculate.ForeColor = System.Drawing.Color.White;
            this.caculate.Location = new System.Drawing.Point(451, 81);
            this.caculate.Margin = new System.Windows.Forms.Padding(2);
            this.caculate.Name = "caculate";
            this.caculate.Size = new System.Drawing.Size(91, 40);
            this.caculate.TabIndex = 28;
            this.caculate.Text = "Tính toán";
            this.caculate.UseVisualStyleBackColor = false;
            this.caculate.Click += new System.EventHandler(this.Cacl_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hãy nhập dãy số";
            // 
            // input_richTextBox
            // 
            this.input_richTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.input_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_richTextBox.ForeColor = System.Drawing.Color.White;
            this.input_richTextBox.Location = new System.Drawing.Point(61, 80);
            this.input_richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.input_richTextBox.Name = "input_richTextBox";
            this.input_richTextBox.Size = new System.Drawing.Size(386, 107);
            this.input_richTextBox.TabIndex = 26;
            this.input_richTextBox.Text = "";
            this.input_richTextBox.Enter += new System.EventHandler(this.hiddenExample);
            // 
            // dummy
            // 
            this.dummy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dummy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dummy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dummy.ForeColor = System.Drawing.Color.White;
            this.dummy.Location = new System.Drawing.Point(-75, -85);
            this.dummy.Margin = new System.Windows.Forms.Padding(2);
            this.dummy.Name = "dummy";
            this.dummy.Size = new System.Drawing.Size(132, 39);
            this.dummy.TabIndex = 36;
            this.dummy.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 371);
            this.Controls.Add(this.output_help_label);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.textBoxExample);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.caculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_richTextBox);
            this.Controls.Add(this.dummy);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Click += new System.EventHandler(this.focusToDummy);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output_help_label;
        private System.Windows.Forms.RichTextBox output_label;
        private System.Windows.Forms.TextBox textBoxExample;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button caculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox input_richTextBox;
        private System.Windows.Forms.RichTextBox dummy;
    }
}