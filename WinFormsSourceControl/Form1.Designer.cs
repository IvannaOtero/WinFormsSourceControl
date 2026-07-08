namespace WinFormsSourceControl
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
            label1 = new Label();
            label2 = new Label();
            lengthTxt = new TextBox();
            widthTxt = new TextBox();
            calculateAreaAndPerimeterBtn = new Button();
            areaTxt = new TextBox();
            perimeterTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 56);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 0;
            label1.Text = "Length:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 125);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 1;
            label2.Text = "Width:";
            // 
            // lengthTxt
            // 
            lengthTxt.Location = new Point(286, 56);
            lengthTxt.Name = "lengthTxt";
            lengthTxt.Size = new Size(150, 31);
            lengthTxt.TabIndex = 2;
            // 
            // widthTxt
            // 
            widthTxt.Location = new Point(286, 119);
            widthTxt.Name = "widthTxt";
            widthTxt.Size = new Size(150, 31);
            widthTxt.TabIndex = 3;
            // 
            // calculateAreaAndPerimeterBtn
            // 
            calculateAreaAndPerimeterBtn.Location = new Point(30, 181);
            calculateAreaAndPerimeterBtn.Name = "calculateAreaAndPerimeterBtn";
            calculateAreaAndPerimeterBtn.Size = new Size(181, 84);
            calculateAreaAndPerimeterBtn.TabIndex = 4;
            calculateAreaAndPerimeterBtn.Text = "Calculate Area and Perimeter";
            calculateAreaAndPerimeterBtn.UseVisualStyleBackColor = true;
            calculateAreaAndPerimeterBtn.Click += calculateAreaAndPerimeterBtn_Click;
            // 
            // areaTxt
            // 
            areaTxt.Location = new Point(375, 181);
            areaTxt.Name = "areaTxt";
            areaTxt.ReadOnly = true;
            areaTxt.Size = new Size(150, 31);
            areaTxt.TabIndex = 5;
            // 
            // perimeterTxt
            // 
            perimeterTxt.Location = new Point(375, 234);
            perimeterTxt.Name = "perimeterTxt";
            perimeterTxt.ReadOnly = true;
            perimeterTxt.Size = new Size(150, 31);
            perimeterTxt.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 326);
            Controls.Add(perimeterTxt);
            Controls.Add(areaTxt);
            Controls.Add(calculateAreaAndPerimeterBtn);
            Controls.Add(widthTxt);
            Controls.Add(lengthTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox lengthTxt;
        private TextBox widthTxt;
        private Button calculateAreaAndPerimeterBtn;
        private TextBox areaTxt;
        private TextBox perimeterTxt;
    }
}
