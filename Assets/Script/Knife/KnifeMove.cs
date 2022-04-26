using System;
using UnityEngine;

namespace CrazyEight
{
    [RequireComponent(typeof(Rigidbody))]
	public class KnifeMove : MonoBehaviour
	{

        private Rigidbody _rb;
        private float _forece = 1200f;

        private void Start()
        {
            _rb = gameObject.GetComponent<Rigidbody>();
        }
        private void OnEnable()
        {
            InputTach.OnTach += Throw;

        }
        private void OnDisable()
        {
            InputTach.OnTach -= Throw;
        }

        private void Throw()
        {
            transform.SetParent(null);
            _rb.AddForce(new Vector3(0,1,0) * _forece);
        }
        public void Woodtach(GameObject wood)
        {
            _rb.drag = 100;
            transform.SetParent(wood.transform);
        }

        public void Losse()
        {
            _rb.velocity = Vector3.zero;
        }
    }
}
