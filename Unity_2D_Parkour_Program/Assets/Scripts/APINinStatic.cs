
using UnityEngine;
namespace NL
{
    public class APINinStatic : MonoBehaviour
    {
        // 1.�w�q���,������������O
        // 2.Unity �ݩʭ��O�����T�w����줣�O�ŭ� None
        // 3.�ϥΫD�R�A API

        [SerializeField]
        private GameObject rabbit;
        [SerializeField]
        private Transform startPoint;

         private void Start()
        {
            //�D�R�A�ݩ�
            //1.���o
            //�y�k: ���W��.�D�R�A�ݩ�

            print("<color=yellow>��ߤl�Ұʪ��A :" + rabbit.activeInHierarchy + "</color>");
            print("<color=red>��ߤl���ϼh :" + rabbit.layer + "</color>");
            print("�_�I�y�� : " + startPoint.position);
 
            //2.�]�w
            //�y�k:���W��.�D�R�A�ݩ� ���w ��;
            //rabbit.activeInHierarchy = fales (���~.�߿W�ݩ� �x�襼�Х�)
            rabbit.tag = "Player";
            rabbit.layer = 4;
            startPoint.position = new Vector3(0, 5, 0);

            //3.�ϥ�
            //�y�k:���W��.�D�R�A�ݩ� 
            rabbit.SetActive(false);

        }
        private void Update()
        {
            startPoint.Translate(1, 0, 0);
            startPoint.Rotate(0, 0, 3.5f);
            
        }
    }


}

