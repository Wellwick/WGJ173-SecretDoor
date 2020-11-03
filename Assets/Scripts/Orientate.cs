using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientate : MonoBehaviour
{
    [SerializeField]
    private Transform rotator;

    [SerializeField]
    private float maxRotationSpeed = 10f;

    private Quaternion target;

    private Color success = Color.green, failure = Color.white;

    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.rotation;
        transform.rotation = rotator.rotation;
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update() {
        float angle = Quaternion.Angle(rotator.rotation, transform.rotation);
        float maxAnglesProgressed = maxRotationSpeed * Time.deltaTime;
        if (angle * (1f/Time.deltaTime) > maxAnglesProgressed) {
            transform.rotation = Quaternion.Lerp(transform.rotation, rotator.rotation, 1f - ((angle - maxAnglesProgressed) / angle));
        } else {
            transform.rotation = Quaternion.Lerp(transform.rotation, rotator.rotation, 0.5f);
        }

        if (Quaternion.Angle(transform.rotation, target) < 3f) {
            meshRenderer.materials[0].color = success;
        } else {
            meshRenderer.materials[0].color = failure;
        }

    }
}
