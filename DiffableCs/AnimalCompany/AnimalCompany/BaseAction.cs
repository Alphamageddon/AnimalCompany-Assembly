namespace AnimalCompany;

public abstract class BaseAction
{
        [CompilerGenerated]
        private bool <silent>k__BackingField; //Field offset: 0x10

        public override bool silent
        {
                [CompilerGenerated]
                get => <silent>k__BackingField;
                [CompilerGenerated]
                set => <silent>k__BackingField = value;
        }

        protected BaseAction() { }

        [CompilerGenerated]
        private string <ToString>b__6_0(FieldInfo p) => $"{p.Name}={p.GetValue(this)}";

        public abstract void Execute(AppState state);

        [CompilerGenerated]
        public override bool get_silent() => silent;

        public static string GetTypeNameStripped(Type type) => type.Name;

        public static bool IsSecuritySensitiveField(MemberInfo member) => false;

        [CompilerGenerated]
        public override void set_silent(bool value) => silent = value;

        public override BaseAction SetSilent(bool silent = true)
        {
                this.silent = silent;
                return this;
        }

        public virtual string ToString() => GetType().Name;

}

