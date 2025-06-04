namespace AnimalCompany;

[RequireComponent(typeof(Collider))]
public class AnalyticTrigger : MonoBehaviour
{
        private static Dictionary<String, Int32> globalEventCount; //Field offset: 0x0
	private const string PREFIX = "Trigger: "; //Field offset: 0x0
	[Header("Events are prefixed with `Trigger: `")]
	public string eventName; //Field offset: 0x20
	[Tooltip("If true the event will be sent every time the trigger is entered, otherwise it will only be sent once per eventName.")]
	public bool repeatable; //Field offset: 0x28
	[Header("Debug")]
	[Space]
	public bool setObjectNameToEventName; //Field offset: 0x29

        private static AnalyticTrigger()
        {
                globalEventCount = new Dictionary<string, int>();
        }

        public AnalyticTrigger() { }

        private void OnTriggerEnter(Collider other)
        {
                if (string.IsNullOrEmpty(eventName))
                        return;

                string name = PREFIX + eventName;
                if (!repeatable && globalEventCount.TryGetValue(name, out var count) && count > 0)
                        return;

                globalEventCount[name] = count + 1;
                Analytics.Track(name);
        }

        private void Start()
        {
                if (setObjectNameToEventName && !string.IsNullOrEmpty(eventName))
                        gameObject.name = eventName;
        }

}

