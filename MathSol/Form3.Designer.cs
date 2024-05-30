namespace MathSol
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.sort_btn = new System.Windows.Forms.Button();
            this.selectWayToSort_combo_box = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.output_label = new System.Windows.Forms.RichTextBox();
            this.output_help_label = new System.Windows.Forms.Label();
            this.dummy = new System.Windows.Forms.RichTextBox();
            this.textBoxExample = new System.Windows.Forms.TextBox();
            this.input_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hãy nhập dãy số";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sort_btn
            // 
            this.sort_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sort_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.sort_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sort_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort_btn.ForeColor = System.Drawing.Color.White;
            this.sort_btn.Location = new System.Drawing.Point(450, 102);
            this.sort_btn.Margin = new System.Windows.Forms.Padding(2);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(91, 40);
            this.sort_btn.TabIndex = 15;
            this.sort_btn.Text = "Sắp xếp";
            this.sort_btn.UseVisualStyleBackColor = false;
            this.sort_btn.Click += new System.EventHandler(this.Sort_Click);
            // 
            // selectWayToSort_combo_box
            // 
            this.selectWayToSort_combo_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectWayToSort_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectWayToSort_combo_box.FormattingEnabled = true;
            this.selectWayToSort_combo_box.Items.AddRange(new object[] {
            "Tăng dần",
            "Giảm dần"});
            this.selectWayToSort_combo_box.Location = new System.Drawing.Point(450, 78);
            this.selectWayToSort_combo_box.Margin = new System.Windows.Forms.Padding(2);
            this.selectWayToSort_combo_box.Name = "selectWayToSort_combo_box";
            this.selectWayToSort_combo_box.Size = new System.Drawing.Size(92, 21);
            this.selectWayToSort_combo_box.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(449, 145);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // output_label
            // 
            this.output_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.output_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.output_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_label.ForeColor = System.Drawing.Color.Black;
            this.output_label.Location = new System.Drawing.Point(60, 223);
            this.output_label.Margin = new System.Windows.Forms.Padding(2);
            this.output_label.Name = "output_label";
            this.output_label.ReadOnly = true;
            this.output_label.Size = new System.Drawing.Size(385, 119);
            this.output_label.TabIndex = 23;
            this.output_label.Text = "";
            // 
            // output_help_label
            // 
            this.output_help_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.output_help_label.AutoSize = true;
            this.output_help_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_help_label.ForeColor = System.Drawing.Color.Black;
            this.output_help_label.Location = new System.Drawing.Point(60, 197);
            this.output_help_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.output_help_label.Name = "output_help_label";
            this.output_help_label.Size = new System.Drawing.Size(15, 24);
            this.output_help_label.TabIndex = 24;
            this.output_help_label.Text = " ";
            // 
            // dummy
            // 
            this.dummy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dummy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dummy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dummy.ForeColor = System.Drawing.Color.White;
            this.dummy.Location = new System.Drawing.Point(-75, -81);
            this.dummy.Margin = new System.Windows.Forms.Padding(2);
            this.dummy.Name = "dummy";
            this.dummy.Size = new System.Drawing.Size(132, 39);
            this.dummy.TabIndex = 25;
            this.dummy.Text = "";
            // 
            // textBoxExample
            // 
            this.textBoxExample.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxExample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBoxExample.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExample.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxExample.Location = new System.Drawing.Point(64, 85);
            this.textBoxExample.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxExample.Multiline = true;
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.Size = new System.Drawing.Size(218, 24);
            this.textBoxExample.TabIndex = 21;
            this.textBoxExample.Text = "VD: 1, 2, 5, -6, 77.22, 21";
            this.textBoxExample.Enter += new System.EventHandler(this.hiddenExample);
            // 
            // input_richTextBox
            // 
            this.input_richTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.input_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_richTextBox.ForeColor = System.Drawing.Color.White;
            this.input_richTextBox.Location = new System.Drawing.Point(60, 78);
            this.input_richTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.input_richTextBox.Name = "input_richTextBox";
            this.input_richTextBox.Size = new System.Drawing.Size(386, 107);
            this.input_richTextBox.TabIndex = 0;
            this.input_richTextBox.Text = "";
            this.input_richTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.input_richTextBox.Enter += new System.EventHandler(this.hiddenExample);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.output_help_label);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.textBoxExample);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectWayToSort_combo_box);
            this.Controls.Add(this.sort_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_richTextBox);
            this.Controls.Add(this.dummy);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Click += new System.EventHandler(this.focusToDummy);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.ComboBox selectWayToSort_combo_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox output_label;
        private System.Windows.Forms.Label output_help_label;
        private System.Windows.Forms.RichTextBox dummy;
        private System.Windows.Forms.TextBox textBoxExample;
        private System.Windows.Forms.RichTextBox input_richTextBox;
    }
}