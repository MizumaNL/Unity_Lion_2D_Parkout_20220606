
using UnityEngine;
namespace NL
{
    public class ManagePass : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "兔";
        [SerializeReference, Header("跑步系統")]
        private SystemRun SystemRun;
        [SerializeReference, Header("跳躍系統")]
        private SystemJump systemJump;
        [SerializeField, Header("結束管理器")]
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
