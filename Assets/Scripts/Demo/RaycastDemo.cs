using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDemo : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float rayLength = 50f;
    [SerializeField]
    LayerMask hitLayer;

    private bool isMoving;
    private Vector3 targetPosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isMoving)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * rayLength, Color.yellow);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, rayLength, hitLayer);
            if (hit)
            {
                isMoving = true;
                targetPosition = hit.transform.position;
                Debug.Log("hit");
            }
        }

        if (isMoving)
        {
            Debug.Log("move");
            this.transform.position = Vector3.MoveTowards(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
            if (this.transform.position.Equals(targetPosition))
            {
                isMoving = false;
            }
        }
        
    }
}
