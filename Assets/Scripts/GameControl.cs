using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
    [SerializeField]
    private GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Bear.locked && Seal.locked && Bunny.locked)
        {
           StartCoroutine(ChangeSecene());
        }
    }

    private IEnumerator ChangeSecene()
    {
        winText.SetActive(true);
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene("Level2");
    }
}
