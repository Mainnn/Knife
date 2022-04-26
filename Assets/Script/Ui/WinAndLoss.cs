using UnityEngine;

namespace CrazyEight
{
	public class WinAndLoss : MonoBehaviour
	{
        [SerializeField] private GameObject _preafab;

        private void OnEnable()
        {
            KnifeCollision.OnFail += OpenPanel;
        }
        private void OnDisable()
        {
            KnifeCollision.OnFail -= OpenPanel;
        }

        private void OpenPanel()
        {
            Invoke(nameof(KOSTILIIII), 0.55f);

        }
        private void KOSTILIIII()
        {
            _preafab.SetActive(true);
        }

    }
}
