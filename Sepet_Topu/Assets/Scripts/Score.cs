using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject scoreEffect;

    // Start is called before the first frame update
    void Start()
    {
        scoreEffect.SetActive(false);
    }

	private void OnTriggerEnter(Collider other)
	{
		if(other.GetComponent<Ball>() != null)
		{
            scoreEffect.SetActive(true);
		}
	}
}
