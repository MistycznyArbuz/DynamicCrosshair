using UnityEngine;

public class DynamicCrosshair : MonoBehaviour
{
    private RectTransform rectile;

    private Rigidbody rb;

    [Range(1f, 7.5f)]
    public float scale = 5f; //power of resizing 

    [Range(-20f, 100f)]
    public float center = 30f; //change initial size of crosshair

    void Start()
    {
        rectile = GetComponent<RectTransform>();

        rb = GetComponentInParent<Rigidbody>();
    }

    void Update()
    {
        rectile.sizeDelta = new Vector2(center -rb.velocity.magnitude * scale, center -rb.velocity.magnitude * scale);
    }
}
