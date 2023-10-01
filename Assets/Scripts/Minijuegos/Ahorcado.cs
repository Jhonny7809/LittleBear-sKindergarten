using UnityEngine;
using UnityEngine.UI;

public class Ahorcado : MonoBehaviour
{
    public Text wordDisplayText;     // Texto para mostrar la palabra oculta.
    public Text guessedLettersText;  // Texto para mostrar las letras adivinadas.
    public Text attemptsLeftText;    // Texto para mostrar los intentos restantes.
    public InputField letterInputField; // InputField para que el jugador ingrese letras.
    public Button guessButton;       // Bot�n para adivinar una letra.

    private string secretWord;
    private string guessedLetters;
    private int maxAttempts;
    private int attemptsLeft;

    private void Start()
    {
        secretWord = "OAXACA"; // Palabra espec�fica para el juego de terror.
        maxAttempts = 6;
        attemptsLeft = maxAttempts;
        guessedLetters = "";

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
            // El juego ha terminado, puedes mostrar un mensaje aqu�.
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
        if (attemptsLeft <= 0)
        {
            // El jugador perdi�, puedes mostrar un mensaje aqu�.
            return true;
        }
        else if (!GetMaskedWord().Contains("_"))
        {
            // El jugador gan�, puedes mostrar un mensaje aqu�.
            return true;
        }
        return false;
    }
}
