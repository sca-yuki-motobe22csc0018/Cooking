using UnityEngine;
using DG.Tweening;

public class pathTest : MonoBehaviour
{
    public PathType pathtype;
    public LoopType looptype;
    public int loopCount;
    public bool option = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.DOPath(
            new[]
            {
                new Vector3(4, 0, 0),
                new Vector3(4, 0, 4),
                new Vector3(0, 0, 4),
            },
            5f, pathtype)
            .SetOptions(option)
            .SetLoops(loopCount, looptype);
    }

}
