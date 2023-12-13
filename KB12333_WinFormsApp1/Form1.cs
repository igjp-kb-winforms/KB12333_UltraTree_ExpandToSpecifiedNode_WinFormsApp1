namespace KB12333_WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var node = ultraTree1.GetNodeByKey("Node122");

        // 親ノードにさかのぼって展開する。
        // ※特定の子まで展開、はメソッドとしてありません。
        // ※そのため、一つずつ親にさかのぼって展開していく必要があります。
        var childNode = node;
        while (childNode.Parent != null)
        {
            childNode.Parent.Expanded = true;
            childNode = childNode.Parent;
        }

        // 選択とアクティブの設定
        node.Selected = true;
        ultraTree1.ActiveNode = node;

        // 選択したノードが表示領域に入るようにスクロールする。
        node.BringIntoView();

        // UltraTreeにフォーカスを戻す。
        // ※UltraTreeのノードのアクティブや選択の視覚効果は、UltraTree自体がフォーカスを持っている必要があります。
        // ※このサンプルの場合、ボタンクリックでいったんフォーカスがボタンに移っているので、UltraTreeにフォーカスを戻す必要があります。
        ultraTree1.Focus();
    }
}
