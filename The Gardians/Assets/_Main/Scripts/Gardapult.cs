using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gardapult : MonoBehaviour
{
    public LineRenderer[] lineRenderers;
    public Transform[] stripPositions;
    public Transform center;
    public Transform idlePosition;

    public Vector3 currentPosition;
    public float maxLenght;
    public float bottomBounday;

    public GameObject huevoPrefab;
    Rigidbody2D huevo;
    Collider2D huevoCollider;
    public float huevoPositionOffset;

    public float force;   

    bool isMouseDown;
    void Start()
    {
        lineRenderers[0].positionCount = 2;
        lineRenderers[1].positionCount = 2;
        lineRenderers[0].SetPosition(0, stripPositions[0].position);
        lineRenderers[1].SetPosition(0, stripPositions[1].position);

        CreateHuevo();
    }
    // CreateHuevo para crear el proyectil del huevo
    void CreateHuevo()
    { 
        huevo = Instantiate(huevoPrefab).GetComponent<Rigidbody2D>();
        huevoCollider = huevo.GetComponent<Collider2D>();
        huevoCollider.enabled = false;
        huevo.isKinematic = true;

        ResetStrips();
    }

    void Update()
    {
        if (isMouseDown)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10;

            currentPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            currentPosition = center.position + Vector3.ClampMagnitude(currentPosition - center.position, maxLenght);
            currentPosition = ClampBounday(currentPosition);

            SetStrips(currentPosition);

            if (huevoCollider)
            {
                huevoCollider.enabled = true;
            }
        }
        else
        {
            ResetStrips();
        }
    }

    private void OnMouseDown()
    {
        isMouseDown = true;
    }
    private void OnMouseUp()
    {
        isMouseDown=false;
        ShootHuevo();
    }

    // Metodo para disparar al huevo
    void ShootHuevo()
    {
        huevo.isKinematic=false;
        Vector3 huevoForce = (currentPosition - center.position) * force * -1;
        huevo.velocity = huevoForce;

        huevo = null;
        huevoCollider = null;
        Invoke("CreateHuevo", 2);
    }

    void ResetStrips()
    {
        currentPosition = idlePosition.position;
        SetStrips(currentPosition);
    }

    void SetStrips(Vector3 position)
    {
        lineRenderers[0].SetPosition(1, position);
        lineRenderers[1].SetPosition(1, position);
        if (huevo)
        { 
        Vector3 dir = position - center.position;
        huevo.transform.position = position + dir.normalized * huevoPositionOffset;
        huevo.transform.right = -dir.normalized;
        }
    }

    Vector3 ClampBounday(Vector3 vector)
    {
        vector.y = Mathf.Clamp(vector.y, bottomBounday, 1000);
        return vector;
    }
}
