using UnityEngine;
using UnityEngine.Events;

public class AnimationTrigger : MonoBehaviour
{
    public UnityEvent animationEvent;
    public Animator animator;
    
    
    public void TriggerAnimation()
    {
        animator.SetBool("Run", true);
    }
    
    public void StopAnimation()
    {
        animator.SetBool("Run", false);
    }
}
