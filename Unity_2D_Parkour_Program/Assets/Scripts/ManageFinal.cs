
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
namespace NL
{
    public class ManageFinal : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;

        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;
            
            InvokeRepeating("FadeIn", 0, 0.2f);
        }

        private void FadeIn()
        {
            groupFinal.alpha += 0.1f;

            print("�H�J~");

            if(groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;

                CancelInvoke("FadeIn");
            }
            
        }
        public void Quit()
        {
            print("�U�Z�o~~~~");
            Application.Quit();
        }
        public void Replay()
        {
            SceneManager.LoadScene("�C������");
        }
    }

}
