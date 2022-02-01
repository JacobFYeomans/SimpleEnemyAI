using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyAI : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    private float timeSnapshot;
    private float timeElapsed;
    private int jumps;
    // Start is called before the first frame update
    void Start()
    {
        timeSnapshot = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        timeElapsed = Time.time - timeSnapshot;

        if (timeElapsed > 5.0f)
        {
            Debug.Log("jump" + jumps);
            jumps++;
            timeElapsed = 0;
            timeSnapshot = Time.time;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.Rotate(180, 0, 0);
    }
}
