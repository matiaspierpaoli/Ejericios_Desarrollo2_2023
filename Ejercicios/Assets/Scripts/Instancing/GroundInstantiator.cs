using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Button _button;

    private void Start()
    {
        var newChild = Instantiate(prefab, transform);
        //_button.
    }
}
