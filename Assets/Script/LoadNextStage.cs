using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CrazyEight
{
	public class LoadNextStage : MonoBehaviour
	{
        private void OnEnable()
        {
            ShadowAmmoUi.OnWin += InvokreNaxtStage;
        }
        private void OnDisable()
        {
            ShadowAmmoUi.OnWin -= InvokreNaxtStage;
        }
        private void NextStage()
        {
            SceneManager.LoadScene(1);
        }
        private void InvokreNaxtStage()
        {
            Invoke(nameof(NextStage),1);
        }
        
    }
}

