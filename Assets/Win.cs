using UnityEngine;
using System.Collections.Generic;

public class Win : MonoBehaviour
{
    public List<string> dropAreaTags; // Lista de tags de �reas de destino.
    public List<PuzzlePiece> puzzlePieces; // Lista de piezas de rompecabezas.
    public GameObject victoryPanel; // Panel de victoria.

    private void Start()
    {
        victoryPanel.SetActive(false); // Desactiva el panel de victoria al inicio.
    }

    private void Update()
    {
        bool allPiecesInPlace = true;

        for (int i = 0; i < puzzlePieces.Count; i++)
        {
            if (!IsPieceInPlace(puzzlePieces[i], dropAreaTags[i]))
            {
                allPiecesInPlace = false; // Al menos una pieza no est� en su lugar.
            }
        }

        // Si todas las piezas est�n en su lugar, activa el panel de victoria.
        if (allPiecesInPlace)
        {
            victoryPanel.SetActive(true);
            Debug.Log("�Ganaste!");
        }
    }

    bool IsPieceInPlace(PuzzlePiece piece, string dropAreaTag)
    {
        GameObject[] dropAreas = GameObject.FindGameObjectsWithTag(dropAreaTag);

        foreach (GameObject dropArea in dropAreas)
        {
            float distance = Vector3.Distance(piece.transform.position, dropArea.transform.position);
            float tolerance = 0.5f; // Ajusta seg�n sea necesario.

            if (distance < tolerance)
            {
                return true;
            }
        }

        return false;
    }
}