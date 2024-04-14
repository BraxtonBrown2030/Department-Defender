using UnityEngine;
using UnityEngine.Events;

public class AnimationTrigger : MonoBehaviour
{
    public UnityEvent animationEvent;
    public Animator animator;
    
    
    public void TriggerAnimation()
    {
        animator.SetBool("Run", true);
        animator.SetBool("Stop", false);
    }
    
    public void StopAnimation()
    {
        animator.SetBool("Stop", true);
        animator.SetBool("Run", false);
    }
}
