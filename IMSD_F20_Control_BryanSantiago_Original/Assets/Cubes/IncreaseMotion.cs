using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMotion : MonoBehaviour
{
	public float UpY2;
    public float DownY2;
    public float Increase;
    //public float Decrease;
    public Rigidbody Body2;

    // Start is called before the first frame update
    void Start()
    {
        Body2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    	/*Multi *= UpY2;
    	Multi *= DownY2;*/
    	if(transform.position.y >= 3)
    	{
    		Body2.AddForce(0, 0, 0, ForceMode.Force);
    		Body2.AddForce(0, DownY2 - Increase, 0, ForceMode.Force);
    	}
    	else if(transform.position.y <= 1)
    	{
    		Body2.AddForce(0, 0, 0, ForceMode.Force);
    		Body2.AddForce(0, UpY2 + Increase, 0, ForceMode.Force);
    	}

    	if(Input.GetKeyDown(KeyCode.Space))//transform.position.y >= 1.5f && transform.position.y <= 1.7
    	{
    		Increase += Increase;
    	}
    	else if(Increase > 100)
    	{
    		Increase = 100;
    	}
    }
}