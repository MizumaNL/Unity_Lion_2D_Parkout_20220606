
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
        [SerializeField, Header("���V�ʵe�Ѽ�")]
        private string nameJump = "�}��Jump";
        [SerializeField, Header("���D����")]
        private AudioClip soundJump;
        [SerializeField, Header("�ˬd����C��")]
        private Color colorCheckWall = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("�ˬd����ϼh")]
        private LayerMask layerCheckWall;
        [SerializeField, Header("�ˬd����ؤo")]
        private Vector3 v3CheckWallSize = Vector3.one;
        [SerializeField, Header("�ˬd����첾")]
        private Vector3 v3CheckWallOffset;
        [SerializeField, Header("����ʵe�Ѽ�")]
        private string nameWall = "�}��Wall";

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;
        private AudioSource aud;
        private bool isWall;

        #endregion

        #region �ƥ�:�{�����J�f
        private void OnDrawGizmos()
        {
            //�]�w�C��
            Gizmos.color = colorCheckGround;
            //ø�s�ϥ�
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);

            Gizmos.color = colorCheckWall;
            //ø�s�ϥ�
            Gizmos.DrawCube(transform.position + transform.TransformDirection(v3CheckWallOffset), v3CheckWallSize);
        }

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();

        }
        //�C�� "��" 60 ��
        private void Update()
        {
            JumpKey();
            GroundCheck();
            UpdateAnimator();
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