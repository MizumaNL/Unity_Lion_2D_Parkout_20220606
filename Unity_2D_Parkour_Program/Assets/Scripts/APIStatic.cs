using UnityEngine;
namespace NL_API
{
    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(88, 88, 88);

        private void Start()
        {
            #region �ǲ�

            //���o�ݩ�
            //�y�k:
            //���O.�R�A�ݩʦW��
            print("�H����=" + Random.value);
            print("PI = " + Mathf.PI);
            print("Infinity = " + Mathf.Infinity);
            Cursor.visible = false;

            Physics2D.gravity = new Vector2(0, -9.8f);
            Time.timeScale = 0.5f;


            float range = Random.Range(10.5f, 100.3f);
            print("�H���� = " + range);
            #endregion
            int count = Camera.allCamerasCount;
            print("�۾��� :" + count);
            print("��e���x:" + Application.platform);
            Physics.sleepThreshold = 10;
            print("3D ���z�ίv�{�ɭȳ]�w�� :"+Physics.sleepThreshold);

            Time.timeScale = 0.5f;
            print("�ɶ��j�p�]�w�� :" + Time.timeScale);
            print("�� 9.999 �h�p���I :" + Mathf.Round(9.999f));

            float distance = Vector3.Distance(a, b);
            print("<color=cyan>���o���I���Z�� :" + distance+"</color>");

            Application.OpenURL(" https://unity.com");

        }

        private void Update()
        {
            #region �ǲ�
            int range1 = Random.Range(1, 3);
            print("�H����� = " + range1);
            #endregion
            // print("�O�_��J���N����:" + Input.anyKey);
            // print("�C���g�L�ɶ�:" + Time.realtimeSinceStartup);

            print("<color=yellow>�O�_���U�ť��� :" + Input.GetKeyDown(KeyCode.Space) + "</color>");
            
        }

    }
}   

