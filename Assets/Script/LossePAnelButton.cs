using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CrazyEight
{
	public class LossePAnelButton : MonoBehaviour
	{
        public static Action OnRestart;
        public static Action OnSave;
        public void Restart()
        {
            OnRestart?.Invoke();
            SceneManager.LoadScene(1);
        }
        public void LoadMenuScen()
        {
            OnSave?.Invoke();
            SceneManager.LoadScene(0);//Scen 0 = Menu
        }
    }
}
