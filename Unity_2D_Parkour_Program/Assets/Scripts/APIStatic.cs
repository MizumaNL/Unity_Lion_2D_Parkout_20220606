using UnityEngine;
namespace NL_API
{
    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(88, 88, 88);

        private void Start()
        {
            #region 學習

            //取得屬性
            //語法:
            //類別.靜態屬性名稱
            print("隨機值=" + Random.value);
            print("PI = " + Mathf.PI);
            print("Infinity = " + Mathf.Infinity);
            Cursor.visible = false;

            Physics2D.gravity = new Vector2(0, -9.8f);
            Time.timeScale = 0.5f;


            float range = Random.Range(10.5f, 100.3f);
            print("隨機數 = " + range);
            #endregion
            int count = Camera.allCamerasCount;
            print("相機有 :" + count);
            print("當前平台:" + Application.platform);
            Physics.sleepThreshold = 10;
            print("3D 物理睡眠臨界值設定為 :"+Physics.sleepThreshold);

            Time.timeScale = 0.5f;
            print("時間大小設定為 :" + Time.timeScale);
            print("對 9.999 去小數點 :" + Mathf.Round(9.999f));

            float distance = Vector3.Distance(a, b);
            print("<color=cyan>取得兩點的距離 :" + distance+"</color>");

            Application.OpenURL(" https://unity.com");

        }

        private void Update()
        {
            #region 學習
            int range1 = Random.Range(1, 3);
            print("隨機整數 = " + range1);
            #endregion
            // print("是否輸入任意按件:" + Input.anyKey);
            // print("遊戲經過時間:" + Time.realtimeSinceStartup);

            print("<color=yellow>是否按下空白鍵 :" + Input.GetKeyDown(KeyCode.Space) + "</color>");
            
        }

    }
}   

