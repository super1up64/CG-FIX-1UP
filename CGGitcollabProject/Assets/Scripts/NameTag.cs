using System;

using Photon.Pun;

using TMPro;

using UnityEngine;

using Random = UnityEngine.Random;



// Token: 0x020000D0 RID: 208

public class NameTag : MonoBehaviour

{

	// Token: 0x060003BE RID: 958 RVA: 0x00018E70 File Offset: 0x00017070

	private void Start()

	{





		if (this.photonView.IsMine)

		{

			if (PlayerPrefs.HasKey("username"))

			{

				PhotonNetwork.NickName = PlayerPrefs.GetString("username");

			}

			else

			{

				PlayerPrefs.SetString("username", "Gibbon" + Random.Range(0, 10000).ToString());

				PhotonNetwork.NickName = PlayerPrefs.GetString("username");

			}

		}

		this.name();

	}



	// Token: 0x060003BF RID: 959 RVA: 0x00018EE3 File Offset: 0x000170E3

	private void name()

	{

		this.nameTag.text = this.photonView.Owner.NickName;

	}



	// Token: 0x060003C0 RID: 960 RVA: 0x00018F00 File Offset: 0x00017100

	private void Update()

	{

		if (this.nameTag.text != this.photonView.Owner.NickName)

		{

			this.name();

		}

	}



	// Token: 0x04000492 RID: 1170

	public PhotonView photonView;



	// Token: 0x04000493 RID: 1171

	public TextMeshPro nameTag;

}