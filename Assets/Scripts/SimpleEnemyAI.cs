using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyAI : MonoBehaviour
{
    public float moveSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.Rotate(180, 0, 0);
    }
}
