using UnityEngine;

public class FloatUpAndDown : MonoBehaviour
{
    [Header("Up and Down Pins")]
    [SerializeField] public float Amplitude = 0.5f;
    [SerializeField] public float Frequency = 1f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float yOffset = Mathf.Sin(Time.time * Frequency) * Amplitude;

        transform.localPosition = new Vector3(
            startPos.x,
            startPos.y + yOffset,
            startPos.z
        );
    }
}