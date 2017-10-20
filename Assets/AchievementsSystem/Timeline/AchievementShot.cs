using Cinemachine;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// This class will be auto-added to timeline's context menu and "add" button.
public class AchievementShot : PlayableAsset, IPropertyPreview
{
    // This class - timeline clip itself.
    public class AchievementShotPlayable : PlayableBehaviour
    {
        public string whatever;

        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            Debug.Log("Hello i am play!");
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            Debug.Log("Hello i am stop :((((!");
        }
    }

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<AchievementShotPlayable>.Create(graph);
        return playable;
    }

    public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
    {
        // pass all changable properties to preview timeline. 
    }
}