using Mirror;
using UnityEngine;

public class MatchMakingNetworkManager : NetworkManager
{
    public override void OnStartServer()
    {
        base.OnStartServer();
        Debug.Log("[�߾� ����] ���۵�");

        NetworkServer.RegisterHandler<RegisterRoomMessage>(OnRegisterRoom);
        NetworkServer.RegisterHandler<SearchRoomMessage>(OnSearchRoom);
    }

    void OnRegisterRoom(NetworkConnectionToClient conn, RegisterRoomMessage msg)
    {
        RoomRegistry.RegisterRoom(msg.roomName, msg.ip);
    }

    void OnSearchRoom(NetworkConnectionToClient conn, SearchRoomMessage msg)
    {
        string ip = RoomRegistry.FindRoom(msg.roomName);
        conn.Send(new SearchRoomResponseMessage { ip = ip });
    }
}
