using UnityEngine;
namespace NL_API
{
    public class APIStatic : MonoBehaviour
    {
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
            print("�O�_��J���N����:" + Input.anyKey);
            print("�C���g�L�ɶ�:" + Time.realtimeSinceStartup);
        }

        private void Update()
        {
            #region �ǲ�
            int range1 = Random.Range(1, 3);
            print("�H����� = " + range1);
            #endregion
        }

    }
}   

