using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        transform.Rotate(
    rotationSpeed * Time.deltaTime,
    rotationSpeed * Time.deltaTime,
    0
);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}