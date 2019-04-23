using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jellyfish : MonoBehaviour
{
    [Header("Settings")]
    // the key used to activate the push
    public KeyCode key = KeyCode.Space;

    [Header("Movement")]
    [Tooltip("Speed of movement")]
    public float speed = 5f;
    public float rotateSpeed = 1f;

    private Vector2 movement, cachedDirection;
    private float moveHorizontal;
    private float moveVertical;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }

    // FixedUpdate is called every frame when the physics are calculated
    void FixedUpdate()
    {
        if (Input.GetKey(key))
        {
            GetComponent<Rigidbody2D>().freezeRotation = true;
            GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, speed));
        }
        else
        {
            GetComponent<Rigidbody2D>().freezeRotation = false;
            GetComponent<Rigidbody2D>().MoveRotation(GetComponent<Rigidbody2D>().rotation + rotateSpeed);
        }
    }
}
