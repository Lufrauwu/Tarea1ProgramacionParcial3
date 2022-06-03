using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] Animator _animator = default;
    private float _speed = 1f;
    private readonly int _ahVelocidad = Animator.StringToHash("velocidad");
    private readonly int _ahSaltar = Animator.StringToHash("saltar");

    void Update()
    {
        Animations();
    }

    private void Animations()
    {
        float vertical = Input.GetAxis("Vertical") * _speed;


        if (Input.GetKey(KeyCode.LeftShift))
        {
            _animator.SetInteger(_ahVelocidad, Mathf.FloorToInt(vertical) * 2);
            vertical *= Time.deltaTime;
            transform.Translate(0, 0, vertical);
        }
        else
        {
            _animator.SetInteger(_ahVelocidad, Mathf.FloorToInt(vertical));
            vertical *= Time.deltaTime;
            transform.Translate(0, 0, vertical);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger(_ahSaltar);

        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _animator.SetLayerWeight(1, 1f);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            _animator.SetLayerWeight(1, 0f);
        }
    }
}
