using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spawnmanager : MonoBehaviour
{
    public static spawnmanager Instance;
    public GameObject[] enemyprefab;
    int a = 0;
    public AudioClip clip;
    public AudioSource audio;
    public TMP_Text currentscore;
    public int score = 0;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        currentscore.text = score.ToString();
        StartCoroutine(SpawnEnemy());
    }
    void Update()
    {
    }
    IEnumerator SpawnEnemy()
    {
        if (a < 4)
        {
            yield return new WaitForSeconds(0.6f);
            GameObject go = Instantiate(enemyprefab[Random.Range(0, enemyprefab.Length)], transform.position, Quaternion.identity, transform.parent);
            go.SetActive(true);
            a++;
            StartCoroutine(SpawnEnemy());
        }
    }
    public void playAudio()
    {
        audio.PlayOneShot(clip);
    }
    public void Add()
    {
        score += 25;
        currentscore.text = score.ToString();
    }
}
