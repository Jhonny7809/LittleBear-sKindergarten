using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public List<string> dropAreaTags; // Lista de tags de áreas de destino.
    public List<PuzzlePiece> puzzlePieces; // Lista de piezas de rompecabezas.
    public GameObject victoryPanel; // Panel de victoria.
    public GameObject GamePanel;
    public Button button;
    public FPSController fpsController;
    public bool completado;
    public GameObject hud;

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
                allPiecesInPlace = false; // Al menos una pieza no está en su lugar.
            }
        }

        // Si todas las piezas están en su lugar, activa el panel de victoria.
        if (allPiecesInPlace)
        {
            victoryPanel.SetActive(true);
            GamePanel.SetActive(false);
            completado = true;
        }
    }

    bool IsPieceInPlace(PuzzlePiece piece, string dropAreaTag)
    {
        GameObject[] dropAreas = GameObject.FindGameObjectsWithTag(dropAreaTag);

        foreach (GameObject dropArea in dropAreas)
        {
            float distance = Vector3.Distance(piece.transform.position, dropArea.transform.position);
            float tolerance = 100f; // Ajusta según sea necesario.

            if (distance < tolerance)
            {
                return true;
            }
        }

        return false;
    }

    public void BackToGame()
    {
        hud.SetActive(false);
        victoryPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        fpsController.enabled = true;
    }
}