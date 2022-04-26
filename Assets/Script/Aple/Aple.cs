using System;
using UnityEngine;

namespace CrazyEight
{
	public class Aple : MonoBehaviour
	{
        [SerializeField] private GameObject _prefabExposionApple;

        public static event Action OnAple;

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.TryGetComponent(out KnifeMove knife))
            {
                _prefabExposionApple.SetActive(true);
                _prefabExposionApple.transform.SetParent(null);
                Destroy(gameObject);
            }
        }
        private void OnDisable()
        {
            OnAple?.Invoke();
        }
    }
}
