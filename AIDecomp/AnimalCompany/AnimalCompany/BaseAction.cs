// Decompiled with Xera AI Decompiler
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace AnimalCompany
{
    public abstract class BaseAction
    {
        [CompilerGenerated]
        private bool <silent>k__BackingField;

        public virtual bool silent
        {
            [CompilerGenerated]
            get { return <silent>k__BackingField; }
            [CompilerGenerated]
            set { <silent>k__BackingField = value; }
        }

        protected BaseAction()
        {
        }

        public abstract void Execute(AppState state);

        public virtual BaseAction SetSilent(bool silent = true)
        {
            this.silent = silent;
            return this;
        }

        public override string ToString()
        {
            if (this.GetType() == null)
                return null;

            string typeName = GetTypeNameStripped(this.GetType());
            
            var fields = this.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                .Where(f => !IsSecuritySensitiveField(f))
                .Select(p => <ToString>b__6_0(p))
                .ToArray();

            if (fields != null && fields.Length > 0)
            {
                string fieldsString = string.Join(", ", fields);
                return $"{typeName}({fieldsString})";
            }

            return typeName;
        }

        [CompilerGenerated]
        private string <ToString>b__6_0(FieldInfo p)
        {
            if (p == null)
                return null;

            string fieldName = p.Name.TrimStart('_');
            
            if (IsSecuritySensitiveField(p))
            {
                return $"{fieldName}=***";
            }

            object value = p.GetValue(this);
            
            if (value == null)
            {
                return $"{fieldName}=null";
            }

            if (p.FieldType.IsArray)
            {
                Array array = value as Array;
                if (array != null)
                {
                    string[] elements = new string[array.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        object element = array.GetValue(i);
                        elements[i] = element?.ToString() ?? "null";
                    }
                    string arrayString = string.Join(", ", elements);
                    return $"{fieldName}=[{arrayString}]";
                }
            }

            return $"{fieldName}={value}";
        }

        public static string GetTypeNameStripped(Type type)
        {
            if (type == null)
                return null;

            string fullName = type.Name;
            if (fullName != null && fullName.StartsWith("AnimalCompany."))
            {
                return fullName.Substring("AnimalCompany.".Length);
            }

            return fullName;
        }

        public static bool IsSecuritySensitiveField(MemberInfo member)
        {
            if (member == null)
                return false;

            string memberName = member.Name;
            if (memberName == null)
                return false;

            return memberName.IndexOf("password", StringComparison.OrdinalIgnoreCase) >= 0 ||
                   memberName.IndexOf("secret", StringComparison.OrdinalIgnoreCase) >= 0 ||
                   memberName.IndexOf("token", StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}