using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMotor : MonoBehaviour
{
    public float agentSpeed = 5.1f;
    public Transform Player;
    public NavMeshAgent Nav;

    // Start is called before the first frame update
    void Start()
    {
        Nav.speed = agentSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray, out hit))
            {
                Player.position = hit.point;
            }
        }
    }




}
