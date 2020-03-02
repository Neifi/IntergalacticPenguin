using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class Boundary
{
    public float minX, maxX, minY, maxY;
}

public class PlayerManager : MonoBehaviour
{
    

    [SerializeField] private Boundary boundary;
  

    public void SetBoundary(Rigidbody2D playerRigidBody)
    {
        playerRigidBody.position = new Vector3
                    (
                        Mathf.Clamp(playerRigidBody.position.x, boundary.minX, boundary.maxX),
                        Mathf.Clamp(playerRigidBody.position.y, boundary.minY, boundary.maxY),
                        0.0f
                    );
    }
   

}