using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour
{
    [SerializeField] private Transform marble;
    public float gizmoRadius = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = marble.position;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, gizmoRadius);
    }
}
