using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToMouse : MonoBehaviour
{
    public static List<MoveToMouse> moveableObjects = new List<MoveToMouse>();
    private Vector3 target;
    private bool selected;
    private NavMeshAgent agent;

    private Color guyBrown;


    void Start()
    {
        moveableObjects.Add(this);
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && selected)
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            agent.SetDestination(target);
            selected = false;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0.4716981f, 0.2589889f, 0.2589889f);
        }
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        { 
            selected = true;
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;

            foreach(MoveToMouse obj in moveableObjects)
            {
                if (obj != this)
                {
                    obj.selected = false;
                    obj.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.4716981f, 0.2589889f, 0.2589889f);
                }
            }
        }

    }
}
