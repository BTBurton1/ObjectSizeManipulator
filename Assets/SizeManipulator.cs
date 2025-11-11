using UnityEngine;

public class SizeManipulator : MonoBehaviour
{

    [SerializeField] private float scaleSpeed = 1f;

    [SerializeField] private float duration = 4f;

    private float timer = 0f;

    private int scaleSign = 1;

    void Update()
    {
        timer += Time.deltaTime;

        transform.localScale += Vector3.one * scaleSpeed * scaleSign * Time.deltaTime;

        if (timer >= duration)
        {
            scaleSign *= -1;  
            timer = 0f;        
        }
    }
}

