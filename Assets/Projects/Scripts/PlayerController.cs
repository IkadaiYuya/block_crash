using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �v���C���[�̊Ǘ�
/// </summary>
public class PlayerController : MonoBehaviour
{
	[SerializeField] private Transform _transform;
	private PlayerMoveController _moveController;
	private PlayerShooter _shooter;

	/// <summary>
	/// �N����
	/// </summary>
	private void Awake()
	{
		if (_transform != null)
		{
			_transform = transform;
		}
	}

	/// <summary>
	/// �X�V����
	/// </summary>
	private void Update()
	{

	}
}
