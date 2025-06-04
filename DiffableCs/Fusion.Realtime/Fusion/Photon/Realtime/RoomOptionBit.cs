namespace Fusion.Photon.Realtime;

internal enum RoomOptionBit
{
	CheckUserOnJoin = 1,
	DeleteCacheOnLeave = 2,
	SuppressRoomEvents = 4,
	PublishUserId = 8,
	DeleteNullProps = 16,
	BroadcastPropsChangeToAll = 32,
	SuppressPlayerInfo = 64,
}

