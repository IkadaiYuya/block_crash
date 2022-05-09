using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーの移動処理
/// </summary>
public class PlayerMoveController
{
	// members --------------------------------------
	Transform _playerTransform;

	// methods --------------------------------------

	/// <summary>
	/// 初期化
	/// </summary>
	/// <param name="trans">プレイヤーのTransform</param>
	public void Initialize(Transform trans)
	{
		_playerTransform = trans;
	}

	/// <summary>
	/// 移動処理
	/// </summary>
	/// <param name="inputVec"></param>
	public void Move(Vector3 inputVec)
	{
		if (_playerTransform == null)
			return;


	}
}
