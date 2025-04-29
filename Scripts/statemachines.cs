using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statemachines : MonoBehaviour
{
    public enum State
    {
        idle,
        walking,
        swimming,
        climbing
    }

    public State currentState = State.idle;
    Vector3 lastposition;
    // Start is called before the first frame update
    void Start()
    {
        lastposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case State.idle: Idle(); break;
            case State.walking: Walking(); break;
            case State.swimming: Swimming(); break;
            case State.climbing: climbing(); break;
            default: break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "WaterTrigger")
        {
            currentState = State.swimming;
        }
        else if (other.name == "MountainTrigger")
        {
            currentState = State.climbing;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        currentState = State.walking;
    }

    void Swimming()
    {
        Debug.Log("I am Swimming");
    }

    void climbing()
    {
        Debug.Log("I am climbing");
    }
     void Idle()
    {
        Debug.Log("I am idle");
        if (lastposition != transform.position)
        {
            currentState = State.walking;
        }
        lastposition = transform.position;
    }


    void Walking()
    {
        Debug.Log("I am Walking");
        if (lastposition == transform.position)
        {
            currentState = State.idle;
        }
        lastposition = transform.position;
    }
}

