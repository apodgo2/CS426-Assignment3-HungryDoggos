using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMovement : MonoBehaviour
{

    public float timer;
    public int newTarget;
    public float speed;
    public NavMeshAgent Nav;
    public Vector3 target;

    // Use this for initialization
    void Start()
    {
        Nav = gameObject.GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= newTarget)
        {
            newtarget();
            timer = 0;
            Nav.speed = speed;
        }
    }

    void newtarget()
    {
        float myX = gameObject.transform.position.x;
        float myZ = gameObject.transform.position.z;

        float xPos = myX - Random.Range(myX - 100, myX + 100);
        float zPos = myZ - Random.Range(myZ - 100, myZ + 100);

        target = new Vector3(xPos, gameObject.transform.position.y, zPos);

        Nav.SetDestination(target);
    }
}
