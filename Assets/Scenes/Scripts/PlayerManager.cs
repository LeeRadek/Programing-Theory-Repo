using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    List<Unit> unitList = new List<Unit>();
    void Start()
    {
        ShowCoursor();
    }

    // Update is called once per frame
    void Update()
    {
        ChcekObject();
        MoveTo();
    }

    void ShowCoursor()
    {
        Cursor.visible = true;
    }

    void ChcekObject()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray,out hit, Mathf.Infinity);

            Debug.DrawRay(ray.origin, ray.direction.normalized , Color.blue, 10);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if(hit.collider != null)
                {
                    if(hit.collider.GetComponent<Unit>() != null)
                    {
                        unitList.Add(hit.collider.GetComponent<Unit>());
                        hit.collider.GetComponent<Unit>().ShowLabel();
                    }
                }
            }
        }
        
    }

    void MoveTo()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                unitList[0].Move(hit.point);
            }
        }
    }
}
