using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NinjaDelivery
{
    public class ScoreSystem : MonoBehaviour
    {
        [SerializeField] private GameObject scoreText;
        [SerializeField] private int score;

        public void UpdateScore(int value)
        {
            score += value;
            scoreText.GetComponent<Text>().text = $"SCORE: {score}";
        }
    }
}
