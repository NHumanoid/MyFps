using UnityEngine;
using UnityEngine.InputSystem; //InputSystem�� ����ϱ� ���� �߰��մϴ�.

namespace Sample
{
    //ĳ���� ���� ��ũ��Ʈ(Ŭ��) �Դϴ�.
    public class CharaterMove : MonoBehaviour
    {
        #region Variables

        private CharacterController controller;
        //�Է� - �̵� ����
        Vector2 inputMove;

        private float moveSpeed = 5.0f; //�̵� �ӵ�

        #endregion


        #region Unity Event method
        void Start()
        {
            //ĳ���� ��Ʈ�ѷ� ������Ʈ�� �����ɴϴ�. (����)
            controller = this.GetComponent<CharacterController>();
        }
        void Update()
        {
            Vector3 moveDir = Vector3.right * inputMove.x + Vector3.forward * inputMove.y;

            //Ű���� �Է��� �޾Ƽ� ĳ���͸� �̵���ŵ�ϴ�.
            controller.Move(moveDir * Time.deltaTime * moveSpeed); 
        }
        #endregion

        #region Constom Method
        //MoveInput �ý����� ��� �� �Լ�
        public void OnMove(InputAction.CallbackContext context)
        {
            inputMove = context.ReadValue<Vector2>();
        }

        #endregion
    }
}
