
using UnityEngine;
namespace NL
{
    public class ManagePass : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "��";
        [SerializeReference, Header("�]�B�t��")]
        private SystemRun SystemRun;
        [SerializeReference, Header("���D�t��")]
        private SystemJump systemJump;
        [SerializeField, Header("�����޲z��")]
        private ManageFinal manageFinal;

        #region
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nameTarget))
            {
                SystemRun.enabled = false;
                systemJump.enabled = false;
                manageFinal.enabled = true;
                manageFinal.stringTitle = "Congratulation";
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion

    }

}
