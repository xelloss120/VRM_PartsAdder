using System.IO;
using UnityEngine;
using TriLibCore.SFB;
using VRM;
using UniGLTF;
using VRMShaders;

public class Export : MonoBehaviour
{
    public GameObject Model;

    /// <summary>
    /// VRMファイル書き出し
    /// </summary>
    public void OnClick()
    {
        var path = StandaloneFileBrowser.SaveFilePanel("Save File", "", "", "vrm");

        if (path.Name == "") return;

        var normalized = VRMBoneNormalizer.Execute(Model, false);
        var vrm = VRMExporter.Export(new GltfExportSettings(), normalized, new RuntimeTextureSerializer());
        var bytes = vrm.ToGlbBytes();
        File.WriteAllBytes(path.Name, bytes);

        Destroy(normalized);
    }
}
