
using UnityEngine;
namespace NL
{
    public class APINinStatic : MonoBehaviour
    {
        // 1.定義欄位,資料類型為類別
        // 2.Unity 屬性面板必須確定該欄位不是空值 None
        // 3.使用非靜態 API

        [SerializeField]
        private GameObject rabbit;
        [SerializeField]
        private Transform startPoint;

         private void Start()
        {
            //非靜態屬性
            //1.取得
            //語法: 欄位名稱.非靜態屬性

            print("<color=yellow>臭兔子啟動狀態 :" + rabbit.activeInHierarchy + "</color>");
            print("<color=red>臭兔子的圖層 :" + rabbit.layer + "</color>");
            print("起點座標 : " + startPoint.position);
 
            //2.設定
            //語法:欄位名稱.非靜態屬性 指定 值;
            //rabbit.activeInHierarchy = fales (錯誤.唯獨屬性 官方未標示)
            rabbit.tag = "Player";
            rabbit.layer = 4;
            startPoint.position = new Vector3(0, 5, 0);

            //3.使用
            //語法:欄位名稱.非靜態屬性 
            rabbit.SetActive(false);

        }
        private void Update()
        {
            startPoint.Translate(1, 0, 0);
            startPoint.Rotate(0, 0, 3.5f);
            
        }
    }


}

