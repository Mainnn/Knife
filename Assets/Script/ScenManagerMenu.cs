using UnityEngine;
using UnityEngine.SceneManagement;

namespace CrazyEight
{
	public class ScenManagerMenu : MonoBehaviour
	{

        private void OnEnable()
        {
            InputTach.OnTach += LoadLevel;
        }
        private void OnDisable()
        {
            InputTach.OnTach -= LoadLevel;
        }
        private void LoadLevel()
        {
            SceneManager.LoadScene(1);
        }
    }
}
