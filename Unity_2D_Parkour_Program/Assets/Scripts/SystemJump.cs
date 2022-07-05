
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
        [SerializeField, Header("跳越動畫參數")]
        private string nameJump = "開關Jump";
        [SerializeField, Header("跳躍音效")]
        private AudioClip soundJump;
        [SerializeField, Header("檢查牆壁顏色")]
        private Color colorCheckWall = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("檢查牆壁圖層")]
        private LayerMask layerCheckWall;
        [SerializeField, Header("檢查牆壁尺寸")]
        private Vector3 v3CheckWallSize = Vector3.one;
        [SerializeField, Header("檢查牆壁位移")]
        private Vector3 v3CheckWallOffset;
        [SerializeField, Header("牆跳動畫參數")]
        private string nameWall = "開關Wall";

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;
        private AudioSource aud;
        private bool isWall;

        #endregion

        #region 事件:程式的入口
        private void OnDrawGizmos()
        {
            //設定顏色
            Gizmos.color = colorCheckGround;
            //繪製圖示
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);

            Gizmos.color = colorCheckWall;
            //繪製圖示
            Gizmos.DrawCube(transform.position + transform.TransformDirection(v3CheckWallOffset), v3CheckWallSize);
        }

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();

        }
        //每秒 "約" 60 次
        private void Update()
        {
            JumpKey();
            GroundCheck();
            UpdateAnimator();
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
            if (clickJump && isGround || isWall)
            {
                if (isWall) rig.AddForce(transform.right * 2000 + new Vector3(0, hieghtJump));
                else rig.AddForce(new Vector3(0, hieghtJump));
                
                clickJump = false;

                aud.PlayOneShot(soundJump, Random.Range(0.7f, 1.5f));
            }
            
        }
        private void GroundCheck()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0, layerCheckGround);
            Collider2D clm = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3CheckWallOffset), v3CheckWallSize, 0, layerCheckWall);
            isGround = hit;
            isWall = clm;
        }
        private void UpdateAnimator()
        {
            ani.SetBool(nameJump, !isGround);
            ani.SetBool(nameWall, isWall);
        }

        #endregion
    }

}