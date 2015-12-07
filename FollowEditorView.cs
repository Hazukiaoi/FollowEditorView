using UnityEngine;
using System.Collections;
using UnityEditor;


[ExecuteInEditMode]
public class FollowEditorView : MonoBehaviour {

    public bool allowFollow = true;

    public void Start()
    {

    }
#if UNITY_EDITOR
    Camera cam;
    public void OnDrawGizmos()
    {
        if (allowFollow)
        {
            cam = GetComponent<Camera>();
            transform.localPosition = SceneView.currentDrawingSceneView.camera.transform.localPosition;
            transform.localRotation = SceneView.currentDrawingSceneView.camera.transform.localRotation;
            cam.orthographic = SceneView.currentDrawingSceneView.camera.orthographic;
            if (cam.orthographic)
            {
                cam.orthographicSize = SceneView.currentDrawingSceneView.camera.orthographicSize;
            }
            else
            {
                cam.fieldOfView = SceneView.currentDrawingSceneView.camera.fieldOfView;
            }
        }
    }
#endif
}
