// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class TypeInfo : IParsable {
        /// <summary>The Assembly property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.SmartService.ServiceProvider.ClientSdk.Models.Assembly? Assembly { get; set; }
#nullable restore
#else
        public Qwips.SmartService.ServiceProvider.ClientSdk.Models.Assembly Assembly { get; set; }
#endif
        /// <summary>The AssemblyQualifiedName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssemblyQualifiedName { get; private set; }
#nullable restore
#else
        public string AssemblyQualifiedName { get; private set; }
#endif
        /// <summary>The Attributes property</summary>
        public int? Attributes { get; set; }
        /// <summary>The BaseType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TypeObject? BaseType { get; set; }
#nullable restore
#else
        public TypeObject BaseType { get; set; }
#endif
        /// <summary>The ContainsGenericParameters property</summary>
        public bool? ContainsGenericParameters { get; private set; }
        /// <summary>The CustomAttributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomAttributeData>? CustomAttributes { get; private set; }
#nullable restore
#else
        public List<CustomAttributeData> CustomAttributes { get; private set; }
#endif
        /// <summary>The DeclaredConstructors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConstructorInfo>? DeclaredConstructors { get; private set; }
#nullable restore
#else
        public List<ConstructorInfo> DeclaredConstructors { get; private set; }
#endif
        /// <summary>The DeclaredEvents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EventInfo>? DeclaredEvents { get; private set; }
#nullable restore
#else
        public List<EventInfo> DeclaredEvents { get; private set; }
#endif
        /// <summary>The DeclaredFields property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FieldInfo>? DeclaredFields { get; private set; }
#nullable restore
#else
        public List<FieldInfo> DeclaredFields { get; private set; }
#endif
        /// <summary>The DeclaredMembers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MemberInfo>? DeclaredMembers { get; private set; }
#nullable restore
#else
        public List<MemberInfo> DeclaredMembers { get; private set; }
#endif
        /// <summary>The DeclaredMethods property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MethodInfo>? DeclaredMethods { get; private set; }
#nullable restore
#else
        public List<MethodInfo> DeclaredMethods { get; private set; }
#endif
        /// <summary>The DeclaredNestedTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TypeInfo>? DeclaredNestedTypes { get; private set; }
#nullable restore
#else
        public List<TypeInfo> DeclaredNestedTypes { get; private set; }
#endif
        /// <summary>The DeclaredProperties property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PropertyInfo>? DeclaredProperties { get; private set; }
#nullable restore
#else
        public List<PropertyInfo> DeclaredProperties { get; private set; }
#endif
        /// <summary>The DeclaringMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MethodBase? DeclaringMethod { get; set; }
#nullable restore
#else
        public MethodBase DeclaringMethod { get; set; }
#endif
        /// <summary>The DeclaringType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TypeObject? DeclaringType { get; set; }
#nullable restore
#else
        public TypeObject DeclaringType { get; set; }
#endif
        /// <summary>The FullName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FullName { get; private set; }
#nullable restore
#else
        public string FullName { get; private set; }
#endif
        /// <summary>The GenericParameterAttributes property</summary>
        public int? GenericParameterAttributes { get; set; }
        /// <summary>The GenericParameterPosition property</summary>
        public int? GenericParameterPosition { get; private set; }
        /// <summary>The GenericTypeArguments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TypeObject>? GenericTypeArguments { get; private set; }
#nullable restore
#else
        public List<TypeObject> GenericTypeArguments { get; private set; }
#endif
        /// <summary>The GenericTypeParameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TypeObject>? GenericTypeParameters { get; private set; }
#nullable restore
#else
        public List<TypeObject> GenericTypeParameters { get; private set; }
#endif
        /// <summary>The GUID property</summary>
        public Guid? GUID { get; private set; }
        /// <summary>The HasElementType property</summary>
        public bool? HasElementType { get; private set; }
        /// <summary>The ImplementedInterfaces property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TypeObject>? ImplementedInterfaces { get; private set; }
#nullable restore
#else
        public List<TypeObject> ImplementedInterfaces { get; private set; }
#endif
        /// <summary>The IsAbstract property</summary>
        public bool? IsAbstract { get; private set; }
        /// <summary>The IsAnsiClass property</summary>
        public bool? IsAnsiClass { get; private set; }
        /// <summary>The IsArray property</summary>
        public bool? IsArray { get; private set; }
        /// <summary>The IsAutoClass property</summary>
        public bool? IsAutoClass { get; private set; }
        /// <summary>The IsAutoLayout property</summary>
        public bool? IsAutoLayout { get; private set; }
        /// <summary>The IsByRef property</summary>
        public bool? IsByRef { get; private set; }
        /// <summary>The IsClass property</summary>
        public bool? IsClass { get; private set; }
        /// <summary>The IsCOMObject property</summary>
        public bool? IsCOMObject { get; private set; }
        /// <summary>The IsConstructedGenericType property</summary>
        public bool? IsConstructedGenericType { get; private set; }
        /// <summary>The IsContextful property</summary>
        public bool? IsContextful { get; private set; }
        /// <summary>The IsEnum property</summary>
        public bool? IsEnum { get; private set; }
        /// <summary>The IsExplicitLayout property</summary>
        public bool? IsExplicitLayout { get; private set; }
        /// <summary>The IsGenericParameter property</summary>
        public bool? IsGenericParameter { get; private set; }
        /// <summary>The IsGenericType property</summary>
        public bool? IsGenericType { get; private set; }
        /// <summary>The IsGenericTypeDefinition property</summary>
        public bool? IsGenericTypeDefinition { get; private set; }
        /// <summary>The IsImport property</summary>
        public bool? IsImport { get; private set; }
        /// <summary>The IsInterface property</summary>
        public bool? IsInterface { get; private set; }
        /// <summary>The IsLayoutSequential property</summary>
        public bool? IsLayoutSequential { get; private set; }
        /// <summary>The IsMarshalByRef property</summary>
        public bool? IsMarshalByRef { get; private set; }
        /// <summary>The IsNested property</summary>
        public bool? IsNested { get; private set; }
        /// <summary>The IsNestedAssembly property</summary>
        public bool? IsNestedAssembly { get; private set; }
        /// <summary>The IsNestedFamANDAssem property</summary>
        public bool? IsNestedFamANDAssem { get; private set; }
        /// <summary>The IsNestedFamily property</summary>
        public bool? IsNestedFamily { get; private set; }
        /// <summary>The IsNestedFamORAssem property</summary>
        public bool? IsNestedFamORAssem { get; private set; }
        /// <summary>The IsNestedPrivate property</summary>
        public bool? IsNestedPrivate { get; private set; }
        /// <summary>The IsNestedPublic property</summary>
        public bool? IsNestedPublic { get; private set; }
        /// <summary>The IsNotPublic property</summary>
        public bool? IsNotPublic { get; private set; }
        /// <summary>The IsPointer property</summary>
        public bool? IsPointer { get; private set; }
        /// <summary>The IsPrimitive property</summary>
        public bool? IsPrimitive { get; private set; }
        /// <summary>The IsPublic property</summary>
        public bool? IsPublic { get; private set; }
        /// <summary>The IsSealed property</summary>
        public bool? IsSealed { get; private set; }
        /// <summary>The IsSecurityCritical property</summary>
        public bool? IsSecurityCritical { get; private set; }
        /// <summary>The IsSecuritySafeCritical property</summary>
        public bool? IsSecuritySafeCritical { get; private set; }
        /// <summary>The IsSecurityTransparent property</summary>
        public bool? IsSecurityTransparent { get; private set; }
        /// <summary>The IsSerializable property</summary>
        public bool? IsSerializable { get; private set; }
        /// <summary>The IsSpecialName property</summary>
        public bool? IsSpecialName { get; private set; }
        /// <summary>The IsUnicodeClass property</summary>
        public bool? IsUnicodeClass { get; private set; }
        /// <summary>The IsValueType property</summary>
        public bool? IsValueType { get; private set; }
        /// <summary>The IsVisible property</summary>
        public bool? IsVisible { get; private set; }
        /// <summary>The MemberType property</summary>
        public int? MemberType { get; set; }
        /// <summary>The MetadataToken property</summary>
        public int? MetadataToken { get; private set; }
        /// <summary>The Module property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.SmartService.ServiceProvider.ClientSdk.Models.Module? Module { get; set; }
#nullable restore
#else
        public Qwips.SmartService.ServiceProvider.ClientSdk.Models.Module Module { get; set; }
#endif
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; private set; }
#nullable restore
#else
        public string Name { get; private set; }
#endif
        /// <summary>The Namespace property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Namespace { get; private set; }
#nullable restore
#else
        public string Namespace { get; private set; }
#endif
        /// <summary>The ReflectedType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TypeObject? ReflectedType { get; set; }
#nullable restore
#else
        public TypeObject ReflectedType { get; set; }
#endif
        /// <summary>The StructLayoutAttribute property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.SmartService.ServiceProvider.ClientSdk.Models.StructLayoutAttribute? StructLayoutAttribute { get; set; }
#nullable restore
#else
        public Qwips.SmartService.ServiceProvider.ClientSdk.Models.StructLayoutAttribute StructLayoutAttribute { get; set; }
#endif
        /// <summary>The TypeHandle property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RuntimeTypeHandleObject? TypeHandle { get; set; }
#nullable restore
#else
        public RuntimeTypeHandleObject TypeHandle { get; set; }
#endif
        /// <summary>The TypeInitializer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConstructorInfo? TypeInitializer { get; set; }
#nullable restore
#else
        public ConstructorInfo TypeInitializer { get; set; }
#endif
        /// <summary>The UnderlyingSystemType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TypeObject? UnderlyingSystemType { get; set; }
#nullable restore
#else
        public TypeObject UnderlyingSystemType { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TypeInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TypeInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Assembly", n => { Assembly = n.GetObjectValue<Qwips.SmartService.ServiceProvider.ClientSdk.Models.Assembly>(Qwips.SmartService.ServiceProvider.ClientSdk.Models.Assembly.CreateFromDiscriminatorValue); } },
                {"AssemblyQualifiedName", n => { AssemblyQualifiedName = n.GetStringValue(); } },
                {"Attributes", n => { Attributes = n.GetIntValue(); } },
                {"BaseType", n => { BaseType = n.GetObjectValue<TypeObject>(TypeObject.CreateFromDiscriminatorValue); } },
                {"ContainsGenericParameters", n => { ContainsGenericParameters = n.GetBoolValue(); } },
                {"CustomAttributes", n => { CustomAttributes = n.GetCollectionOfObjectValues<CustomAttributeData>(CustomAttributeData.CreateFromDiscriminatorValue)?.ToList(); } },
                {"DeclaredConstructors", n => { DeclaredConstructors = n.GetCollectionOfObjectValues<ConstructorInfo>(ConstructorInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"DeclaredEvents", n => { DeclaredEvents = n.GetCollectionOfObjectValues<EventInfo>(EventInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"DeclaredFields", n => { DeclaredFields = n.GetCollectionOfObjectValues<FieldInfo>(FieldInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"DeclaredMembers", n => { DeclaredMembers = n.GetCollectionOfObjectValues<MemberInfo>(MemberInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"DeclaredMethods", n => { DeclaredMethods = n.GetCollectionOfObjectValues<MethodInfo>(MethodInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"DeclaredNestedTypes", n => { DeclaredNestedTypes = n.GetCollectionOfObjectValues<TypeInfo>(TypeInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"DeclaredProperties", n => { DeclaredProperties = n.GetCollectionOfObjectValues<PropertyInfo>(PropertyInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"DeclaringMethod", n => { DeclaringMethod = n.GetObjectValue<MethodBase>(MethodBase.CreateFromDiscriminatorValue); } },
                {"DeclaringType", n => { DeclaringType = n.GetObjectValue<TypeObject>(TypeObject.CreateFromDiscriminatorValue); } },
                {"FullName", n => { FullName = n.GetStringValue(); } },
                {"GenericParameterAttributes", n => { GenericParameterAttributes = n.GetIntValue(); } },
                {"GenericParameterPosition", n => { GenericParameterPosition = n.GetIntValue(); } },
                {"GenericTypeArguments", n => { GenericTypeArguments = n.GetCollectionOfObjectValues<TypeObject>(TypeObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"GenericTypeParameters", n => { GenericTypeParameters = n.GetCollectionOfObjectValues<TypeObject>(TypeObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"GUID", n => { GUID = n.GetGuidValue(); } },
                {"HasElementType", n => { HasElementType = n.GetBoolValue(); } },
                {"ImplementedInterfaces", n => { ImplementedInterfaces = n.GetCollectionOfObjectValues<TypeObject>(TypeObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"IsAbstract", n => { IsAbstract = n.GetBoolValue(); } },
                {"IsAnsiClass", n => { IsAnsiClass = n.GetBoolValue(); } },
                {"IsArray", n => { IsArray = n.GetBoolValue(); } },
                {"IsAutoClass", n => { IsAutoClass = n.GetBoolValue(); } },
                {"IsAutoLayout", n => { IsAutoLayout = n.GetBoolValue(); } },
                {"IsByRef", n => { IsByRef = n.GetBoolValue(); } },
                {"IsClass", n => { IsClass = n.GetBoolValue(); } },
                {"IsCOMObject", n => { IsCOMObject = n.GetBoolValue(); } },
                {"IsConstructedGenericType", n => { IsConstructedGenericType = n.GetBoolValue(); } },
                {"IsContextful", n => { IsContextful = n.GetBoolValue(); } },
                {"IsEnum", n => { IsEnum = n.GetBoolValue(); } },
                {"IsExplicitLayout", n => { IsExplicitLayout = n.GetBoolValue(); } },
                {"IsGenericParameter", n => { IsGenericParameter = n.GetBoolValue(); } },
                {"IsGenericType", n => { IsGenericType = n.GetBoolValue(); } },
                {"IsGenericTypeDefinition", n => { IsGenericTypeDefinition = n.GetBoolValue(); } },
                {"IsImport", n => { IsImport = n.GetBoolValue(); } },
                {"IsInterface", n => { IsInterface = n.GetBoolValue(); } },
                {"IsLayoutSequential", n => { IsLayoutSequential = n.GetBoolValue(); } },
                {"IsMarshalByRef", n => { IsMarshalByRef = n.GetBoolValue(); } },
                {"IsNested", n => { IsNested = n.GetBoolValue(); } },
                {"IsNestedAssembly", n => { IsNestedAssembly = n.GetBoolValue(); } },
                {"IsNestedFamANDAssem", n => { IsNestedFamANDAssem = n.GetBoolValue(); } },
                {"IsNestedFamily", n => { IsNestedFamily = n.GetBoolValue(); } },
                {"IsNestedFamORAssem", n => { IsNestedFamORAssem = n.GetBoolValue(); } },
                {"IsNestedPrivate", n => { IsNestedPrivate = n.GetBoolValue(); } },
                {"IsNestedPublic", n => { IsNestedPublic = n.GetBoolValue(); } },
                {"IsNotPublic", n => { IsNotPublic = n.GetBoolValue(); } },
                {"IsPointer", n => { IsPointer = n.GetBoolValue(); } },
                {"IsPrimitive", n => { IsPrimitive = n.GetBoolValue(); } },
                {"IsPublic", n => { IsPublic = n.GetBoolValue(); } },
                {"IsSealed", n => { IsSealed = n.GetBoolValue(); } },
                {"IsSecurityCritical", n => { IsSecurityCritical = n.GetBoolValue(); } },
                {"IsSecuritySafeCritical", n => { IsSecuritySafeCritical = n.GetBoolValue(); } },
                {"IsSecurityTransparent", n => { IsSecurityTransparent = n.GetBoolValue(); } },
                {"IsSerializable", n => { IsSerializable = n.GetBoolValue(); } },
                {"IsSpecialName", n => { IsSpecialName = n.GetBoolValue(); } },
                {"IsUnicodeClass", n => { IsUnicodeClass = n.GetBoolValue(); } },
                {"IsValueType", n => { IsValueType = n.GetBoolValue(); } },
                {"IsVisible", n => { IsVisible = n.GetBoolValue(); } },
                {"MemberType", n => { MemberType = n.GetIntValue(); } },
                {"MetadataToken", n => { MetadataToken = n.GetIntValue(); } },
                {"Module", n => { Module = n.GetObjectValue<Qwips.SmartService.ServiceProvider.ClientSdk.Models.Module>(Qwips.SmartService.ServiceProvider.ClientSdk.Models.Module.CreateFromDiscriminatorValue); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"Namespace", n => { Namespace = n.GetStringValue(); } },
                {"ReflectedType", n => { ReflectedType = n.GetObjectValue<TypeObject>(TypeObject.CreateFromDiscriminatorValue); } },
                {"StructLayoutAttribute", n => { StructLayoutAttribute = n.GetObjectValue<Qwips.SmartService.ServiceProvider.ClientSdk.Models.StructLayoutAttribute>(Qwips.SmartService.ServiceProvider.ClientSdk.Models.StructLayoutAttribute.CreateFromDiscriminatorValue); } },
                {"TypeHandle", n => { TypeHandle = n.GetObjectValue<RuntimeTypeHandleObject>(RuntimeTypeHandleObject.CreateFromDiscriminatorValue); } },
                {"TypeInitializer", n => { TypeInitializer = n.GetObjectValue<ConstructorInfo>(ConstructorInfo.CreateFromDiscriminatorValue); } },
                {"UnderlyingSystemType", n => { UnderlyingSystemType = n.GetObjectValue<TypeObject>(TypeObject.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Qwips.SmartService.ServiceProvider.ClientSdk.Models.Assembly>("Assembly", Assembly);
            writer.WriteIntValue("Attributes", Attributes);
            writer.WriteObjectValue<TypeObject>("BaseType", BaseType);
            writer.WriteObjectValue<MethodBase>("DeclaringMethod", DeclaringMethod);
            writer.WriteObjectValue<TypeObject>("DeclaringType", DeclaringType);
            writer.WriteIntValue("GenericParameterAttributes", GenericParameterAttributes);
            writer.WriteIntValue("MemberType", MemberType);
            writer.WriteObjectValue<Qwips.SmartService.ServiceProvider.ClientSdk.Models.Module>("Module", Module);
            writer.WriteObjectValue<TypeObject>("ReflectedType", ReflectedType);
            writer.WriteObjectValue<Qwips.SmartService.ServiceProvider.ClientSdk.Models.StructLayoutAttribute>("StructLayoutAttribute", StructLayoutAttribute);
            writer.WriteObjectValue<RuntimeTypeHandleObject>("TypeHandle", TypeHandle);
            writer.WriteObjectValue<ConstructorInfo>("TypeInitializer", TypeInitializer);
            writer.WriteObjectValue<TypeObject>("UnderlyingSystemType", UnderlyingSystemType);
        }
    }
}
