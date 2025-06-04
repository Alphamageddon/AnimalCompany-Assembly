namespace Fusion;

[Flags]
public enum RpcSendMessageResult
{
	None = 0,
	SentToServerForForwarding = 257,
	SentToTargetClient = 258,
	SentBroadcast = 1283,
	NotSentTargetObjectNotConfirmed = 2564,
	NotSentTargetObjectNotInPlayerInterest = 2565,
	NotSentTargetClientNotAvailable = 518,
	NotSentBroadcastNoActiveConnections = 1543,
	NotSentBroadcastNoConfirmedNorInterestedClients = 3592,
	MaskSent = 256,
	MaskNotSent = 512,
	MaskBroadcast = 1024,
	MaskCulled = 2048,
}

