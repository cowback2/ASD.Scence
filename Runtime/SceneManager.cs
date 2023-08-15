using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ASD.SceneManager
{
    /// <summary>
    /// 場景控制:開始與結束遊戲
    /// </summary>
    public class ScenManager : MonoBehaviour
    {

        [SerializeField, Range(0.3f, 2f), Header("音效時間")]
        private float soundDuration = 2f;

        private string ChangenameScene;

        /// <summary>
        /// 開始遊戲
        /// </summary>
        /// <param name="nameScene">開始遊戲</param>


        public void ChangeScene(string nameScene)
        {
            Invoke("DelayChangescene", soundDuration);
            ChangenameScene = nameScene;
        }

        private void DelayChangescene()
        {
            //print("開始遊戲");

            UnityEngine.SceneManagement.SceneManager.LoadScene(ChangenameScene);
        }


        /// <summary>
        /// 離開遊戲
        /// </summary>
        public void Quit()
        {
            Invoke("DelayQuit", soundDuration);
        }

        private void DelayQuit()
        {
            //print("結束遊戲");

            Application.Quit();
        }
    }

}
