using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceManipulation : MonoBehaviour
{
    public float minimumDistance = 1f; // Dist�ncia m�nima para permitir a manipula��o (em metros)
    private ObjectManipulator objectManipulator;
    private Camera mainCamera;

    private void Start()
    {
        // Obt�m ou adiciona o componente ObjectManipulator
        objectManipulator = GetComponent<ObjectManipulator>();
        if (objectManipulator == null)
        {
            objectManipulator = gameObject.AddComponent<ObjectManipulator>();
        }

        // Obter a refer�ncia para a c�mera principal
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // Verifica a dist�ncia entre o objeto e a c�mera principal
        float distanceToCamera = Vector3.Distance(mainCamera.transform.position, transform.position);

        // Se a dist�ncia for menor que a dist�ncia m�nima, desabilita a manipula��o
        if (distanceToCamera < minimumDistance)
        {
            objectManipulator.enabled = false;
        }
        else
        {
            objectManipulator.enabled = true;
        }
    }
}