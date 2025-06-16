using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    Animator anim;
    int horizontal;
    int vertical;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
    }
    public void UpdateAnimatorValues(float horizontalMovement, float verticalMovement)
    {
        anim.SetFloat(horizontal, horizontalMovement, 0.1f, Time.deltaTime);
        anim.SetFloat(vertical, verticalMovement, 0.1f, Time.deltaTime);
    }
}
