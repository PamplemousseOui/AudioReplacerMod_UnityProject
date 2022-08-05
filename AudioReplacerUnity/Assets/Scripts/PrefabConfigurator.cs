using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum GameMaterial
{
    Course,
    DeepSnow,
    BigPipes,
    Concrete,
    JibbingBox,
    Rails,
    Rock,
    SmallRail,
    SoftFence,
    FastWind
}

[System.Serializable]
public enum AssetType
{
    Forward,
    Turn,
    LandingHard,
    LandingSoft
}

[System.Serializable]
public struct Asset
{
    public GameMaterial material;
    public AssetType assetType;
    public float volume;
    public float pitchBase;
    public float pitchVar;
    public AudioClip[] audioClips;
}

public class PrefabConfigurator : MonoBehaviour
{
    public Asset[] assets;
}
