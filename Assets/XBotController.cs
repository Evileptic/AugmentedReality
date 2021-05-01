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

    private void AngryButtonClick() => xBotAnimator.SetTrigger("Angry");
    private void SillyButtonClick() => xBotAnimator.SetTrigger("Silly");
    private void RumbaButtonClick() => xBotAnimator.SetTrigger("Rumba");
    private void HipHipButtonClick() => xBotAnimator.SetTrigger("HipHop");
}