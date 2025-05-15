using UnityEngine;

namespace Sample
{
    //마우스 회전 스크립트(클라스) 입니다.
    //카메라를 회전 시키는 스크립트입니다.
    //마우스의 움직임에 따라 카메라를 회전 시킵니다.
    //마우스의 움직임을 감지하기 위해 InputSystem을 사용
    public class MouseLook : MonoBehaviour
    {
        #region Variables
        //마우스 감도
        public float mouseSensitivity = 100.0f;
        //카메라 회전 각도
        public Transform cameraTrans; //카메라 트랜스폼

       

        //카메라 회전 각도
        float xRotation = 0.0f;
        #endregion

        #region Unity Event method
        private void Update()
        {
            //마우스 입력을 받아서 좌우 카메라를 회전 시킵니다.
            float mouseX = Input.GetAxis("Mouse X")*mouseSensitivity;
            //마우스 입력을 받아서 위 아래 카메라를 회전 시킵니다.
            this.transform.Rotate(Vector3.up * mouseX  * Time.deltaTime);



            //마우스 포지션 위 아래 입력받아 카메라 위, 아래 회전 시킵니다.
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
            mouseY = Mathf.Clamp(mouseY, -90f, 40f); //마우스 Y값을 제한합니다.
            cameraTrans.Rotate(Vector3.right * mouseY * Time.deltaTime);
        }
        #endregion
    }
}
