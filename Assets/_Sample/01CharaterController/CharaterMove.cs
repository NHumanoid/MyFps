using UnityEngine;
using UnityEngine.InputSystem; //InputSystem을 사용하기 위해 추가합니다.

namespace Sample
{
    //캐릭터 관리 스크립트(클라스) 입니다.
    public class CharaterMove : MonoBehaviour
    {
        #region Variables

        private CharacterController controller;
        //입력 - 이동 방향
        Vector2 inputMove;

        private float moveSpeed = 5.0f; //이동 속도

        #endregion


        #region Unity Event method
        void Start()
        {
            //캐릭터 컨트롤러 컴포넌트를 가져옵니다. (참조)
            controller = this.GetComponent<CharacterController>();
        }
        void Update()
        {
            Vector3 moveDir = Vector3.right * inputMove.x + Vector3.forward * inputMove.y;

            //키보드 입력을 받아서 캐릭터를 이동시킵니다.
            controller.Move(moveDir * Time.deltaTime * moveSpeed); 
        }
        #endregion

        #region Constom Method
        //MoveInput 시스템이 등록 할 함수
        public void OnMove(InputAction.CallbackContext context)
        {
            inputMove = context.ReadValue<Vector2>();
        }

        #endregion
    }
}
