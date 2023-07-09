using UnityEngine;
using System.Collections;
public class Follow : MonoBehaviour
{
    public Transform target;
    //public float smooth = 5.0f;
    public Vector3 offset;
    void Update()
    {
        //transform.position = Vector3.Lerp(
        //    transform.position, target.position,
        //    Time.deltaTime * smooth);
        transform.position = target.position + offset;
    }
}