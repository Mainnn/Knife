using UnityEngine;

namespace CrazyEight
{
	[CreateAssetMenu (fileName ="ApleData",menuName ="Data/ApleData")]
	public class ApleData : ScriptableObject
	{
		[SerializeField] private GameObject _prefab;
		[Range(0.01f,0.25f)]
		[SerializeField] private float _changeSpawn ;

		public GameObject Prefab => _prefab;
		public float ChangeSpawn => _changeSpawn;
	}
}
