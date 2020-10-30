using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    readonly float speed = 10.0f;
    
    float xmin = -4.38f;
    float xmax = 6.86f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
    private void LateUpdate()
    {
        Vector3 viewposition = transform.position;
        viewposition.x = Mathf.Clamp(viewposition.x, xmin, xmax);
        transform.position = viewposition;
        
    }
}
