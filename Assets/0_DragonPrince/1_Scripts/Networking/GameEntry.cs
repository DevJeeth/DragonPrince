﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEntry : MonoBehaviour
{
	private void Awake()
	{
		WarpNetworkManager.Instance.Initialize();
	}
}
