//**********************************************************
//ISceneChanger.cs
//Author harada
//**********************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//**********************************************************
//ISceneChangerInterFace
//シーンチェンジ関数
//**********************************************************
public interface ISceneChanger
{
  void ChangeScene(string sceneName);//シーン切り替え関数
  void BackScene();//バック用関数

  bool IsDone { get; }//シーンチェンジ完了かどうかのフラグ
}
