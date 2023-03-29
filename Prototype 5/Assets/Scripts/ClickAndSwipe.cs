using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(TrailRenderer), typeof(BoxCollider))]

public class ClickAndSwipe : MonoBehaviour
{
    private GameManager gameManager;
    private Camera cam;
    private Vector3 mousepos;
    private TrailRenderer trail;
    private BoxCollider col;
    private bool swiping = false;
    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
        trail = GetComponent<BoxCollider>();
        col = GetComponent<BoxCollider>();
        trail.enabled = false;
        col.enabled = false;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateMoudePosition()
    {
        mousePos = cam.Screen;
    }
}
