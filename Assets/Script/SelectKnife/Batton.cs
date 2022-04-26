using UnityEngine;

namespace CrazyEight
{
	public class Batton : MonoBehaviour
	{
		[SerializeField] private KnifeData _prefab;

        private void Start()
        {
            var knife = Instantiate(_prefab.PrefabKnife, transform.position, _prefab.PrefabKnife.transform.rotation);
            knife.transform.SetParent(transform);
            knife.transform.localScale = new Vector3(1000, 1000, 1000) ;
        }
    }
}
