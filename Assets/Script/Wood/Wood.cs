using UnityEngine;

namespace CrazyEight
{
    public class Wood : MonoBehaviour
    {
        [SerializeField] private float _speedMax = 0;
        [SerializeField] private float _intevalToStop = 0.0f;

        private bool _isLeft = true;
        private float _time;
        private float _speed;

        private void Update()
        {
            RotateWood();
            _time += Time.deltaTime;
            if(_intevalToStop < _time)
            {
                Reload();
            }else if (_intevalToStop / 3 < _time)
            {
                if (_isLeft)
                {
                    _speed += 0.2f;
                }
                else
                {
                    _speed -= 0.2f;
                }
            }
        }

        private void RotateWood()
        {
            transform.Rotate(new Vector3(0, 0, 1) * _speed * Time.deltaTime);
        }
        private void Reload()
        {
            _time = 0;
            if (!_isLeft)
            {
                _isLeft = true;
                _speed = -_speedMax;
            }
            else
            {
                _isLeft = false;
                _speed = _speedMax;
            }
        }
    }
}
