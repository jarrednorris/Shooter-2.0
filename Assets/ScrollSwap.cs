using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollSwap : MonoBehaviour
{
    public float scrollSpeed = 2.0f;
    public BackgroundScroll one, two, three;

    private void Update()
    {
        //one.start.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        //two.start.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        //if (one.end.position.x < 0)
        //    one.start.position = two.end.position;
        //if (two.end.position.x < 0)
        //    two.start.position = one.end.position;

        one.start.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        two.start.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        three.start.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        if (one.end.position.x < 0)
            one.start.position = two.end.position;
        if (two.end.position.x < 0)
            two.start.position = three.end.position;
        if (three.end.position.x < 0)
            three.start.position = one.end.position;
    }

    [System.Serializable]
    public struct BackgroundScroll
    {
        public Transform start, end;
    }
}