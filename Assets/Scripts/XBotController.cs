using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class XBotController : MonoBehaviour
{
    private Animator xBotAnimator;

    [SerializeField] private Button angryButton;
    [SerializeField] private Button sillyButton;
    [SerializeField] private Button rumbaButton;
    [SerializeField] private Button hipHipButton;

    private void Start()
    {
        xBotAnimator = GetComponent<Animator>();

        if (angryButton) angryButton.onClick.AddListener(() => PlayAnimation("Angry"));
        if (sillyButton) sillyButton.onClick.AddListener(() => PlayAnimation("Silly"));
        if (rumbaButton) rumbaButton.onClick.AddListener(() => PlayAnimation("Rumba"));
        if (hipHipButton) hipHipButton.onClick.AddListener(() => PlayAnimation("HipHop"));
    }

    private void PlayAnimation(string triggerName)
    {
        xBotAnimator.WriteDefaultValues();
        xBotAnimator.SetTrigger(triggerName);
    }
}