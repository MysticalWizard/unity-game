using UnityEngine;
using TMPro;


public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<TypewritterEffect>().Run("end my suffering\nPlease", textLabel);
    }
}
