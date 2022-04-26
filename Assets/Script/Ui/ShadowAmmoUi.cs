using System;
using System.Collections.Generic;
using UnityEngine;

namespace CrazyEight
{
	public class ShadowAmmoUi : MonoBehaviour
    {
        [SerializeField] bool Is;
        [SerializeField] private AmmoCount _ammoCount;

        private List<ShadowAmmo> _shadows = new List<ShadowAmmo>();

        private int countInWood = 1;

        public static event Action OnWin;

        private void Start()
        {
            _shadows = _ammoCount._shadowAmmo;
        }
        private void Update()
        {
            if (Is)
            {
                OnWin?.Invoke();
            }
        }

        private void OnEnable()
        {
            KnifeCollision.OnWood += ShowShadows;
        }
        private void OnDisable()
        {
            KnifeCollision.OnWood -= ShowShadows;
        }
        private void ShowShadows()
        {
            _shadows[_shadows.Count - countInWood].gameObject.GetComponent<ShadowAmmo>().Prefab.SetActive(false);
            if (_shadows.Count  == countInWood)
            {
                OnWin?.Invoke();
            }
            countInWood++;
        }
    }
}
