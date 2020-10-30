using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TriggerScript : MonoBehaviour
{
    gamestatus gamestatus;
    private void Start()
    {
        gamestatus = FindObjectOfType<gamestatus>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gamestatus.reward = -100;
        gamestatus.add_score();

    }


}
