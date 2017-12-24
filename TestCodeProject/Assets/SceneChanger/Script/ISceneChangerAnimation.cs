//**********************************************************
//ISceneChangerAnimation.cs
//Author harada
//**********************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//**********************************************************
//ISceneChangerAnimationInterFace
//シーンチェンジアニメーション（フェード等）
//**********************************************************
public interface ISceneChangerAnimation
{
  void PlayInAnimation();
  void PlayOutAnimation();
  bool IsDone { get; }
}
