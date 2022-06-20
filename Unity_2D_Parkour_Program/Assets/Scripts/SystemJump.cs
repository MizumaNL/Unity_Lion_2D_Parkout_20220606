
using UnityEngine;

public class SystemJump : MonoBehaviour
{
    #region 資料:保存系統需要的資料
    [SerializeField, Header("跳高"), Range(0, 3000)]
    private float hieghtJump = 350;
    
    private Animator ani;
    private Rigidbody2D rig;
    private bool clickJump;

    #endregion   

    #region 事件:程式的入口
    private void Awake()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
            
    }
    //每秒 "約" 60 次
    private void Update()
    {
        JumpKey();
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
            print("跳躍中~");
            clickJump = true;

        }
    }
    private void JumpForce()
    {
        if (clickJump)
        {
            rig.AddForce(new Vector2(0, hieghtJump));
            clickJump = false;
        }
    }
   
    #endregion
}
