
using UnityEngine;

public class SystemJump : MonoBehaviour
{
    #region ���:�O�s�t�λݭn�����
    [SerializeField, Header("����"), Range(0, 3000)]
    private float hieghtJump = 350;
    
    private Animator ani;
    private Rigidbody2D rig;
    private bool clickJump;

    #endregion   

    #region �ƥ�:�{�����J�f
    private void Awake()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
            
    }
    //�C�� "��" 60 ��
    private void Update()
    {
        JumpKey();
    }
    // �C��T�w50��
    private void FixedUpdate()
    {
        JumpForce();
    }
    #endregion

    #region �\��:��@�Өt�Ϊ�������k
    private void JumpKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("���D��~");
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
