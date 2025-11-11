using UnityEngine;

public class SizeManipulator : MonoBehaviour
{

    // Controls how fast the object grows or shrinks
    [SerializeField] private float scaleSpeed = 1f;

    // Determines how long before direction reverses (in seconds)
    [SerializeField] private float duration = 4f;

    // Internal timer to keep track of elapsed time
    private float timer = 0f;

    // Direction of scaling: 1 = growing, -1 = shrinking
    private int scaleSign = 1;

    void Update()
    {
        // Increase timer based on time passed since last frame
        timer += Time.deltaTime;

        // Changes scale in x, y, and z directions
        transform.localScale += Vector3.one * scaleSpeed * scaleSign * Time.deltaTime;

        // When the timer exceeds the duration, reverse scaling direction
        if (timer >= duration)
        {
            scaleSign *= -1;   // Flip direction (1 → -1 or -1 → 1)
            timer = 0f;        // Resets timer for next cycle
        }
    }
}

