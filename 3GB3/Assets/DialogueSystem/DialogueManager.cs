
using UnityEngine;

using UnityEngine.UI;

using TMPro;




public class DialogueManager : MonoBehaviour
{
	public TextMeshProUGUI speakerName, dialogue, navButtonText;

	private int currentIndex;
	private Conversation currentConvo;
	private static DialogueManager instance;
	
	
	private void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public static void StartConversation(Conversation convo)
	{
		instance.currentIndex = 0;
		instance.currentConvo = convo;
		instance.speakerName.text = "";
		instance.dialogue.text = "";
		instance.navButtonText.text = ">";

		instance.ReadNext();
	}
	public void ReadNext()
    {
		speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName();
		dialogue.text = currentConvo.GetLineByIndex(currentIndex).dialogue;
		currentIndex++;
    }


}