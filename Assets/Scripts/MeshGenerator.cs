using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour
{
    public Material mat;

    float width = 0.5f;
    public float xValue = 0;
    public float yValue = 0;
    public float zValue = 0;

	void Update()
	{
		Mesh mesh = new Mesh();

		//Vertices array
		Vector3[] vertices = new Vector3[18];

        Vector3 center = transform.GetChild(0).position;
        Vector3 regulator1 = transform.GetChild(1).position; //city 1
        Vector3 regulator2 = transform.GetChild(2).position; //city 2
        Vector3 regulator3 = transform.GetChild(3).position;
        Vector3 regulator4 = transform.GetChild(4).position;
        Vector3 regulator5 = transform.GetChild(5).position;
        Vector3 regulator6 = transform.GetChild(6).position;


        vertices[0] = center;
        vertices[1] = regulator1;
        vertices[2] = regulator2;

        vertices[3] = center;
		vertices[4] = regulator2;
        vertices[5] = regulator3;

        vertices[6] = center;
        vertices[7] = regulator3;
        vertices[8] = regulator4;

        vertices[9] = center;
        vertices[10] = regulator4;
        vertices[11] = regulator5;

        vertices[12] = center;
        vertices[13] = regulator5;
        vertices[14] = regulator6;

        vertices[15] = center;
        vertices[16] = regulator6;
        vertices[17] = regulator1;


        mesh.vertices = vertices;

        mesh.triangles = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

		GetComponent<MeshRenderer>().material = mat;

		GetComponent<MeshFilter>().mesh = mesh;
		mesh.RecalculateNormals();
	}
}
