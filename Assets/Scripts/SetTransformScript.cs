using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTransformScript : MonoBehaviour
{
    //[SerializeField] private TransformVariable variable;

    private void Awake()
    {
        //variable.RuntimeValue = transform;
        GameObject.Find("Main Camera").GetComponent<CameraFollow>().SetTarget(transform);
    }

    private void OnDestroy()
    {
        //variable.RuntimeValue = null;
    }
}