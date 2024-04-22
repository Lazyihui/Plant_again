using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public static class AssetsCore {

    public static void Load(AssetsContext ctx) {

        // {

        //     AssetLabelReference labelReference = new AssetLabelReference();
        //     labelReference.labelString = "Entity";
        //     var handle = Addressables.LoadAssetsAsync<GameObject>(labelReference, null);
        //     var list = handle.WaitForCompletion();
        //     foreach (var go in list) {
        //         ctx.entity.Add(go.name, go);
        //     }
        //     ctx.entitiyHandle = handle;
        // }
        
        {

            AssetLabelReference labelReference = new AssetLabelReference();
            labelReference.labelString = "UI";
            var handle = Addressables.LoadAssetsAsync<GameObject>(labelReference, null);
            var list = handle.WaitForCompletion();
            foreach (var go in list) {
                ctx.ui.Add(go.name, go);
            }
            ctx.uiHandle = handle;
        }
    }

    public static void ReleaseAll(AssetsContext ctx) {
        if (ctx.entitiyHandle.IsValid()) {
            Addressables.Release(ctx.entitiyHandle);
        }
        if (ctx.uiHandle.IsValid()) {
            Addressables.Release(ctx.uiHandle);
        }
    }

}