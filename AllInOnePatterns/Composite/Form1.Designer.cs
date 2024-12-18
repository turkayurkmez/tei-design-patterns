namespace Composite
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
            TreeNode treeNode1 = new TreeNode("B");
            TreeNode treeNode2 = new TreeNode("C");
            TreeNode treeNode3 = new TreeNode("A", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Node5");
            TreeNode treeNode5 = new TreeNode("Y1", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("Kategori", new TreeNode[] { treeNode3, treeNode5 });
            treeView1 = new TreeView();
            treeViewCategories = new TreeView();
            buttonFill = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(120, 124);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "B";
            treeNode2.Name = "Node3";
            treeNode2.Text = "C";
            treeNode3.Name = "Node1";
            treeNode3.Text = "A";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Node5";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Y1";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Kategori";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode6 });
            treeView1.Size = new Size(172, 188);
            treeView1.TabIndex = 0;
            // 
            // treeViewCategories
            // 
            treeViewCategories.Location = new Point(378, 135);
            treeViewCategories.Name = "treeViewCategories";
            treeViewCategories.Size = new Size(437, 160);
            treeViewCategories.TabIndex = 1;
            // 
            // buttonFill
            // 
            buttonFill.Location = new Point(586, 333);
            buttonFill.Name = "buttonFill";
            buttonFill.Size = new Size(75, 23);
            buttonFill.TabIndex = 2;
            buttonFill.Text = "Fill";
            buttonFill.UseVisualStyleBackColor = true;
            buttonFill.Click += buttonFill_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 499);
            Controls.Add(buttonFill);
            Controls.Add(treeViewCategories);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private TreeView treeViewCategories;
        private Button buttonFill;
    }
}
