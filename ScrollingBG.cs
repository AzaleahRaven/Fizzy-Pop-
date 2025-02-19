using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingBG : MonoBehaviour
{
    [SerializeField] private RawImage _img;
    [SerializeField] private float _z;

    void Update()
    {
        _img.uvRect = new Rect(
            _img.uvRect.position + new Vector2(0, _z) * Time.deltaTime,
            _img.uvRect.size
        );
    }
}
