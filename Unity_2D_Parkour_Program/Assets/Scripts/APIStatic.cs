using UnityEngine;
namespace NL_API
{
    public class APIStatic : MonoBehaviour
    {
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
            print("是否輸入任意按件:" + Input.anyKey);
            print("遊戲經過時間:" + Time.realtimeSinceStartup);
        }

        private void Update()
        {
            #region 學習
            int range1 = Random.Range(1, 3);
            print("隨機整數 = " + range1);
            #endregion
        }

    }
}   

