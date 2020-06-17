using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NinjaDelivery
{
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : MonoBehaviour
    {
        private static AudioSource audioSrc;

        void Start()
        {
            audioSrc = GetComponent<AudioSource>();
        }

        public void PlaySound(AudioClip SoundEffect)
        {
            audioSrc.PlayOneShot(SoundEffect);
        }
    }
}
