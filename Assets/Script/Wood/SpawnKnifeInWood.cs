using System.Collections.Generic;
using UnityEngine;

namespace CrazyEight
{
	public class SpawnKnifeInWood : MonoBehaviour
	{
		[SerializeField] private List<GameObject> _prefabs;

        private void Start()
        {
            ShowKnifes();
        }
        private void ShowKnifes()
        {
            foreach (var item in _prefabs)
            {
                if (Random.Range(0,2) == 1)
                {
                    item.SetActive(true);
                }
            }
        }
    }
}
