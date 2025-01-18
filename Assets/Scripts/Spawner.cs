using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabToSpawn; // スポーンするプレハブ
    [SerializeField]
    private Vector3 spawnPoint; // スポーンする位置

    // Start is called before the first frame update
    void Start()
    {
        // spawnPointV3を直接使ってプレハブをインスタンス化
        Instantiate(prefabToSpawn, spawnPoint, Quaternion.identity); // 回転はデフォルト
        Debug.Log("spawned");
    }
}

