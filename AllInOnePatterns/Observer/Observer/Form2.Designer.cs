namespace Observer
{
    partial class Form2
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
            buttonSubscribe = new Button();
            buttonUnsubscribe = new Button();
            buttonCollection = new Button();
            SuspendLayout();
            // 
            // buttonSubscribe
            // 
            buttonSubscribe.Location = new Point(167, 135);
            buttonSubscribe.Name = "buttonSubscribe";
            buttonSubscribe.Size = new Size(170, 29);
            buttonSubscribe.TabIndex = 0;
            buttonSubscribe.Text = "Abone ol";
            buttonSubscribe.UseVisualStyleBackColor = true;
            buttonSubscribe.Click += buttonSubscribe_Click;
            // 
            // buttonUnsubscribe
            // 
            buttonUnsubscribe.Location = new Point(167, 194);
            buttonUnsubscribe.Name = "buttonUnsubscribe";
            buttonUnsubscribe.Size = new Size(170, 29);
            buttonUnsubscribe.TabIndex = 1;
            buttonUnsubscribe.Text = "Abonelikten çık";
            buttonUnsubscribe.UseVisualStyleBackColor = true;
            buttonUnsubscribe.Click += buttonUnsubscribe_Click;
            // 
            // buttonCollection
            // 
            buttonCollection.Location = new Point(168, 266);
            buttonCollection.Name = "buttonCollection";
            buttonCollection.Size = new Size(169, 50);
            buttonCollection.TabIndex = 2;
            buttonCollection.Text = "Collection Demo";
            buttonCollection.UseVisualStyleBackColor = true;
            buttonCollection.Click += buttonCollection_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 367);
            Controls.Add(buttonCollection);
            Controls.Add(buttonUnsubscribe);
            Controls.Add(buttonSubscribe);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSubscribe;
        private Button buttonUnsubscribe;
        private Button buttonCollection;
    }
}