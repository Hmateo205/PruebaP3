using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Detecta si el objeto que colisiona tiene la etiqueta "Player"
        {
            gameObject.SetActive(false);  // Desactivar el punto para simular que ha sido recogido
        }
    }
}
