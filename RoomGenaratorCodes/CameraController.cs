using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    public float speed;

    public Transform Target;

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (Target != null)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(Target.position.x, Target.position.y, transform.position.z), speed * Time.deltaTime);
    }

    public void ChangeTarget(Transform newTarget)
    {
        Target = newTarget;
    }
}
