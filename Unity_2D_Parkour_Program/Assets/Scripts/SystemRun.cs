using UnityEngine; //�ޥ� Unity ���� �R�W�Ŷ�(API)

namespace NL
{
    /// <summary>
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn�����

        // ��� Field :�O�s���
        // �y�k
        // �׹��� ��������� ���ۭq�W��(���w

        //�׹���
        //���}:��ܦb���O,���\��L���O�s�� public
        //�p�H:����ܦb���O,�����\��L���O�s�� private

        //Serialize Field �{�Ǥ����:�N�p�H�����ܩ󱱨�O
        //Heder ���D:�i�H�Τ���
        //Tooltip ����:�i�H�Τ���
        //Range �d��:�ȭ���ƭ�������� int gloat byte long
        [SerializeField, Header("�]�t"), Tooltip("�o�O�}�⪺�]�t"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("����"), Range(0, 3000)]
        private float hieghtJump = 350;
        private Animator ani;
        private Rigidbody2D rig;

        #endregion

        #region �\��:��@�Өt�Ϊ�������k

        #endregion

        #region �ƥ�:�{�����J�f
        // �}�ϱ���:�C���������@��
        // �l�Ƴ]�w:�Ҧp: �C���}�l�o��500����
        private void Start()
        {
            print("���o,�¼w�o��");
        }
        #endregion


    }
}


