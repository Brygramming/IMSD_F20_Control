using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMotion : MonoBehaviour
{
	public float UpY;
    public float DownY;
    public Rigidbody Body;

    // Start is called before the first frame update
    void Start()
    {
        Body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    	if(transform.position.y >= 3)
    	{
    		Body.AddForce(0, 0, 0, ForceMode.Force);
    		Body.AddForce(0, DownY, 0, ForceMode.Force);
    	}
    	else if(transform.position.y <= 1)
    	{
    		Body.AddForce(0, 0, 0, ForceMode.Force);
    		Body.AddForce(0, UpY, 0, ForceMode.Force);
    	}
    }
}