using UnityEngine;
using UnityEngine.SceneManagement;

namespace CrazyEight
{
	public class MenuBattonManager : MonoBehaviour
	{
		public void SelectKnifes()
        {
			SceneManager.LoadScene(2);
        }
	}
}
