
using UnityEngine;

namespace NL
{
    public class SystemJump : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn�����
        [SerializeField, Header("����"), Range(0, 3000)]
        private float hieghtJump = 350;
        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGround;


        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;

        #endregion

        #region �ƥ�:�{�����J�f
        private void OnDrawGizmos()
        {
            //�]�w�C��
            Gizmos.color = colorCheckGround;
            //ø�s�ϥ�
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);
        }

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();

        }
        //�C�� "��" 60 ��
        private void Update()
        {
            JumpKey();
            GroundCheck();
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
                //print("���D��~");
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