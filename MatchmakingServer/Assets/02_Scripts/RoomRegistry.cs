using System.Collections.Generic;
using UnityEngine;

public static class RoomRegistry
{
    private static Dictionary<string, string> rooms = new Dictionary<string, string>(); // 방을 저장할 컨테이너

    public static bool RegisterRoom(string roomName, string ip)
    {
        if (rooms.ContainsKey(roomName)) // 이미 방 이름이 존재한다면
            return false; // 추가 불가 반환

        rooms.Add(roomName, ip);
        return true;
    }

    public static string FindRoom(string roomName)
    {
        if (rooms.TryGetValue(roomName, out string ip)) // 만약 방 이름을 가지는 키가 있어 ip를 가져올 수 있다면
            return ip; // ip 반환

        return null; // 아닐 경우 null을 반환
    }

    public static bool RemoveRoom(string roomName)
    {
        return rooms.Remove(roomName); // 삭제하면 true를 못하면 false를 반환
    }

    public static void ClearAllRoom()
    {
        rooms.Clear(); // 방 전체를 삭제
    }
}
