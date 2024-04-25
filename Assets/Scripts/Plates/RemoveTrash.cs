using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveTrash : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
