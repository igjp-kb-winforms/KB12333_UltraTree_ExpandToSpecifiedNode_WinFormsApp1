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

        // �e�m�[�h�ɂ����̂ڂ��ēW�J����B
        // ������̎q�܂œW�J�A�̓��\�b�h�Ƃ��Ă���܂���B
        // �����̂��߁A����e�ɂ����̂ڂ��ēW�J���Ă����K�v������܂��B
        var childNode = node;
        while (childNode.Parent != null)
        {
            childNode.Parent.Expanded = true;
            childNode = childNode.Parent;
        }

        // �I���ƃA�N�e�B�u�̐ݒ�
        node.Selected = true;
        ultraTree1.ActiveNode = node;

        // �I�������m�[�h���\���̈�ɓ���悤�ɃX�N���[������B
        node.BringIntoView();

        // UltraTree�Ƀt�H�[�J�X��߂��B
        // ��UltraTree�̃m�[�h�̃A�N�e�B�u��I���̎��o���ʂ́AUltraTree���̂��t�H�[�J�X�������Ă���K�v������܂��B
        // �����̃T���v���̏ꍇ�A�{�^���N���b�N�ł�������t�H�[�J�X���{�^���Ɉڂ��Ă���̂ŁAUltraTree�Ƀt�H�[�J�X��߂��K�v������܂��B
        ultraTree1.Focus();
    }
}
