using System.Collections;
using UnityEngine;
using TMPro;


public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject testDialogue;

    private TypewritterEffect typewritterEffect;
    private void Start()
    {
        typewritterEffect = GetComponent<TypewritterEffect>();
        ShowDialogue(testDialogue);
    }

    public void ShowDialogue(DialogueObject dialogueObject)
    {
        StartCoroutine(StepThroughDialogue(dialogueObject));
    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {
        foreach (string dialogue in dialogueObject.Dialogue)
        {
          yield return typewritterEffect.Run(dialogue, textLabel);
          yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        }


    }
}
