using UnityEngine; //引用 Unity 引擎 命名空間(API)

namespace NL
{
    /// <summary>
    /// 跑步系統
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料:保存系統需要的資料

        // 欄位 Field :保存資料
        // 語法
        // 修飾詞 欄位資料類型 欄位自訂名稱(指定

        //修飾詞
        //公開:顯示在面板,允許其他類別存取 public
        //私人:不顯示在面板,不允許其他類別存取 private

        //Serialize Field 程序化欄位:將私人欄位顯示於控制面板
        //Heder 標題:可以用中文
        //Tooltip 提示:可以用中文
        //Range 範圍:僅限於數值類型資料 int gloat byte long
        [SerializeField, Header("跑速"), Tooltip("這是腳色的跑速"), Range(0, 100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("跳高"), Range(0, 3000)]
        private float hieghtJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        private SpriteRenderer spr;
        private bool clickRun;


        #endregion

        #region 功能:實作該系統的複雜方法
        //方法 Method
        //語法
        //修飾詞 傳回資料類型 方法名稱( ) { }
        /// <summary>
        /// 跑步功能
        /// </summary>
        private void Run()
        {
            //print("跑步中~");
        }
        #endregion

        #region 事件:程式的入口
        // 開使條件:遊戲撥放執行一次
        // 始化設定:例如: 遊戲開始發放500金幣
        private void Awake()
        {
            // ani 指定 角色身上的Animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            spr = GetComponent<SpriteRenderer>();
        }
        private void Start()
        {
            //print("哈囉,麻德發科");
        }
        //更新事件:每秒執行約60次 60FPS Frame per second
        private void Update()
        {
            //print("<color=lime>系統持續更新中@@@~</color>");
            Run();
            RunKey();
            UpdateAnimator();

            float h = Input.GetAxis("Horizontal");
            rig.velocity = new Vector2(speedRun * h, rig.velocity.y);
        }
        private void OnEnable()
        {

        }
        private void OnDisable()
        {
            rig.velocity = Vector3.zero;
        }
        private void RunKey()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                //print("跳躍中~");
                clickRun = true;

            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                clickRun = false;
            }
            
            if (rig.velocity.x > 0.1f)
            {
                //spr.flipX = false;
                transform.eulerAngles = Vector3.zero;
            }
            if (rig.velocity.x < -0.1f)
            {
                //spr.flipX = true;
                transform.eulerAngles = new Vector3(0,180);
            }




        }
        private void UpdateAnimator()
        {
            ani.SetBool("開關Run", clickRun);
        }
        #endregion

    }
}


