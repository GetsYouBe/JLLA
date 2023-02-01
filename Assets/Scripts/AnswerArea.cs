using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerArea : MonoBehaviour
{
    [SerializeField]
    private string answer;
    private List<char> words;
    private void Awake() {
        
    }
    private void Start() {
        words = new List<char>(answer.ToCharArray());
        foreach(char word in words){
            Debug.Log(word);
        }
    }
}
