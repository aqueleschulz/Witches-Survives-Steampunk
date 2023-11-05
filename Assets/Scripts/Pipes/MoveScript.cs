using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float limitPosition = -15f;
    public float moveSpeed = 5;

    void Update()
    {
        transform.position = (transform.position + (Vector3.left * moveSpeed) * Time.deltaTime);

        if(this.transform.position.x <= limitPosition)
        Destroy(this.gameObject);
    }
}
