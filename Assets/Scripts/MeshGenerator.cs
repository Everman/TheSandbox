﻿using System;
using System.Collections;
using UnityEngine;
using UnityScript.Steps;

[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
{
    // Create an object for mesh
    private Mesh mesh;
    private Vector3[] vertices;
    private int[] triangles;

    [SerializeField] private int xSize = 20;
    [SerializeField] private int zSize = 20;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        createShape();
        updateMesh();
    }

    private void createShape()
    {
        vertices = new Vector3[(xSize + 1) * (zSize + 1)];
        int y = 0;
        int quadNumber = 0;

        for (int i = 0, z = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {
                // Should be changed to incorperate a quad instead of positive and negative, below is close?
                if ((x % 2 == 0) && (i % 2 == 0))
                {
                    y = UnityEngine.Random.Range(0, 2);
                }

                vertices[i] = new Vector3(x, y, z);
                i++;
            }
        }

        triangles = new int[xSize * zSize * 6];

        int vert = 0;
        int tris = 0;

        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {

                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = vert + xSize + 1;
                triangles[tris + 2] = vert + 1;
                triangles[tris + 3] = vert + 1;
                triangles[tris + 4] = vert + xSize + 1;
                triangles[tris + 5] = vert + xSize + 2;

                vert++;
                tris += 6;
            }
            vert++;
        }        
    }

    void updateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }

    //private void OnDrawGizmos()
    //{
    //    if (vertices == null) { return; }

    //    for (int i = 0; i < vertices.Length; i++ )
    //    {
    //        Gizmos.DrawSphere(vertices[i], 0.1f);
    //    }
    //}
}