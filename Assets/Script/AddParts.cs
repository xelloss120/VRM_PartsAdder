﻿using System.Linq;
using UnityEngine;
using TriLibCore;

public class AddParts : MonoBehaviour
{
    [SerializeField] GameObject Cube;

    public GameObject Model;

    GameObject Parts;

    public void Import()
    {
        // Creates an AssetLoaderOptions instance.
        // AssetLoaderOptions is a class used to configure many aspects of the loading process.
        // We won't change the default settings this time, so we can use the instance as it is.
        var assetLoaderOptions = AssetLoader.CreateDefaultLoaderOptions();

        // Creates the AssetLoaderFilePicker instance.
        // AssetLoaderFilePicker is a class that allows users to select models from the local file system.
        var assetLoaderFilePicker = AssetLoaderFilePicker.Create();

        // Shows the model selection file-picker.
        assetLoaderFilePicker.LoadModelFromFilePickerAsync("Select a File", OnLoad, OnMaterialsLoad, OnProgress, OnBeginLoad, OnError, null, assetLoaderOptions);
    }

    // This event is called when the model is about to be loaded.
    // You can use this event to do some loading preparation, like showing a loading screen in platforms without threading support.
    // This event receives a Boolean indicating if any file has been selected on the file-picker dialog.
    private void OnBeginLoad(bool anyModelSelected)
    {

    }

    // This event is called when the model loading progress changes.
    // You can use this event to update a loading progress-bar, for instance.
    // The "progress" value comes as a normalized float (goes from 0 to 1).
    // Platforms like UWP and WebGL don't call this method at this moment, since they don't use threads.
    private void OnProgress(AssetLoaderContext assetLoaderContext, float progress)
    {

    }

    // This event is called when there is any critical error loading your model.
    // You can use this to show a message to the user.
    private void OnError(IContextualizedError contextualizedError)
    {

    }

    // This event is called when all model GameObjects and Meshes have been loaded.
    // There may still Materials and Textures processing at this stage.
    private void OnLoad(AssetLoaderContext assetLoaderContext)
    {
        // The root loaded GameObject is assigned to the "assetLoaderContext.RootGameObject" field.
        // If you want to make sure the GameObject will be visible only when all Materials and Textures have been loaded, you can disable it at this step.
        var myLoadedGameObject = assetLoaderContext.RootGameObject;
        myLoadedGameObject.SetActive(false);
    }

    // This event is called after OnLoad when all Materials and Textures have been loaded.
    // This event is also called after a critical loading error, so you can clean up any resource you want to.
    private void OnMaterialsLoad(AssetLoaderContext assetLoaderContext)
    {
        // The root loaded GameObject is assigned to the "assetLoaderContext.RootGameObject" field.
        // You can make the GameObject visible again at this step if you prefer to.
        var myLoadedGameObject = assetLoaderContext.RootGameObject;
        myLoadedGameObject.SetActive(true);

        Parts = myLoadedGameObject;

        // メッシュのマテリアルをMToon化
        var mesh1 = (Renderer[])myLoadedGameObject.GetComponentsInChildren<MeshRenderer>();
        var mesh2 = (Renderer[])myLoadedGameObject.GetComponentsInChildren<SkinnedMeshRenderer>();
        var meshs = mesh1.Concat(mesh2).ToArray();
        foreach (var m in meshs)
        {
            for (int i = 0; i < m.sharedMaterials.Length; i++)
            {
                var material = m.sharedMaterials[i];

                material.shader = Shader.Find("VRM/MToon");
                material.SetColor("_Color", new Color(1, 1, 1));
                material.SetColor("_ShadeColor", new Color(0.9f, 0.9f, 0.9f));

                // 参考
                // .\VRM_PartsAdderProt\Library\PackageCache\com.vrmc.vrmshaders@ac3083c270\VRM\MToon\MToon\Scripts\UtilsSetter.cs
                // https://csharp.hotexamples.com/jp/examples/UnityEngine/Material/SetOverrideTag/php-material-setoverridetag-method-examples.html
                material.SetOverrideTag("RenderType", "Transparent");
                material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                material.SetInt("_ZWrite", 0);
                material.SetInt("_AlphaToMask", 0);
                material.DisableKeyword("_ALPHATEST_ON");
                material.EnableKeyword("_ALPHABLEND_ON");
                material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
                material.renderQueue = 3000;
            }
        }

        // メッシュのルートボーンを操作できるように設定
        foreach (var m in myLoadedGameObject.GetComponentsInChildren<SkinnedMeshRenderer>())
        {
            var cube = Instantiate(Cube);
            cube.transform.localScale = m.bounds.size;
            cube.transform.position = m.bounds.center;

            var ft = cube.GetComponent<FollowTarget>();
            ft.Target = m.rootBone;
            ft.Offset = m.rootBone.position - m.bounds.center;
            ft.Size = m.bounds.size;
        }
    }

    public void Head()
    {
        var anim = Model.GetComponent<Animator>();
        Parts.transform.parent = anim.GetBoneTransform(HumanBodyBones.Head);
    }

    public void Arm()
    {
        var anim = Model.GetComponent<Animator>();
        Parts.transform.parent = anim.GetBoneTransform(HumanBodyBones.RightHand);
    }

    public void Root()
    {
        Parts.transform.parent = Model.transform;
    }
}