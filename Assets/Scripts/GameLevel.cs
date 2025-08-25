using UnityEngine;

public class GameLevel : MonoBehaviour
{

    [SerializeField] private int levelNumber;
    [SerializeField] private Transform landerStartPositionTransfrom;
    [SerializeField] private Transform cameraStartTargetTransfrom;
    [SerializeField] private float zoomedOutOrthographicSize;


    public int GetLevelNumber()
    {
        return levelNumber;
    }

    public Vector3 GetLanderStartPosition()
    {
        return landerStartPositionTransfrom.position;
    }

    public Transform GetCameraStartTargetTransform()
    {
        return cameraStartTargetTransfrom;
    }

    public float GetZoomedOutOrthographicSize()
    {
        return zoomedOutOrthographicSize;
    }
}