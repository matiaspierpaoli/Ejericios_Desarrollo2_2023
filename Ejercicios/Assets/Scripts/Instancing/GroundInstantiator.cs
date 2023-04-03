using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    private void Start()
    {
        var newChild = Instantiate(prefab, transform);
    }
}
