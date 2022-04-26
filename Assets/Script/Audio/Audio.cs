using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace CrazyEight
{
	public class Audio : MonoBehaviour
	{
		[SerializeField] private AudioClip _hit;
		[SerializeField] private AudioClip _failKnife;
		[SerializeField] private AudioClip _crashWood;
        [SerializeField] private AudioClip _throw;


        private bool _isChash =false; //йняршкх

        private void OnEnable()
        {
            KnifeCollision.OnFail += AudioFail;
            KnifeCollision.OnWood += AudioHit;
            ShadowAmmoUi.OnWin += AudioCrash;
            InputTach.OnTach += Throw;
        }
        private void OnDisable()
        {
            KnifeCollision.OnFail -= AudioFail;
            KnifeCollision.OnWood -= AudioHit;
            ShadowAmmoUi.OnWin -= AudioCrash;
            InputTach.OnTach -= Throw;
        }
        private void AudioHit() 
        {
            GetComponent<AudioSource>().PlayOneShot(_hit);
        }
        private void AudioFail()
        {
            if (_isChash != true)
            {
                _isChash = true;
                GetComponent<AudioSource>().PlayOneShot(_failKnife);
            }
        }
        private void AudioCrash()
        {
            GetComponent<AudioSource>().PlayOneShot(_crashWood);
        }
        private void Throw()
        {
            GetComponent<AudioSource>().PlayOneShot(_throw);
        }
    }
}
