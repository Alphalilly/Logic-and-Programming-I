using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float currentX;
    public float currentY;
    public float speed = 90;

    public Transform target;
    private Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        //dir = target.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentX += Input.GetAxis("Horizontal");
        currentY += Input.GetAxis("Vertical");

        dir = (target.position - Vector3.zero).normalized;

        //this.transform.position = Vector3.right * currentX + Vector3.up * currentY;
        //this.transform.rotation
        //this.transform.localScale

        this.transform.position = dir * currentX * speed * Time.deltaTime;
    }
}
