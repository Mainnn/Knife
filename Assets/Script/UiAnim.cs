using UnityEngine;
using DG.Tweening;

namespace CrazyEight
{
	public class UiAnim : MonoBehaviour
	{
        private Vector3 _vector3Scale = new Vector3(0.05f, 0.05f, 0.05f);
        private float _elasticity = 0.7f;
        private float _duration = 0.3f;
        private int _vibrato = 10;

        private void OnEnable()
        {
            KnifeCollision.OnWood += Panch;
        }
        private void OnDisable()
        {
            KnifeCollision.OnWood -= Panch;
        }
        private void Panch()
        {
            transform.DOPunchScale(_vector3Scale, _duration, _vibrato, _elasticity);
        }
    }
}
