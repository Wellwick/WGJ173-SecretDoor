using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField]
    private Transform centreSphere;

    [SerializeField, Min(0f)]
    private float projectDistance = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 direction = transform.position - centreSphere.position;
        transform.position += direction.normalized * projectDistance;
        transform.localScale *= projectDistance * 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
