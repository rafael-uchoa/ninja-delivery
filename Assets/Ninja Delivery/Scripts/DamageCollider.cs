using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NinjaDelivery
{
    public class DamageCollider : MonoBehaviour
    {
        [SerializeField] private Player player;
        [SerializeField] private SoundManager soundManager;

        [Header("Damage Settings")]
        public AudioClip damageSound;
        public int damageValue;

        private void OnTriggerEnter2D(Collider2D col)
        {
            Destroy(gameObject);

            player.TakeDamage(damageValue);

            soundManager.PlaySound(damageSound);
        }
    }
}
