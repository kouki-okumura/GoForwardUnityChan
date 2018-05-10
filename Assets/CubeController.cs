using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
    private float speed = -0.2f;
    private float deadLine = -10;
    public AudioClip block;
    AudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = block;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(this.speed, 0, 0);
        if(transform.position.x<this.deadLine)
        {
            Destroy(gameObject);
        }
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("aiu");
        if (other.gameObject.tag == "Cube" || other.gameObject.tag == "Ground")
        {
            audioSource.PlayOneShot(block);
        }
            

        
    }
}


