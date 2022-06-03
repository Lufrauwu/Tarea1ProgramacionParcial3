using UnityEngine;

public class AnimatorIK : MonoBehaviour
{
    [SerializeField] private Animator _animator = default;
    public Transform obj = default;
    public Transform manoDerecha = default;

    private void OnAnimatorIK(int layerIndex)
    {
        if(obj != null)
        {
            _animator.SetLookAtWeight(1f);
            _animator.SetLookAtPosition(obj.position);
        }
        else
        {
            _animator.SetLookAtWeight(0f);
        }

        if(manoDerecha != null)
        {
            _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1f);
            _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1f);
            _animator.SetIKPosition(AvatarIKGoal.RightHand, manoDerecha.position);
            _animator.SetIKRotation(AvatarIKGoal.RightHand, manoDerecha.rotation);
        }
        else
        {
            _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 0f);
            _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 0f);
        }
    }
}
