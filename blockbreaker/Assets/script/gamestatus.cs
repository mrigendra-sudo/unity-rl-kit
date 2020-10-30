using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gamestatus : MonoBehaviour
{
    [SerializeField]static public int score=0;
    [SerializeField] public int reward;
    [SerializeField] Text Text;
    // Start is called before the first frame update
    void Start()
    {
        Text.text = score.ToString();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void add_score()
    {
        score = score + reward;
        Text.text = score.ToString();
    }


    
}
