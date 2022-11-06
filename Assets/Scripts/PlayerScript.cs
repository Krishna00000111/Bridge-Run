using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody playrRb;

    public float playerSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        playrRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontalinput = Input.GetAxis("Horizontal");

        playrRb.AddForce(Vector3.right * Horizontalinput * playerSpeed * Time.deltaTime, ForceMode.Impulse);
    }
}
