using UnityEngine;
using UnityEngine.UI;

public class Ahorcado : MonoBehaviour
{
    public Text wordDisplayText;     // Texto para mostrar la palabra oculta.
    public Text guessedLettersText;  // Texto para mostrar las letras adivinadas.
    public Text attemptsLeftText;    // Texto para mostrar los intentos restantes.
    public InputField letterInputField; // InputField para que el jugador ingrese letras.
    public Button guessButton;       // Botón para adivinar una letra.
    public GameObject victoryPanel;
    public GameObject lossPanel;
    public GameObject thisPannel;
    public FPSController fpsController;
    public GameObject hud;

    public string secretWord;
    private string guessedLetters;
    private int maxAttempts;
    private int attemptsLeft;

    public bool completado;

    private void Start()
    {
        maxAttempts = 6;
        attemptsLeft = maxAttempts;
        guessedLetters = "";
        victoryPanel.SetActive(false);
        lossPanel.SetActive(false);

        UpdateUI();
    }

    public void GuessLetter()
    {
        string input = letterInputField.text.ToUpper();
        if (input.Length == 1 && char.IsLetter(input[0]))
        {
            char letter = input[0];

            if (!guessedLetters.Contains(letter.ToString()))
            {
                guessedLetters += letter;
                if (!secretWord.Contains(letter.ToString()))
                {
                    attemptsLeft--;
                }
            }
        }

        UpdateUI();

        if (IsGameOver())
        {
            if (attemptsLeft <= 0)
            {
                // Si el jugador perdió, activa el panel de derrota.
                lossPanel.SetActive(true);
            }
            else
            {
                // Si el jugador ganó, activa el panel de victoria.
                victoryPanel.SetActive(true);
                thisPannel.SetActive(false);
                completado = true;
            }
        }
    }

    private void UpdateUI()
    {
        wordDisplayText.text = GetMaskedWord();
        guessedLettersText.text = "Letras adivinadas: " + guessedLetters;
        attemptsLeftText.text = "Intentos restantes: " + attemptsLeft;
    }

    private string GetMaskedWord()
    {
        string maskedWord = "";
        foreach (char letter in secretWord)
        {
            if (guessedLetters.Contains(letter.ToString()))
            {
                maskedWord += letter;
            }
            else
            {
                maskedWord += "_";
            }
        }
        return maskedWord;
    }

    private bool IsGameOver()
    {
        return attemptsLeft <= 0 || !GetMaskedWord().Contains("_");
    }
    public void BackToGame()
    {
        hud.SetActive(true);
        victoryPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        fpsController.enabled = true;
    }
    public void RestartGame()
    {
        // Reinicia las variables del juego.
        attemptsLeft = maxAttempts;
        guessedLetters = secretWord.Length > 0 ? new string('_', secretWord.Length) : "";

        // Oculta el panel de derrota.
        lossPanel.SetActive(false);

        // Actualiza la interfaz de usuario.
        UpdateUI();
    }
}
