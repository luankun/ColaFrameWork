﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// GUI工具类
/// </summary>
public static class GUIHelper
{
    /// <summary>
    /// UI画布的根节点
    /// </summary>
    private static GameObject uiRootObj = null;

    /// <summary>
    /// 相机节点
    /// </summary>
    private static GameObject uiCameraObj = null;

    /// <summary>
    /// UI相机
    /// </summary>
    private static Camera uiCamera = null;

    /// <summary>
    /// UI画布
    /// </summary>
    private static Canvas uiRoot = null;

    /// <summary>
    /// 主相机
    /// </summary>
    private static Camera mainCamera;

    /// <summary>
    /// 主相机节点
    /// </summary>
    private static GameObject mainCameraObj;


    private static void UGUICreate()
    {
        if (null == uiRootObj)
        {
            //创建画布根节点，相机节点，3D物体根节点
            int uiLayer = LayerMask.NameToLayer("UI");
            GameObject rootObj = new GameObject("UGUIRoot");
            rootObj.layer = uiLayer;

            uiRootObj = new GameObject("Canvas");
            uiRootObj.transform.parent = rootObj.transform;
            uiRootObj.layer = uiLayer;

            uiCameraObj = new GameObject("UICamera");
            uiCameraObj.layer = uiLayer;
            uiCameraObj.transform.parent = uiRootObj.transform;
            uiCamera = uiCameraObj.AddComponent<Camera>();
            uiCamera.depth = 6;
            uiCamera.backgroundColor = Color.black;
            uiCamera.cullingMask = LayerMask.GetMask("UI");
            uiCamera.clearFlags = CameraClearFlags.Depth;

            //使用2D相机
            uiCamera.orthographicSize = 1.0f;
            uiCamera.orthographic = true;
            uiCamera.nearClipPlane = -1000f;
            uiCamera.farClipPlane = 1000f;
            uiCameraObj.AddComponent<CameraAdapter>();

            Canvas uguiRoot = uiRootObj.AddComponent<Canvas>();
            uguiRoot.renderMode = RenderMode.ScreenSpaceCamera;
            uguiRoot.worldCamera = uiCamera;

            CanvasScaler canvasScaler = uiRootObj.AddComponent<CanvasScaler>();
            canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
            canvasScaler.matchWidthOrHeight = 0;
            canvasScaler.referenceResolution = new Vector2(1280, 720);

            uiRootObj.AddComponent<GraphicRaycaster>();
            GameObject eventSystem = new GameObject("EventSystem");
            eventSystem.AddComponent<EventSystem>();
            eventSystem.AddComponent<StandaloneInputModule>();

            uiRoot = uguiRoot;

            GameObject bgCameraObj = new GameObject("BackgroundCamera");
            Camera bgCamera = bgCameraObj.AddComponent<Camera>();
            bgCamera.depth = 0;
            bgCamera.backgroundColor = Color.black;
            bgCamera.orthographicSize = 1f;
            bgCamera.orthographic = true;
            bgCamera.cullingMask = LayerMask.GetMask("Nothing");
            bgCamera.clearFlags = CameraClearFlags.SolidColor;
        }
    }

    public static void CreateMainCamera()
    {
        if (null == mainCameraObj)
        {
            //主相机的根节点
            GameObject mainCameraRootObj = new GameObject("Main Camera Root");

            GameObject cameraPushObj = new GameObject("Camera Push");
            cameraPushObj.transform.SetParent(mainCameraRootObj.transform, false);
            //cameraPushObj.AddComponent<CameraPush>();
            GameObject cameraShakeObj = new GameObject("Camera Shake");
            cameraShakeObj.transform.SetParent(cameraPushObj.transform, false);
            //cameraShakeObj.AddComponent<CameraShake>();

            //创建主相机并设置参数
            mainCameraObj = new GameObject("Main Camera");
            mainCamera = mainCameraObj.AddComponent<Camera>();
            mainCameraObj.tag = "MainCamera";
            mainCameraObj.AddComponent<Animation>();
            BoxCollider collider = mainCameraObj.AddComponent<BoxCollider>();
            Rigidbody rigidbody = mainCameraObj.AddComponent<Rigidbody>();

            collider.size = new Vector3(1, 1, 10);
            collider.center = new Vector3(0, 0, 5);
            collider.isTrigger = true;
            rigidbody.mass = 0;
            rigidbody.useGravity = false;

            mainCamera.backgroundColor = Color.black;
            mainCamera.nearClipPlane = 1;
            mainCamera.farClipPlane = 1000;
            mainCamera.cullingMask = LayerMask.GetMask("Default") + LayerMask.GetMask("Water") + LayerMask.GetMask("Terrain") +
                                     LayerMask.GetMask("Building") + LayerMask.GetMask("SmallBuilding") + LayerMask.GetMask("Sky") +
                                     LayerMask.GetMask("Grass") + LayerMask.GetMask("Ground");
            mainCamera.layerCullSpherical = true;
            mainCameraObj.AddComponent<AudioListener>();
            mainCameraObj.AddComponent<CameraTouchController>();
            mainCameraObj.transform.SetParent(mainCameraRootObj.transform,false);
        }
    }

    /// <summary>
    /// 返回UI画布的根节点
    /// </summary>
    /// <returns></returns>
    public static GameObject GetUIRootObj()
    {
        UGUICreate();
        return uiRootObj;
    }

    /// <summary>
    /// 返回UI相机节点
    /// </summary>
    /// <returns></returns>
    public static GameObject GetUICameraObj()
    {
        UGUICreate();
        return uiCameraObj;
    }

    /// <summary>
    /// 返回UI画布
    /// </summary>
    /// <returns></returns>
    public static Canvas GetUIRoot()
    {
        UGUICreate();
        return uiRoot;
    }

    /// <summary>
    /// 返回UI相机
    /// </summary>
    /// <returns></returns>
    public static Camera GetUICamera()
    {
        UGUICreate();
        return uiCamera;
    }

    /// <summary>
    /// 获取主相机
    /// </summary>
    /// <returns></returns>
    public static Camera GetMainCamera()
    {
        CreateMainCamera();
        return mainCamera;
    }

    /// <summary>
    /// 获取主相机节点
    /// </summary>
    /// <returns></returns>
    public static GameObject GetMainGameObj()
    {
        CreateMainCamera();
        return mainCameraObj;
    }
}
