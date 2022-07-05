
using UnityEngine;

namespace NL
{
    public class ManageDead : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "��";
        [SerializeField, Header("�����޲z��")]
        private ManageFinal manageFinal;
        [SerializeField, Header("CM��v�������")]
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
