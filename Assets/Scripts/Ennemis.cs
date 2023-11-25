using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemis : MonoBehaviour
{
    public float speed = 2.0f; // Vitesse de déplacement
    public float maxOffset = 2.0f; // Distance maximale de déplacement à gauche ou à droite

    private Vector3 startPosition;

    void Start()
    {
        // Enregistrez la position de départ
        startPosition = transform.position;
    }

    void Update()
    {
        // Déplacez l'ennemi de gauche à droite
        float newXPosition = Mathf.Sin(Time.time * speed) * maxOffset;
        Vector3 newPosition = startPosition + new Vector3(newXPosition, 0, 0);

        // Convertissez la position en coordonnées de la caméra
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(newPosition);

        // Assurez-vous que la position reste à l'intérieur de la caméra
        viewportPosition.x = Mathf.Clamp(viewportPosition.x, 0.1f, 0.9f);

        // Convertissez la position de retour en coordonnées du monde
        transform.position = Camera.main.ViewportToWorldPoint(viewportPosition);
    }
}
