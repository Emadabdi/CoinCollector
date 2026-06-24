using UnityEngine;

using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource audioSource =
                FindFirstObjectByType<AudioSource>();

            if (audioSource != null)
            {
                audioSource.Play();
            }

            GameManager.Instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}