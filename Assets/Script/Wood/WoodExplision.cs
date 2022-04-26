using UnityEngine;
using UnityEngine.SceneManagement;

namespace CrazyEight
{
	public class WoodExplision : MonoBehaviour
	{
        [SerializeField] private GameObject _prefabExplition;
        [SerializeField] private GameObject _woodFBX;

        private void OnEnable()
        {
            ShadowAmmoUi.OnWin += WinStage;
        }
        private void OnDisable()
        {
            ShadowAmmoUi.OnWin -= WinStage;
        }

        private void WinStage()
        {
            GameObject[] allKnife = GameObject.FindGameObjectsWithTag("InWood");
            foreach (var item in allKnife)
            {
                item.transform.SetParent(null);
                var temp = item.GetComponent<Rigidbody>();
                temp.drag = 1;
                temp.useGravity = true;

            }
                _woodFBX.SetActive(false);
                transform.GetComponent<Wood>().enabled = false;
                transform.GetComponent<SphereCollider>().enabled = false;
                _prefabExplition.SetActive(true);
        }
    }
}
