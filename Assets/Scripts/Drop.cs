using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Ajoutez cette ligne pour utiliser TextMeshPro

public class Drop : MonoBehaviour
{
    public MovementEtTir player;
    private Rigidbody2D rb;

    // Ajoutez ces lignes pour le compteur et l'affichage du texte
    public static int dropCount = 0; // Compteur pour les objets Drop détruits
    public TextMeshProUGUI dropText; // Référence à votre objet TextMeshPro

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Initialisez votre texte avec le compteur actuel
        dropText.text = "Score: " + dropCount;
    }

    void Update()
    {
        // Mettez à jour le texte avec le compteur actuel
        dropText.text = "Score: " + dropCount;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.gameObject.GetComponent<MovementEtTir>();
        if (player)
        {
            Debug.Log("blabala");
            dropCount++; // Incrémentez le compteur lorsque l'objet Drop est détruit
            Destroy(gameObject);
        }
    }
}