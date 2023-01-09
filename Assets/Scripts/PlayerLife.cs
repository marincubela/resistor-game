using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private int battery = 100;
    [SerializeField] private Text livesText;

    public void Hurt(int damage)
    {
        battery -= damage;
        livesText.text = "Battery: " + battery + "%";
        if (battery <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
