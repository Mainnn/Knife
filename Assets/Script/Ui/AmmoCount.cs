using System;
using System.Collections.Generic;
using UnityEngine;

namespace CrazyEight
{
	public class AmmoCount : MonoBehaviour
	{
		[SerializeField] List<GameObject> _prefabAmmo = new List<GameObject>();

        public List<ShadowAmmo> _shadowAmmo = new List<ShadowAmmo>() ;

        [Range(3,8)]
		private int _ammoRang;

        public static event Action<int> OnAmmoCount;

        private void Awake()
        {
            RandomAmmo();
            OnAmmo();
        }

        private void RandomAmmo()
        {
            _ammoRang = UnityEngine.Random.Range(3, 8);
        }
        private void OnAmmo()
        {
            for (int i = 0; i < _ammoRang; i++)
            {
                _prefabAmmo[i].active = true;
                _shadowAmmo.Add(_prefabAmmo[i].GetComponent<ShadowAmmo>());
            }
            OnAmmoCount?.Invoke(_ammoRang);
        }
    }
}
