namespace System.Net.Http.Headers;

public class CacheControlHeaderValue : ICloneable
{
	private List<NameValueHeaderValue> extensions; //Field offset: 0x10
	private List<String> no_cache_headers; //Field offset: 0x18
	private List<String> private_headers; //Field offset: 0x20
	[CompilerGenerated]
	private Nullable<TimeSpan> <MaxAge>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <MaxStale>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Nullable<TimeSpan> <MaxStaleLimit>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Nullable<TimeSpan> <MinFresh>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <MustRevalidate>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private bool <NoCache>k__BackingField; //Field offset: 0x61
	[CompilerGenerated]
	private bool <NoStore>k__BackingField; //Field offset: 0x62
	[CompilerGenerated]
	private bool <NoTransform>k__BackingField; //Field offset: 0x63
	[CompilerGenerated]
	private bool <OnlyIfCached>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private bool <Private>k__BackingField; //Field offset: 0x65
	[CompilerGenerated]
	private bool <ProxyRevalidate>k__BackingField; //Field offset: 0x66
	[CompilerGenerated]
	private bool <Public>k__BackingField; //Field offset: 0x67
	[CompilerGenerated]
	private Nullable<TimeSpan> <SharedMaxAge>k__BackingField; //Field offset: 0x68

	public ICollection<NameValueHeaderValue> Extensions
	{
		 get { } //Length: 120
	}

	public Nullable<TimeSpan> MaxAge
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool MaxStale
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Nullable<TimeSpan> MaxStaleLimit
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<TimeSpan> MinFresh
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool MustRevalidate
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool NoCache
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public ICollection<String> NoCacheHeaders
	{
		 get { } //Length: 120
	}

	public bool NoStore
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool NoTransform
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool OnlyIfCached
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool Private
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public ICollection<String> PrivateHeaders
	{
		 get { } //Length: 120
	}

	public bool ProxyRevalidate
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool Public
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Nullable<TimeSpan> SharedMaxAge
	{
		[CompilerGenerated]
		 get { } //Length: 12
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public CacheControlHeaderValue() { }

	public virtual bool Equals(object obj) { }

	public ICollection<NameValueHeaderValue> get_Extensions() { }

	[CompilerGenerated]
	public Nullable<TimeSpan> get_MaxAge() { }

	[CompilerGenerated]
	public bool get_MaxStale() { }

	[CompilerGenerated]
	public Nullable<TimeSpan> get_MaxStaleLimit() { }

	[CompilerGenerated]
	public Nullable<TimeSpan> get_MinFresh() { }

	[CompilerGenerated]
	public bool get_MustRevalidate() { }

	[CompilerGenerated]
	public bool get_NoCache() { }

	public ICollection<String> get_NoCacheHeaders() { }

	[CompilerGenerated]
	public bool get_NoStore() { }

	[CompilerGenerated]
	public bool get_NoTransform() { }

	[CompilerGenerated]
	public bool get_OnlyIfCached() { }

	[CompilerGenerated]
	public bool get_Private() { }

	public ICollection<String> get_PrivateHeaders() { }

	[CompilerGenerated]
	public bool get_ProxyRevalidate() { }

	[CompilerGenerated]
	public bool get_Public() { }

	[CompilerGenerated]
	public Nullable<TimeSpan> get_SharedMaxAge() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	public void set_MaxAge(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	public void set_MaxStale(bool value) { }

	[CompilerGenerated]
	public void set_MaxStaleLimit(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	public void set_MinFresh(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	public void set_MustRevalidate(bool value) { }

	[CompilerGenerated]
	public void set_NoCache(bool value) { }

	[CompilerGenerated]
	public void set_NoStore(bool value) { }

	[CompilerGenerated]
	public void set_NoTransform(bool value) { }

	[CompilerGenerated]
	public void set_OnlyIfCached(bool value) { }

	[CompilerGenerated]
	public void set_Private(bool value) { }

	[CompilerGenerated]
	public void set_ProxyRevalidate(bool value) { }

	[CompilerGenerated]
	public void set_Public(bool value) { }

	[CompilerGenerated]
	public void set_SharedMaxAge(Nullable<TimeSpan> value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public static bool TryParse(string input, out CacheControlHeaderValue parsedValue) { }

}

