
using UnityEngine;

namespace NL
{
    public class ManageDead : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "兔";
        [SerializeField, Header("結束管理器")]
        private ManageFinal manageFinal;
        [SerializeField, Header("CM攝影機控制物件")]
        private GameObject GoCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nameTarget))
            {
                manageFinal.stringTitle = "GAME OVER \n BAKA YAROU !! ";
                manageFinal.enabled = true;
                GoCM.SetActive(false);
            }
        }
    }



}
