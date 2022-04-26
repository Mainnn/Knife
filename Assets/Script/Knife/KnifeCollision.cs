using System;
using UnityEngine;

namespace CrazyEight
{
	public class KnifeCollision : MonoBehaviour
	{

        public static event Action OnFail;
        public static event Action OnWood;

        private void OnCollisionEnter(Collision collision)
        {
            var _knife = gameObject.GetComponent<KnifeMove>();

            if (collision.transform.TryGetComponent(out KnifeMove knife))
            {
                Handheld.Vibrate();
                _knife.Losse();
                OnFail?.Invoke();
            }
            if (collision.transform.TryGetComponent(out Wood wood))
            {
                Handheld.Vibrate();
                transform.GetComponent<KnifeMove>().Woodtach(wood.gameObject);
                OnWood?.Invoke();
            }
            _knife.enabled = false;
            gameObject.GetComponent<LosseAnim>().enabled = false;
        }
    }
}
