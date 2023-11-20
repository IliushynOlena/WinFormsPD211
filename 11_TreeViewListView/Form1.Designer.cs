namespace _11_TreeViewListView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node10", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node9", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.dirTree = new System.Windows.Forms.TreeView();
            this.fileList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // dirTree
            // 
            this.dirTree.Location = new System.Drawing.Point(7, 87);
            this.dirTree.Name = "dirTree";
            treeNode1.Name = "Node11";
            treeNode1.Text = "Node11";
            treeNode2.Name = "Node10";
            treeNode2.Text = "Node10";
            treeNode3.Name = "Node9";
            treeNode3.Text = "Node9";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Node6";
            treeNode5.Name = "Node7";
            treeNode5.Text = "Node7";
            treeNode6.Name = "Node8";
            treeNode6.Text = "Node8";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Node1";
            treeNode8.Name = "Node2";
            treeNode8.Text = "Node2";
            treeNode9.Name = "Node3";
            treeNode9.Text = "Node3";
            treeNode10.Name = "Node4";
            treeNode10.Text = "Node4";
            treeNode11.Name = "Node5";
            treeNode11.Text = "Node5";
            treeNode12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            treeNode12.ForeColor = System.Drawing.Color.Cyan;
            treeNode12.Name = "Node0";
            treeNode12.Text = "Root";
            this.dirTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.dirTree.Size = new System.Drawing.Size(1037, 961);
            this.dirTree.TabIndex = 0;
            this.dirTree.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.dirTree_BeforeCollapse);
            this.dirTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.dirTree_AfterExpand);
            this.dirTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dirTree_AfterSelect);
            // 
            // fileList
            // 
            this.fileList.Location = new System.Drawing.Point(1059, 87);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(1121, 961);
            this.fileList.TabIndex = 1;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.View = System.Windows.Forms.View.Tile;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2192, 1060);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.dirTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView dirTree;
        private ListView fileList;
    }
}