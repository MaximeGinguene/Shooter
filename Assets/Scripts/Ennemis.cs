using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemis : MonoBehaviour
{
    public float speed = 2.0f; // Vitesse de d�placement
    public float maxOffset = 2.0f; // Distance maximale de d�placement � gauche ou � droite

    private Vector3 startPosition;

    void Start()
    {
        // Enregistrez la position de d�part
        startPosition = transform.position;
    }

    void Update()
    {
        // D�placez l'ennemi de gauche � droite
        float newXPosition = Mathf.Sin(Time.time * speed) * maxOffset;
        Vector3 newPosition = startPosition + new Vector3(newXPosition, 0, 0);

        // Convertissez la position en coordonn�es de la cam�ra
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(newPosition);

        // Assurez-vous que la position reste � l'int�rieur de la cam�ra
        viewportPosition.x = Mathf.Clamp(viewportPosition.x, 0.1f, 0.9f);

        // Convertissez la position de retour en coordonn�es du monde
        transform.position = Camera.main.ViewportToWorldPoint(viewportPosition);
    }
}
