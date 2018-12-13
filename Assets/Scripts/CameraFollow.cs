using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class CameraFollow : MonoBehaviour {

    [SerializeField] private Transform target;
    [SerializeField] private float targetPos;

    public float cameraSpeed;

    [SerializeField] private float min;
    [SerializeField] private float max;
    
    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    public void SetTarget(TransformVariable target)
    {
        this.target = target.RuntimeValue;
    }

    public void SetTargetPosition(Vector3 targetPosition)
    {
        targetPos = targetPosition.x;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
            targetPos = Mathf.Clamp(target.position.x, min, max);
        transform.position = new Vector3(Mathf.MoveTowards(transform.position.x, targetPos, Time.deltaTime * cameraSpeed), 0, -10);
    }
}
