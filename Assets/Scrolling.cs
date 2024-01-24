using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Scrolling : MonoBehaviour
{
  //  [SerializeField] private RawImage _img;
    //[SerializeField] private float _x, _y;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float width = 6f;
    private SpriteRenderer sr;
    private Vector2 size;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        size = new Vector2(sr.size.x, sr.size.y);
    }
    // Update is called once per frame
    void Update()
    {
        //_img.uvRect = new Rect(_img.uvRect.position + new Vector2(_x,_y) * Time.deltaTime,_img.uvRect.size);
        sr.size = new Vector2(sr.size.x + speed * Time.deltaTime, sr.size.y);

        if (sr.size.x > width) {
            sr.size = size;
        }
    }
}
