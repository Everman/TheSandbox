using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour
{

    private Mesh mesh;
    private Vector3[] vertices;
    private int[] triangles;

    private int xSize = 20;
    private int zSize = 20;

    // Start is called before the first frame update
    void Start()
    {
        createShape();
    }

    private void createShape()
    {
        vertices = new Vector3[(xSize + 1) * (zSize + 1)];

        int i = 0;
        for (int z = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {
                vertices[i] = new Vector3(x, 0, z);
            }
        }
    }
}
