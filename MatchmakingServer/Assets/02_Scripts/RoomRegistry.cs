using System.Collections.Generic;
using UnityEngine;

public static class RoomRegistry
{
    private static Dictionary<string, string> rooms = new Dictionary<string, string>(); // ���� ������ �����̳�

    public static bool RegisterRoom(string roomName, string ip)
    {
        if (rooms.ContainsKey(roomName)) // �̹� �� �̸��� �����Ѵٸ�
            return false; // �߰� �Ұ� ��ȯ

        rooms.Add(roomName, ip);
        return true;
    }

    public static string FindRoom(string roomName)
    {
        if (rooms.TryGetValue(roomName, out string ip)) // ���� �� �̸��� ������ Ű�� �־� ip�� ������ �� �ִٸ�
            return ip; // ip ��ȯ

        return null; // �ƴ� ��� null�� ��ȯ
    }

    public static bool RemoveRoom(string roomName)
    {
        return rooms.Remove(roomName); // �����ϸ� true�� ���ϸ� false�� ��ȯ
    }

    public static void ClearAllRoom()
    {
        rooms.Clear(); // �� ��ü�� ����
    }
}
