using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    level level;
    gamestatus gamestatus;
    private void Start()
    {
        
        level = FindObjectOfType<level>();
        gamestatus = FindObjectOfType<gamestatus>();
        level.countblock();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        level.destroyblock();
        gamestatus.reward = 10;
        gamestatus.add_score();
        
    }

}
