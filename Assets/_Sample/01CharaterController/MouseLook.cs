using UnityEngine;

namespace Sample
{
    //���콺 ȸ�� ��ũ��Ʈ(Ŭ��) �Դϴ�.
    //ī�޶� ȸ�� ��Ű�� ��ũ��Ʈ�Դϴ�.
    //���콺�� �����ӿ� ���� ī�޶� ȸ�� ��ŵ�ϴ�.
    //���콺�� �������� �����ϱ� ���� InputSystem�� ���
    public class MouseLook : MonoBehaviour
    {
        #region Variables
        //���콺 ����
        public float mouseSensitivity = 100.0f;
        //ī�޶� ȸ�� ����
        public Transform cameraTrans; //ī�޶� Ʈ������

       

        //ī�޶� ȸ�� ����
        float xRotation = 0.0f;
        #endregion

        #region Unity Event method
        private void Update()
        {
            //���콺 �Է��� �޾Ƽ� �¿� ī�޶� ȸ�� ��ŵ�ϴ�.
            float mouseX = Input.GetAxis("Mouse X")*mouseSensitivity;
            //���콺 �Է��� �޾Ƽ� �� �Ʒ� ī�޶� ȸ�� ��ŵ�ϴ�.
            this.transform.Rotate(Vector3.up * mouseX  * Time.deltaTime);



            //���콺 ������ �� �Ʒ� �Է¹޾� ī�޶� ��, �Ʒ� ȸ�� ��ŵ�ϴ�.
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
            mouseY = Mathf.Clamp(mouseY, -90f, 40f); //���콺 Y���� �����մϴ�.
            cameraTrans.Rotate(Vector3.right * mouseY * Time.deltaTime);
        }
        #endregion
    }
}
