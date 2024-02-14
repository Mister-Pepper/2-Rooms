using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
{

    public GameObject exit;

    public float speed = .01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene("Second");

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, this.exit.transform.position, speed);
    }
}
