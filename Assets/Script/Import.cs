using UnityEngine;
using TriLibCore.SFB;
using VRM;
using UniGLTF;

public class Import : MonoBehaviour
{
    [SerializeField] AddParts AddParts;
    [SerializeField] Export Export;

    /// <summary>
    /// VRMファイル読み込み
    /// </summary>
    public void OnClick()
    {
        var paths = StandaloneFileBrowser.OpenFilePanel("Open File", "", "", false);

        if (paths.Count == 0) return;

        using (GltfData data = new AutoGltfFileParser(paths[0].Name).Parse())
        {
            var vrm = new VRMData(data);
            IMaterialDescriptorGenerator materialGen = default;
            using (var loader = new VRMImporterContext(vrm, materialGenerator: materialGen))
            {
                var instance = loader.Load();
                instance.ShowMeshes();

                // 書き出し時に重力設定で変形する対策
                var sb = instance.Root.GetComponentsInChildren<VRMSpringBone>();
                for (int i = 0; i < sb.Length; i++)
                {
                    sb[i].enabled = false;
                }

                if (Export.Model != null)
                {
                    Destroy(Export.Model);
                }
                Export.Model = instance.Root;

                AddParts.Model = instance.Root;
            }
        }
    }
}
