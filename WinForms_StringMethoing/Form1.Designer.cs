namespace WinForms_StringMethoing
{
    partial class Form1
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
            txt_Fullname = new TextBox();
            txt_Title = new TextBox();
            txt_FirstName = new TextBox();
            txt_LastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_SplitName = new Button();
            SuspendLayout();
            // 
            // txt_Fullname
            // 
            txt_Fullname.Location = new Point(138, 104);
            txt_Fullname.Name = "txt_Fullname";
            txt_Fullname.Size = new Size(337, 27);
            txt_Fullname.TabIndex = 1;
            txt_Fullname.Text = "นายเกียรติศักดิ์ สังรวมใจ";
            // 
            // txt_Title
            // 
            txt_Title.Location = new Point(138, 184);
            txt_Title.Name = "txt_Title";
            txt_Title.Size = new Size(183, 27);
            txt_Title.TabIndex = 2;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(138, 236);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(183, 27);
            txt_FirstName.TabIndex = 3;
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(138, 286);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(183, 27);
            txt_LastName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 107);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 6;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 187);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 243);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 8;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 289);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 9;
            label4.Text = "นามสกุล";
            // 
            // btn_SplitName
            // 
            btn_SplitName.Location = new Point(543, 102);
            btn_SplitName.Name = "btn_SplitName";
            btn_SplitName.Size = new Size(124, 53);
            btn_SplitName.TabIndex = 10;
            btn_SplitName.Text = "แยกชื่อสกุล";
            btn_SplitName.UseVisualStyleBackColor = true;
            btn_SplitName.Click += btn_SplitName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 450);
            Controls.Add(btn_SplitName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_LastName);
            Controls.Add(txt_FirstName);
            Controls.Add(txt_Title);
            Controls.Add(txt_Fullname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Fullname;
        private TextBox txt_Title;
        private TextBox txt_FirstName;
        private TextBox txt_LastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_SplitName;
    }
}
