using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkHandler : NetworkManager
{

	public static List<string> players = new List<string>();
	public bool automaticStartup;
	public enum CONNECTION_TYPE {HOST, CLIENT };
	public CONNECTION_TYPE connectionType;

	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
	{
		GameObject player = (GameObject)Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
		//player.SetActive(true);
		NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
		print("Spawned a new player.. ... ..");
	}

	public List<GameObject> playerObjects = new List<GameObject>();

	public void updatePerspective(GameObject currPlayer)
	{
		foreach (GameObject player in playerObjects)
		{
			Camera cam = player.GetComponentInChildren<Camera>();
			cam.enabled = false;
		}
	}

	public void Start()
	{
		if (automaticStartup)
		{
			if (connectionType == CONNECTION_TYPE.HOST) {
				singleton.StartHost();
			} else if(connectionType == CONNECTION_TYPE.CLIENT) {
				singleton.StartClient();
			} 
		}
	}

}