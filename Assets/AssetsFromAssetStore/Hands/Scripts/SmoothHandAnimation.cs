using UnityEngine.InputSystem;
using UnityEngine;

public class SmoothHandAnimation : MonoBehaviour
{
   [SerializeField] private Animator handAnimator;
   [SerializeField] private InputActionReference triggerActionReference;
   [SerializeField] private  InputActionReference gripActionReference;

   private static readonly int triggerAnimation = Animator.StringToHash("Trigger");
   private static readonly int gripAnimation = Animator.StringToHash("Grip");

    void Update() 
   {
    float triggerValue = triggerActionReference.action.ReadValue<float>();
    handAnimator.SetFloat(triggerAnimation, triggerValue);

     float gripValue = gripActionReference.action.ReadValue<float>();
    handAnimator.SetFloat(gripAnimation, gripValue);
   }
}
