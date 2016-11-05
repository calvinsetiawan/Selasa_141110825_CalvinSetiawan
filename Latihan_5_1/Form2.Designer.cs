namespace Latihan_5_1
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Background Color");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Colors", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.bgcolor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(-1, 2);
            this.tree.Name = "tree";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Background Color";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Colors";
            this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tree.Size = new System.Drawing.Size(159, 200);
            this.tree.TabIndex = 0;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Background Color :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bgcolor
            // 
            this.bgcolor.FormattingEnabled = true;
            this.bgcolor.Location = new System.Drawing.Point(279, 60);
            this.bgcolor.Name = "bgcolor";
            this.bgcolor.Size = new System.Drawing.Size(121, 21);
            this.bgcolor.TabIndex = 2;
            this.bgcolor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.bgcolor_DrawItem);
            this.bgcolor.SelectedIndexChanged += new System.EventHandler(this.bgcolor_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bgcolor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tree);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bgcolor;
        private System.Windows.Forms.Button button1;
    }
}