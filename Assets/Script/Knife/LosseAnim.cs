using UnityEngine;

namespace CrazyEight
{
    [RequireComponent(typeof(Animator))]
	public class LosseAnim : MonoBehaviour
    {
        [SerializeField] private GameObject _EffectHit;
        private void OnEnable()
        {
            KnifeCollision.OnWood += OnParctil;
            KnifeCollision.OnFail += OnFail;
        }
        private void OnDisable()
        {
            KnifeCollision.OnWood -= OnParctil;
            KnifeCollision.OnFail -= OnFail;
        }
        
        private void OnFail()
        {
            var anim = gameObject.GetComponent<Animator>();
            anim.enabled = true;
        }
        private void OnParctil()
        {
            var _pref = Instantiate(_EffectHit, transform);
            _pref.transform.SetParent(null);
            _pref.GetComponent<ParticleSystem>().Play();
            Destroy(_pref, 1);
        }
    }
}
