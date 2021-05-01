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

        if (angryButton)
            angryButton.onClick.AddListener(AngryButtonClick);
        if (sillyButton)
            sillyButton.onClick.AddListener(SillyButtonClick);
        if (rumbaButton)
            rumbaButton.onClick.AddListener(RumbaButtonClick);
        if (hipHipButton)
            hipHipButton.onClick.AddListener(HipHipButtonClick);
    }

    private void AngryButtonClick() => PlayAnimation("Angry");
    private void SillyButtonClick() => PlayAnimation("Silly");
    private void RumbaButtonClick() => PlayAnimation("Rumba");
    private void HipHipButtonClick() => PlayAnimation("HipHop");

    private void PlayAnimation(string triggerName)
    {
        foreach (var param in xBotAnimator.parameters)
            if (param.type == AnimatorControllerParameterType.Trigger)
                xBotAnimator.ResetTrigger(param.name);

        xBotAnimator.SetTrigger(triggerName);
    }
}