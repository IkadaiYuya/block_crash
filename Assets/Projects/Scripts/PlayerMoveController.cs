using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �v���C���[�̈ړ�����
/// </summary>
public class PlayerMoveController
{
	// members --------------------------------------
	Transform _playerTransform;

	// methods --------------------------------------

	/// <summary>
	/// ������
	/// </summary>
	/// <param name="trans">�v���C���[��Transform</param>
	public void Initialize(Transform trans)
	{
		_playerTransform = trans;
	}

	/// <summary>
	/// �ړ�����
	/// </summary>
	/// <param name="inputVec"></param>
	public void Move(Vector3 inputVec)
	{
		if (_playerTransform == null)
			return;


	}
}
