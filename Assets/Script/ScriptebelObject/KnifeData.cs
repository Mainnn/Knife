using UnityEngine;

namespace CrazyEight
{
	[RequireComponent(typeof(KnifeCollision), typeof(KnifeMove), typeof(LosseAnim))]
	[CreateAssetMenu(fileName ="CreateKnife", menuName = "Data/Createknife")]
	public class KnifeData : ScriptableObject
	{
		[SerializeField] private GameObject _prefab;

		public GameObject PrefabKnife => _prefab;
	}
}
