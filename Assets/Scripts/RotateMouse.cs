using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMouse : MonoBehaviour
{

	public Transform target;
	public Vector3 offset;
	public float sensitivity = 3; // ���������������� �����
	public float limit = 80; // ����������� �������� �� Y
	public float zoom = 0.25f; // ���������������� ��� ����������, ��������� �����
	public float zoomMax = 10; // ����. ����������
	public float zoomMin = 5; // ���. ����������
	private  float X=30, Y=0,Z=0;

	void Start()
	{
		limit = Mathf.Abs(limit);
		if (limit > 90) limit = 90;
		offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax) );
		transform.position = target.position + offset;
	}

	void Update()
	{
		if (Input.GetAxis("Mouse ScrollWheel") > 0) offset.z += zoom;
		else if (Input.GetAxis("Mouse ScrollWheel") < 0) offset.z -= zoom;
		offset.z = Mathf.Clamp(offset.z, -Mathf.Abs(zoomMax), -Mathf.Abs(zoomMin));

        if (Input.GetMouseButton(1))
        {
			Y = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
        }
		transform.localEulerAngles = new Vector3(X, Y, Z);
		transform.position = transform.localRotation * offset + target.position;
	}
}