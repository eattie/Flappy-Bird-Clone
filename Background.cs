using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Renderer quadRenderer;

    private void Start()
    {
        quadRenderer = GetComponent<Renderer>();
        
    }
    private void Update()
    {
        float offset = Time.time * scrollSpeed;
        quadRenderer.material.mainTextureOffset = new Vector2(offset, 0);

    }
}
