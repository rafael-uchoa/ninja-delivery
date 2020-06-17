using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NinjaDelivery
{
    public class ScoreCollider : MonoBehaviour
    {
        [SerializeField] private ScoreSystem scoreSystem;
        [SerializeField] private SoundManager soundManager;

        [Header("Score Settings")]
        public AudioClip collectSound;
        public int scoreValue;

        private void OnTriggerEnter2D(Collider2D col)
        {
            Destroy(gameObject);

            scoreSystem.UpdateScore(scoreValue);
            soundManager.PlaySound(collectSound);
        }
    }
}
