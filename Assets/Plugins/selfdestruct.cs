using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfdestruct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
	}
	
	IEnumerator ExampleCoroutine()
    {
		
		//yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3);
		Destroy(gameObject);
	}
}
