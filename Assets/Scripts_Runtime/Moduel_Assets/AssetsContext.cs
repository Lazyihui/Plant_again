using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AssetsContext {
    public Dictionary<string, GameObject> entity;

    public AsyncOperationHandle entitiyHandle;

    public Dictionary<string, GameObject> ui;

    public AsyncOperationHandle uiHandle;


    public AssetsContext() {
        entity = new Dictionary<string, GameObject>();
        ui = new Dictionary<string, GameObject>();
    }

    public bool Panel_TryGetPrefab(string name, out GameObject prefab) {
        return ui.TryGetValue(name, out prefab);
    }

    public bool Entity_TryGetPrefab(string name, out GameObject prefab) {
        return entity.TryGetValue(name, out prefab);
    }

}