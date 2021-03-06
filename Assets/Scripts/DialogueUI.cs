using System.Collections;
using UnityEngine;
using TMPro;


public class DialogueUI : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject testDialogue;

    private TypewritterEffect typewritterEffect;
    private void Start()
    {
        typewritterEffect = GetComponent<TypewritterEffect>();
        CloseDialogueBox();
        ShowDialogue(testDialogue);
    }

    public void ShowDialogue(DialogueObject dialogueObject)
    {
        dialogueBox.SetActive(true);
        StartCoroutine(StepThroughDialogue(dialogueObject));
    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {
        foreach (string dialogue in dialogueObject.Dialogue)
        {
          yield return typewritterEffect.Run(dialogue, textLabel);
          yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        }
        CloseDialogueBox();
    }
    private void CloseDialogueBox()
    {
    dialogueBox.SetActive(false);
    textLabel.text=string.Empty;
    }
}
