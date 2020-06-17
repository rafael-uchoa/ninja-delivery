using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoaderCollider : MonoBehaviour
{
  [SerializeField] LevelLoader levelLoader;
  [SerializeField] private string level;

  private void OnTriggerEnter2D(Collider2D col)
  {
    levelLoader.LoadLevel(level);
  }
}
