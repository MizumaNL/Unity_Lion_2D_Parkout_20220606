
using UnityEngine;

namespace NL
{
    public class SystemJump : MonoBehaviour
    {
        #region 資料:保存系統需要的資料
        [SerializeField, Header("跳高"), Range(0, 3000)]
        private float hieghtJump = 350;
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGround;


        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;

        #endregion

        #region 事件:程式的入口
        private void OnDrawGizmos()
        {
            //設定顏色
            Gizmos.color = colorCheckGround;
            //繪製圖示
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);
        }

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();

        }
        //每秒 "約" 60 次
        private void Update()
        {
            JumpKey();
            GroundCheck();
        }
        // 每秒固定50次
        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion

        #region 功能:實作該系統的複雜方法
        private void JumpKey()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //print("跳躍中~");
                clickJump = true;

            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }



        }
        private void JumpForce()
        {
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, hieghtJump));
                clickJump = false;
            }
        }
        private void GroundCheck()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0, layerCheckGround);

            isGround = hit;
        }

        #endregion
    }

}