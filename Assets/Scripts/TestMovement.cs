using UnityEngine;
using UnityEngine.Networking;

public class TestMovement: NetworkBehaviour
{
    public void Update()
    {
        if (!isLocalPlayer)
            return;

        float x = Input.GetAxis("Horizontal") * 0.1f;
        float z = Input.GetAxis("Vertical") * 0.1f;

        transform.Translate(x, 0, z);
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
