namespace Observer
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
            buttonNewForm = new Button();
            buttonChangeColor = new Button();
            SuspendLayout();
            // 
            // buttonNewForm
            // 
            buttonNewForm.Location = new Point(92, 99);
            buttonNewForm.Name = "buttonNewForm";
            buttonNewForm.Size = new Size(181, 56);
            buttonNewForm.TabIndex = 0;
            buttonNewForm.Text = "Yeni Form Oluştur";
            buttonNewForm.UseVisualStyleBackColor = true;
            buttonNewForm.Click += buttonNewForm_Click;
            // 
            // buttonChangeColor
            // 
            buttonChangeColor.Location = new Point(94, 192);
            buttonChangeColor.Name = "buttonChangeColor";
            buttonChangeColor.Size = new Size(179, 58);
            buttonChangeColor.TabIndex = 1;
            buttonChangeColor.Text = "Renk Değiştir";
            buttonChangeColor.UseVisualStyleBackColor = true;
            buttonChangeColor.Click += buttonChangeColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 386);
            Controls.Add(buttonChangeColor);
            Controls.Add(buttonNewForm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNewForm;
        private Button buttonChangeColor;
    }
}
