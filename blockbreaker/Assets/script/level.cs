using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    [SerializeField] int Breakable_Blocks;
    gamestatus gamestatus;
    private void Start()
    {
        gamestatus = FindObjectOfType<gamestatus>();
    }
    public void countblock()
    {
        Breakable_Blocks++;

    }
    public void destroyblock()
    {
        Breakable_Blocks--;
        if (Breakable_Blocks <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            gamestatus.reward = 100;
            gamestatus.add_score();
        }
    }
   
}
