using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーの管理
/// </summary>
public class PlayerController : MonoBehaviour
{
	[SerializeField] private Transform _transform;
	private PlayerMoveController _moveController;
	private PlayerShooter _shooter;

	/// <summary>
	/// 起動時
	/// </summary>
	private void Awake()
	{
		if (_transform != null)
		{
			_transform = transform;
		}
	}

	/// <summary>
	/// 更新処理
	/// </summary>
	private void Update()
	{

	}
}
