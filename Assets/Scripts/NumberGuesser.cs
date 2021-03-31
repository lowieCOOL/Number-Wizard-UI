using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberGuesser : MonoBehaviour
{
    [SerializeField] int maximumNumber;
    [SerializeField] int minimumNumber;
    int guess;
    [SerializeField] TextMeshProUGUI guessText;
    string stringedGuess;
    int[] allGuesses;
    int guessCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void LowerGuess()
    {
        maximumNumber = guess - 1;
        NextGuess();
    }

    public void HigherGuess()
    {
        minimumNumber = guess + 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(minimumNumber, maximumNumber + 1);
        stringedGuess = guess.ToString();
        Debug.Log(stringedGuess);
        guessText.text = stringedGuess;
    }
}
