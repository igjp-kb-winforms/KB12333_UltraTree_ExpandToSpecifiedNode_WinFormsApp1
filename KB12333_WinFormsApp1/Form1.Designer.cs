namespace KB12333_WinFormsApp1;

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
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode2 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode3 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode4 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode5 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode6 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode7 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode8 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode9 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode10 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode11 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode12 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode13 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode14 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode15 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode16 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
        ultraTree1 = new Infragistics.Win.UltraWinTree.UltraTree();
        button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)ultraTree1).BeginInit();
        SuspendLayout();
        // 
        // ultraTree1
        // 
        ultraTree1.ImageTransparentColor = Color.Transparent;
        ultraTree1.Location = new Point(0, 0);
        ultraTree1.Name = "ultraTree1";
        ultraTree1.NodeConnectorColor = SystemColors.ControlDark;
        ultraTreeNode1.Key = "Node1";
        ultraTreeNode2.Key = "Node11";
        ultraTreeNode3.Key = "Node111";
        ultraTreeNode4.Key = "Node1111";
        ultraTreeNode4.Text = "Node1111";
        ultraTreeNode5.Key = "Node1112";
        ultraTreeNode5.Text = "Node1112";
        ultraTreeNode3.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] { ultraTreeNode4, ultraTreeNode5 });
        ultraTreeNode3.Text = "Node111";
        ultraTreeNode6.Key = "Node112";
        ultraTreeNode7.Key = "Node1121";
        ultraTreeNode7.Text = "Node1121";
        ultraTreeNode6.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] { ultraTreeNode7 });
        ultraTreeNode6.Text = "Node112";
        ultraTreeNode2.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] { ultraTreeNode3, ultraTreeNode6 });
        ultraTreeNode2.Text = "Node11";
        ultraTreeNode8.Key = "Node12";
        ultraTreeNode9.Key = "Node121";
        ultraTreeNode9.Text = "Node121";
        ultraTreeNode10.Key = "Node122";
        ultraTreeNode11.Key = "Node1221";
        ultraTreeNode11.Text = "Node1221";
        ultraTreeNode10.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] { ultraTreeNode11 });
        ultraTreeNode10.Text = "Node122";
        ultraTreeNode12.Key = "Node123";
        ultraTreeNode12.Text = "Node123";
        ultraTreeNode13.Key = "Node124";
        ultraTreeNode13.Text = "Node124";
        ultraTreeNode8.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] { ultraTreeNode9, ultraTreeNode10, ultraTreeNode12, ultraTreeNode13 });
        ultraTreeNode8.Text = "Node12";
        ultraTreeNode14.Key = "Node13";
        ultraTreeNode14.Text = "Node13";
        ultraTreeNode1.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] { ultraTreeNode2, ultraTreeNode8, ultraTreeNode14 });
        ultraTreeNode1.Text = "Node1";
        ultraTreeNode15.Key = "Node2";
        ultraTreeNode16.Key = "Node21";
        ultraTreeNode16.Text = "Node21";
        ultraTreeNode15.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] { ultraTreeNode16 });
        ultraTreeNode15.Text = "Node2";
        ultraTree1.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] { ultraTreeNode1, ultraTreeNode15 });
        ultraTree1.Size = new Size(362, 130);
        ultraTree1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new Point(428, 26);
        button1.Name = "button1";
        button1.Size = new Size(323, 59);
        button1.TabIndex = 1;
        button1.Text = "Node 122を選択し、そこまで展開する";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(ultraTree1);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)ultraTree1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Infragistics.Win.UltraWinTree.UltraTree ultraTree1;
    private Button button1;
}
