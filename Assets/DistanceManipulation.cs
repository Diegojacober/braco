using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceManipulation : MonoBehaviour
{
    public float minimumDistance = 1f; // Distância mínima para permitir a manipulação (em metros)
    private ObjectManipulator objectManipulator;
    private Camera mainCamera;

    private void Start()
    {
        // Obtém ou adiciona o componente ObjectManipulator
        objectManipulator = GetComponent<ObjectManipulator>();
        if (objectManipulator == null)
        {
            objectManipulator = gameObject.AddComponent<ObjectManipulator>();
        }

        // Obter a referência para a câmera principal
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // Verifica a distância entre o objeto e a câmera principal
        float distanceToCamera = Vector3.Distance(mainCamera.transform.position, transform.position);

        // Se a distância for menor que a distância mínima, desabilita a manipulação
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