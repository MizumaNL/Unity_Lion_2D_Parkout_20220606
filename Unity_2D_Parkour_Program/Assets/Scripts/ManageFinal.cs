
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
namespace NL
{
    public class ManageFinal : MonoBehaviour
    {
        [SerializeField, Header("畫布")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("遊戲結束標題")]
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

            print("淡入~");

            if(groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;

                CancelInvoke("FadeIn");
            }
            
        }
        public void Quit()
        {
            print("下班囉~~~~");
            Application.Quit();
        }
        public void Replay()
        {
            SceneManager.LoadScene("遊戲場景");
        }
    }

}
