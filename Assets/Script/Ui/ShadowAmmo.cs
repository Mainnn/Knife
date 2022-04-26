using UnityEngine;

namespace CrazyEight
{
	public class ShadowAmmo : MonoBehaviour
	{
		[SerializeField] private GameObject _prefab;

		public GameObject Prefab => _prefab;
	}
}
