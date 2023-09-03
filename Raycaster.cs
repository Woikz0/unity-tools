using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public static class Raycaster
{
    public static bool RaycastWithMousePos(out RaycastHit hitInfo, LayerMask mask)
    {
        Vector2 mousePos = InputManager.instance.GetMousePosition();
        Vector3 screenToWorldPoint = Camera.main.ScreenToWorldPoint(new(mousePos.x, mousePos.y));

        bool isOverUi = EventSystem.current.IsPointerOverGameObject();

        return Physics.Raycast(screenToWorldPoint, Camera.main.transform.forward, out hitInfo, 100f, mask) && !isOverUi;
    }
}
