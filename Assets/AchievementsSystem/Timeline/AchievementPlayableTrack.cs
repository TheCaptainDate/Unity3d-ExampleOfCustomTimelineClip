using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
[TrackClipType(typeof(AchievementShot))]
[TrackMediaType(TimelineAsset.MediaType.Script)]
//[TrackBindingType(typeof(CinemachineBrain))]
[TrackColor(0.53f, 0.0f, 0.08f)]
public class AchivementTrack : TrackAsset
{
    protected override Playable CreatePlayable(PlayableGraph graph, GameObject go, TimelineClip clip)
    {
        // This way u could hanldle creation of new playable and set custom name (which shown at timeline).
        Debug.Log(clip.asset);
        clip.displayName = "hello?";
        return base.CreatePlayable(graph, go, clip);
    }
}
