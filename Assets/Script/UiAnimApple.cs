using UnityEngine;
using DG.Tweening;

namespace CrazyEight
{
	public class UiAnimApple : MonoBehaviour
	{
        private Vector3 _vector3Scale = new Vector3(0.05f, 0.05f, 0.05f);
        private float _elasticity = 0.7f;
        private float _duration = 0.3f;
        private int _vibrato = 10;

        private void OnEnable()
        {
            Aple.OnAple += Panch;
        }
        private void OnDisable()
        {
            Aple.OnAple -= Panch;
        }
        private void Panch()
        {
            transform.DOPunchScale(_vector3Scale, _duration, _vibrato, _elasticity);
        }
    }
}
