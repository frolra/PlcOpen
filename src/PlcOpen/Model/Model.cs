﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcOpen.Model
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201", IsNullable = false)]
    public partial class project
    {

        private projectFileHeader fileHeaderField;

        private projectContentHeader contentHeaderField;

        private projectTypes typesField;

        private projectInstances instancesField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        /// <remarks/>
        public projectFileHeader fileHeader
        {
            get
            {
                return this.fileHeaderField;
            }
            set
            {
                this.fileHeaderField = value;
            }
        }

        /// <remarks/>
        public projectContentHeader contentHeader
        {
            get
            {
                return this.contentHeaderField;
            }
            set
            {
                this.contentHeaderField = value;
            }
        }

        /// <remarks/>
        public projectTypes types
        {
            get
            {
                return this.typesField;
            }
            set
            {
                this.typesField = value;
            }
        }

        /// <remarks/>
        public projectInstances instances
        {
            get
            {
                return this.instancesField;
            }
            set
            {
                this.instancesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectFileHeader
    {

        private string companyNameField;

        private string companyURLField;

        private string productNameField;

        private string productVersionField;

        private string productReleaseField;

        private System.DateTime creationDateTimeField;

        private string contentDescriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string companyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string companyURL
        {
            get
            {
                return this.companyURLField;
            }
            set
            {
                this.companyURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string productName
        {
            get
            {
                return this.productNameField;
            }
            set
            {
                this.productNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string productVersion
        {
            get
            {
                return this.productVersionField;
            }
            set
            {
                this.productVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string productRelease
        {
            get
            {
                return this.productReleaseField;
            }
            set
            {
                this.productReleaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime creationDateTime
        {
            get
            {
                return this.creationDateTimeField;
            }
            set
            {
                this.creationDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contentDescription
        {
            get
            {
                return this.contentDescriptionField;
            }
            set
            {
                this.contentDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class pouInstance
    {

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string nameField;

        private string typeNameField;

        private string globalIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string typeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class addDataData
    {

        private System.Xml.XmlElement anyField;

        private string nameField;

        private addDataDataHandleUnknown handleUnknownField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public addDataDataHandleUnknown handleUnknown
        {
            get
            {
                return this.handleUnknownField;
            }
            set
            {
                this.handleUnknownField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public enum addDataDataHandleUnknown
    {

        /// <remarks/>
        preserve,

        /// <remarks/>
        discard,

        /// <remarks/>
        implementation,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class varListConfig
    {

        private varListConfigConfigVariable[] configVariableField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("configVariable")]
        public varListConfigConfigVariable[] configVariable
        {
            get
            {
                return this.configVariableField;
            }
            set
            {
                this.configVariableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class varListConfigConfigVariable
    {

        private dataType typeField;

        private value initialValueField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string instancePathAndNameField;

        private string addressField;

        /// <remarks/>
        public dataType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public value initialValue
        {
            get
            {
                return this.initialValueField;
            }
            set
            {
                this.initialValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string instancePathAndName
        {
            get
            {
                return this.instancePathAndNameField;
            }
            set
            {
                this.instancePathAndNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class dataType
    {

        private object itemField;

        private ItemChoiceType1 itemElementNameField;

        private Dictionary<string, System.Type> typeField = new Dictionary<string, System.Type>()
        {
            {"BOOL", typeof(bool) },
            {"BYTE", typeof(byte) },
            {"DATE", typeof(System.DateTime) },
            {"DINT", typeof(int) },
            {"DT", typeof(System.DateTime) },
            {"DWORD", typeof(uint) },
            {"INT", typeof(System.Int16) },
            {"LINT", typeof(System.Int64) },
            {"LREAL", typeof(double) },
            {"LWORD", typeof(System.UInt64) },
            {"REAL", typeof(System.Single) },
            {"SINT", typeof(System.Int16) },
            {"TIME", typeof(System.DateTime) },
            {"TOD", typeof(System.DateTime) },
            {"UDINT", typeof(uint) },
            {"UINT", typeof(System.UInt16) },
            {"ULINT", typeof(System.UInt64) },
            {"USINT", typeof(byte) },
            {"WORD", typeof(System.UInt16) },
            {"string", typeof(string) },
            {"wstring", typeof(string) }
        };

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ANY", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ANY_BIT", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ANY_DATE", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ANY_DERIVED", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ANY_ELEMENTARY", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ANY_INT", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ANY_MAGNITUDE", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ANY_NUM", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ANY_REAL", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ANY_STRING", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("BOOL", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("BYTE", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("DATE", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("DINT", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("DT", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("DWORD", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("INT", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("LINT", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("LREAL", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("LWORD", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("REAL", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("SINT", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("TIME", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("TOD", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("UDINT", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("UINT", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ULINT", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("USINT", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("WORD", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("array", typeof(dataTypeArray))]
        [System.Xml.Serialization.XmlElementAttribute("derived", typeof(dataTypeDerived))]
        [System.Xml.Serialization.XmlElementAttribute("enum", typeof(dataTypeEnum))]
        [System.Xml.Serialization.XmlElementAttribute("pointer", typeof(dataTypePointer))]
        [System.Xml.Serialization.XmlElementAttribute("string", typeof(dataTypeString))]
        [System.Xml.Serialization.XmlElementAttribute("struct", typeof(varListPlain))]
        [System.Xml.Serialization.XmlElementAttribute("subrangeSigned", typeof(dataTypeSubrangeSigned))]
        [System.Xml.Serialization.XmlElementAttribute("subrangeUnsigned", typeof(dataTypeSubrangeUnsigned))]
        [System.Xml.Serialization.XmlElementAttribute("wstring", typeof(dataTypeWstring))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        public System.Type BaseItemType
        {
            get { return this.typeField.GetValueOrDefault(this.itemElementNameField.ToString()); }
        }

        public bool IsBaseItemType
        {
            get { return this.typeField.ContainsKey(this.itemElementNameField.ToString()); }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class dataTypeArray
    {

        private rangeSigned[] dimensionField;

        private dataType baseTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dimension")]
        public rangeSigned[] dimension
        {
            get
            {
                return this.dimensionField;
            }
            set
            {
                this.dimensionField = value;
            }
        }

        /// <remarks/>
        public dataType baseType
        {
            get
            {
                return this.baseTypeField;
            }
            set
            {
                this.baseTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class rangeSigned
    {

        private string lowerField;

        private string upperField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lower
        {
            get
            {
                return this.lowerField;
            }
            set
            {
                this.lowerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string upper
        {
            get
            {
                return this.upperField;
            }
            set
            {
                this.upperField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class dataTypeDerived
    {

        private addDataData[] addDataField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class dataTypeEnum
    {

        private dataTypeEnumValues valuesField;

        private dataType baseTypeField;

        /// <remarks/>
        public dataTypeEnumValues values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }

        /// <remarks/>
        public dataType baseType
        {
            get
            {
                return this.baseTypeField;
            }
            set
            {
                this.baseTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class dataTypeEnumValues
    {

        private dataTypeEnumValuesValue[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public dataTypeEnumValuesValue[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class dataTypeEnumValuesValue
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class dataTypePointer
    {

        private dataType baseTypeField;

        /// <remarks/>
        public dataType baseType
        {
            get
            {
                return this.baseTypeField;
            }
            set
            {
                this.baseTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class dataTypeString
    {

        private string lengthField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(varList))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class varListPlain
    {

        private varListPlainVariable[] variableField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("variable")]
        public varListPlainVariable[] variable
        {
            get
            {
                return this.variableField;
            }
            set
            {
                this.variableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class varListPlainVariable
    {

        private dataType typeField;

        private value initialValueField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string nameField;

        private string addressField;

        private string globalIdField;

        /// <remarks/>
        public dataType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public value initialValue
        {
            get
            {
                return this.initialValueField;
            }
            set
            {
                this.initialValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class value
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("arrayValue", typeof(valueArrayValue))]
        [System.Xml.Serialization.XmlElementAttribute("simpleValue", typeof(valueSimpleValue))]
        [System.Xml.Serialization.XmlElementAttribute("structValue", typeof(valueStructValue))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class valueArrayValue
    {

        private valueArrayValueValue[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public valueArrayValueValue[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class valueArrayValueValue : value
    {

        private string repetitionValueField;

        public valueArrayValueValue()
        {
            this.repetitionValueField = "1";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string repetitionValue
        {
            get
            {
                return this.repetitionValueField;
            }
            set
            {
                this.repetitionValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class valueSimpleValue
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class valueStructValue
    {

        private valueStructValueValue[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public valueStructValueValue[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class valueStructValueValue : value
    {

        private string memberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string member
        {
            get
            {
                return this.memberField;
            }
            set
            {
                this.memberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class varList : varListPlain
    {

        private string nameField;

        private bool constantField;

        private bool retainField;

        private bool nonretainField;

        private bool persistentField;

        private bool nonpersistentField;

        public varList()
        {
            this.constantField = false;
            this.retainField = false;
            this.nonretainField = false;
            this.persistentField = false;
            this.nonpersistentField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool constant
        {
            get
            {
                return this.constantField;
            }
            set
            {
                this.constantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool retain
        {
            get
            {
                return this.retainField;
            }
            set
            {
                this.retainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool nonretain
        {
            get
            {
                return this.nonretainField;
            }
            set
            {
                this.nonretainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool persistent
        {
            get
            {
                return this.persistentField;
            }
            set
            {
                this.persistentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool nonpersistent
        {
            get
            {
                return this.nonpersistentField;
            }
            set
            {
                this.nonpersistentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class dataTypeSubrangeSigned
    {

        private rangeSigned rangeField;

        private dataType baseTypeField;

        /// <remarks/>
        public rangeSigned range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }

        /// <remarks/>
        public dataType baseType
        {
            get
            {
                return this.baseTypeField;
            }
            set
            {
                this.baseTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class dataTypeSubrangeUnsigned
    {

        private rangeUnsigned rangeField;

        private dataType baseTypeField;

        /// <remarks/>
        public rangeUnsigned range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }

        /// <remarks/>
        public dataType baseType
        {
            get
            {
                return this.baseTypeField;
            }
            set
            {
                this.baseTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class rangeUnsigned
    {

        private string lowerField;

        private string upperField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lower
        {
            get
            {
                return this.lowerField;
            }
            set
            {
                this.lowerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string upper
        {
            get
            {
                return this.upperField;
            }
            set
            {
                this.upperField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class dataTypeWstring
    {

        private string lengthField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        ANY,

        /// <remarks/>
        ANY_BIT,

        /// <remarks/>
        ANY_DATE,

        /// <remarks/>
        ANY_DERIVED,

        /// <remarks/>
        ANY_ELEMENTARY,

        /// <remarks/>
        ANY_INT,

        /// <remarks/>
        ANY_MAGNITUDE,

        /// <remarks/>
        ANY_NUM,

        /// <remarks/>
        ANY_REAL,

        /// <remarks/>
        ANY_STRING,

        /// <remarks/>
        BOOL,

        /// <remarks/>
        BYTE,

        /// <remarks/>
        DATE,

        /// <remarks/>
        DINT,

        /// <remarks/>
        DT,

        /// <remarks/>
        DWORD,

        /// <remarks/>
        INT,

        /// <remarks/>
        LINT,

        /// <remarks/>
        LREAL,

        /// <remarks/>
        LWORD,

        /// <remarks/>
        REAL,

        /// <remarks/>
        SINT,

        /// <remarks/>
        TIME,

        /// <remarks/>
        TOD,

        /// <remarks/>
        UDINT,

        /// <remarks/>
        UINT,

        /// <remarks/>
        ULINT,

        /// <remarks/>
        USINT,

        /// <remarks/>
        WORD,

        /// <remarks/>
        array,

        /// <remarks/>
        derived,

        /// <remarks/>
        @enum,

        /// <remarks/>
        pointer,

        /// <remarks/>
        @string,

        /// <remarks/>
        @struct,

        /// <remarks/>
        subrangeSigned,

        /// <remarks/>
        subrangeUnsigned,

        /// <remarks/>
        wstring,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class varListAccess
    {

        private varListAccessAccessVariable[] accessVariableField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accessVariable")]
        public varListAccessAccessVariable[] accessVariable
        {
            get
            {
                return this.accessVariableField;
            }
            set
            {
                this.accessVariableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class varListAccessAccessVariable
    {

        private dataType typeField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string aliasField;

        private string instancePathAndNameField;

        private accessType directionField;

        private bool directionFieldSpecified;

        /// <remarks/>
        public dataType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string instancePathAndName
        {
            get
            {
                return this.instancePathAndNameField;
            }
            set
            {
                this.instancePathAndNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public accessType direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directionSpecified
        {
            get
            {
                return this.directionFieldSpecified;
            }
            set
            {
                this.directionFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public enum accessType
    {

        /// <remarks/>
        readOnly,

        /// <remarks/>
        readWrite,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class connectionPointOut
    {

        private position relPositionField;

        private string expressionField;

        private addDataData[] addDataField;

        private string globalIdField;

        /// <remarks/>
        public position relPosition
        {
            get
            {
                return this.relPositionField;
            }
            set
            {
                this.relPositionField = value;
            }
        }

        /// <remarks/>
        public string expression
        {
            get
            {
                return this.expressionField;
            }
            set
            {
                this.expressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class position
    {

        private decimal xField;

        private decimal yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class connection
    {

        private position[] positionField;

        private addDataData[] addDataField;

        private string globalIdField;

        private ulong refLocalIdField;

        private string formalParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("position")]
        public position[] position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong refLocalId
        {
            get
            {
                return this.refLocalIdField;
            }
            set
            {
                this.refLocalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formalParameter
        {
            get
            {
                return this.formalParameterField;
            }
            set
            {
                this.formalParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class connectionPointIn
    {

        private position relPositionField;

        private object[] itemsField;

        private addDataData[] addDataField;

        private string globalIdField;

        /// <remarks/>
        public position relPosition
        {
            get
            {
                return this.relPositionField;
            }
            set
            {
                this.relPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("connection", typeof(connection))]
        [System.Xml.Serialization.XmlElementAttribute("expression", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class body
    {

        private object itemField;

        private ItemChoiceType itemElementNameField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string worksheetNameField;

        private string globalIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FBD", typeof(bodyFBD))]
        [System.Xml.Serialization.XmlElementAttribute("IL", typeof(System.Xml.XmlElement))]
        [System.Xml.Serialization.XmlElementAttribute("LD", typeof(bodyLD))]
        [System.Xml.Serialization.XmlElementAttribute("SFC", typeof(bodySFC))]
        [System.Xml.Serialization.XmlElementAttribute("ST", typeof(System.Xml.XmlElement))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WorksheetName
        {
            get
            {
                return this.worksheetNameField;
            }
            set
            {
                this.worksheetNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBD
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actionBlock", typeof(bodyFBDActionBlock))]
        [System.Xml.Serialization.XmlElementAttribute("block", typeof(bodyFBDBlock))]
        [System.Xml.Serialization.XmlElementAttribute("comment", typeof(bodyFBDComment))]
        [System.Xml.Serialization.XmlElementAttribute("connector", typeof(bodyFBDConnector))]
        [System.Xml.Serialization.XmlElementAttribute("continuation", typeof(bodyFBDContinuation))]
        [System.Xml.Serialization.XmlElementAttribute("error", typeof(bodyFBDError))]
        [System.Xml.Serialization.XmlElementAttribute("inOutVariable", typeof(bodyFBDInOutVariable))]
        [System.Xml.Serialization.XmlElementAttribute("inVariable", typeof(bodyFBDInVariable))]
        [System.Xml.Serialization.XmlElementAttribute("jump", typeof(bodyFBDJump))]
        [System.Xml.Serialization.XmlElementAttribute("label", typeof(bodyFBDLabel))]
        [System.Xml.Serialization.XmlElementAttribute("outVariable", typeof(bodyFBDOutVariable))]
        [System.Xml.Serialization.XmlElementAttribute("return", typeof(bodyFBDReturn))]
        [System.Xml.Serialization.XmlElementAttribute("vendorElement", typeof(bodyFBDVendorElement))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDActionBlock
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private bodyFBDActionBlockAction[] actionField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private bool negatedField;

        private decimal widthField;

        private bool widthFieldSpecified;

        private decimal heightField;

        private bool heightFieldSpecified;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        public bodyFBDActionBlock()
        {
            this.negatedField = false;
        }

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("action")]
        public bodyFBDActionBlockAction[] action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDActionBlockAction
    {

        private position relPositionField;

        private bodyFBDActionBlockActionReference referenceField;

        private body inlineField;

        private connectionPointOut connectionPointOutField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private bodyFBDActionBlockActionQualifier qualifierField;

        private decimal widthField;

        private bool widthFieldSpecified;

        private decimal heightField;

        private bool heightFieldSpecified;

        private string durationField;

        private string indicatorField;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        public bodyFBDActionBlockAction()
        {
            this.qualifierField = bodyFBDActionBlockActionQualifier.N;
        }

        /// <remarks/>
        public position relPosition
        {
            get
            {
                return this.relPositionField;
            }
            set
            {
                this.relPositionField = value;
            }
        }

        /// <remarks/>
        public bodyFBDActionBlockActionReference reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        public body inline
        {
            get
            {
                return this.inlineField;
            }
            set
            {
                this.inlineField = value;
            }
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(bodyFBDActionBlockActionQualifier.N)]
        public bodyFBDActionBlockActionQualifier qualifier
        {
            get
            {
                return this.qualifierField;
            }
            set
            {
                this.qualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string indicator
        {
            get
            {
                return this.indicatorField;
            }
            set
            {
                this.indicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDActionBlockActionReference
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public enum bodyFBDActionBlockActionQualifier
    {

        /// <remarks/>
        P1,

        /// <remarks/>
        N,

        /// <remarks/>
        P0,

        /// <remarks/>
        R,

        /// <remarks/>
        S,

        /// <remarks/>
        L,

        /// <remarks/>
        D,

        /// <remarks/>
        P,

        /// <remarks/>
        DS,

        /// <remarks/>
        DL,

        /// <remarks/>
        SD,

        /// <remarks/>
        SL,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDBlock
    {

        private position positionField;

        private bodyFBDBlockVariable[] inputVariablesField;

        private bodyFBDBlockVariable1[] inOutVariablesField;

        private bodyFBDBlockVariable2[] outputVariablesField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal widthField;

        private bool widthFieldSpecified;

        private decimal heightField;

        private bool heightFieldSpecified;

        private string typeNameField;

        private string instanceNameField;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("variable", IsNullable = false)]
        public bodyFBDBlockVariable[] inputVariables
        {
            get
            {
                return this.inputVariablesField;
            }
            set
            {
                this.inputVariablesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("variable", IsNullable = false)]
        public bodyFBDBlockVariable1[] inOutVariables
        {
            get
            {
                return this.inOutVariablesField;
            }
            set
            {
                this.inOutVariablesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("variable", IsNullable = false)]
        public bodyFBDBlockVariable2[] outputVariables
        {
            get
            {
                return this.outputVariablesField;
            }
            set
            {
                this.outputVariablesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string typeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string instanceName
        {
            get
            {
                return this.instanceNameField;
            }
            set
            {
                this.instanceNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDBlockVariable
    {

        private connectionPointIn connectionPointInField;

        private System.Xml.XmlElement documentationField;

        private string formalParameterField;

        private bool negatedField;

        private edgeModifierType edgeField;

        private storageModifierType storageField;

        private bool hiddenField;

        public bodyFBDBlockVariable()
        {
            this.negatedField = false;
            this.edgeField = edgeModifierType.none;
            this.storageField = storageModifierType.none;
            this.hiddenField = false;
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formalParameter
        {
            get
            {
                return this.formalParameterField;
            }
            set
            {
                this.formalParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(edgeModifierType.none)]
        public edgeModifierType edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(storageModifierType.none)]
        public storageModifierType storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public enum edgeModifierType
    {

        /// <remarks/>
        none,

        /// <remarks/>
        falling,

        /// <remarks/>
        rising,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public enum storageModifierType
    {

        /// <remarks/>
        none,

        /// <remarks/>
        set,

        /// <remarks/>
        reset,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDBlockVariable1
    {

        private connectionPointIn connectionPointInField;

        private connectionPointOut connectionPointOutField;

        private System.Xml.XmlElement documentationField;

        private string formalParameterField;

        private bool negatedField;

        private edgeModifierType edgeField;

        private storageModifierType storageField;

        private bool hiddenField;

        public bodyFBDBlockVariable1()
        {
            this.negatedField = false;
            this.edgeField = edgeModifierType.none;
            this.storageField = storageModifierType.none;
            this.hiddenField = false;
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formalParameter
        {
            get
            {
                return this.formalParameterField;
            }
            set
            {
                this.formalParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(edgeModifierType.none)]
        public edgeModifierType edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(storageModifierType.none)]
        public storageModifierType storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDBlockVariable2
    {

        private connectionPointOut connectionPointOutField;

        private System.Xml.XmlElement documentationField;

        private string formalParameterField;

        private bool negatedField;

        private edgeModifierType edgeField;

        private storageModifierType storageField;

        private bool hiddenField;

        public bodyFBDBlockVariable2()
        {
            this.negatedField = false;
            this.edgeField = edgeModifierType.none;
            this.storageField = storageModifierType.none;
            this.hiddenField = false;
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formalParameter
        {
            get
            {
                return this.formalParameterField;
            }
            set
            {
                this.formalParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(edgeModifierType.none)]
        public edgeModifierType edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(storageModifierType.none)]
        public storageModifierType storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDComment
    {

        private position positionField;

        private System.Xml.XmlElement contentField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private decimal widthField;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDConnector
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string nameField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDContinuation
    {

        private position positionField;

        private connectionPointOut connectionPointOutField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string nameField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDError
    {

        private position positionField;

        private System.Xml.XmlElement contentField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private decimal widthField;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDInOutVariable
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private connectionPointOut connectionPointOutField;

        private string expressionField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private bool negatedInField;

        private edgeModifierType edgeInField;

        private storageModifierType storageInField;

        private bool negatedOutField;

        private edgeModifierType edgeOutField;

        private storageModifierType storageOutField;

        private string globalIdField;

        public bodyFBDInOutVariable()
        {
            this.negatedInField = false;
            this.edgeInField = edgeModifierType.none;
            this.storageInField = storageModifierType.none;
            this.negatedOutField = false;
            this.edgeOutField = edgeModifierType.none;
            this.storageOutField = storageModifierType.none;
        }

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        public string expression
        {
            get
            {
                return this.expressionField;
            }
            set
            {
                this.expressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negatedIn
        {
            get
            {
                return this.negatedInField;
            }
            set
            {
                this.negatedInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(edgeModifierType.none)]
        public edgeModifierType edgeIn
        {
            get
            {
                return this.edgeInField;
            }
            set
            {
                this.edgeInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(storageModifierType.none)]
        public storageModifierType storageIn
        {
            get
            {
                return this.storageInField;
            }
            set
            {
                this.storageInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negatedOut
        {
            get
            {
                return this.negatedOutField;
            }
            set
            {
                this.negatedOutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(edgeModifierType.none)]
        public edgeModifierType edgeOut
        {
            get
            {
                return this.edgeOutField;
            }
            set
            {
                this.edgeOutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(storageModifierType.none)]
        public storageModifierType storageOut
        {
            get
            {
                return this.storageOutField;
            }
            set
            {
                this.storageOutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDInVariable
    {

        private position positionField;

        private connectionPointOut connectionPointOutField;

        private string expressionField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private bool negatedField;

        private edgeModifierType edgeField;

        private storageModifierType storageField;

        private string globalIdField;

        public bodyFBDInVariable()
        {
            this.negatedField = false;
            this.edgeField = edgeModifierType.none;
            this.storageField = storageModifierType.none;
        }

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        public string expression
        {
            get
            {
                return this.expressionField;
            }
            set
            {
                this.expressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(edgeModifierType.none)]
        public edgeModifierType edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(storageModifierType.none)]
        public storageModifierType storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDJump
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string labelField;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDLabel
    {

        private position positionField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string labelField;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDOutVariable
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private string expressionField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private bool negatedField;

        private edgeModifierType edgeField;

        private storageModifierType storageField;

        private string globalIdField;

        public bodyFBDOutVariable()
        {
            this.negatedField = false;
            this.edgeField = edgeModifierType.none;
            this.storageField = storageModifierType.none;
        }

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public string expression
        {
            get
            {
                return this.expressionField;
            }
            set
            {
                this.expressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(edgeModifierType.none)]
        public edgeModifierType edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(storageModifierType.none)]
        public storageModifierType storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDReturn
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDVendorElement
    {

        private position positionField;

        private System.Xml.XmlElement alternativeTextField;

        private bodyFBDVendorElementVariable[] inputVariablesField;

        private bodyFBDVendorElementVariable1[] inOutVariablesField;

        private bodyFBDVendorElementVariable2[] outputVariablesField;

        private addDataData[] addDataField;

        private ulong localIdField;

        private decimal widthField;

        private bool widthFieldSpecified;

        private decimal heightField;

        private bool heightFieldSpecified;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement alternativeText
        {
            get
            {
                return this.alternativeTextField;
            }
            set
            {
                this.alternativeTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("variable", IsNullable = false)]
        public bodyFBDVendorElementVariable[] inputVariables
        {
            get
            {
                return this.inputVariablesField;
            }
            set
            {
                this.inputVariablesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("variable", IsNullable = false)]
        public bodyFBDVendorElementVariable1[] inOutVariables
        {
            get
            {
                return this.inOutVariablesField;
            }
            set
            {
                this.inOutVariablesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("variable", IsNullable = false)]
        public bodyFBDVendorElementVariable2[] outputVariables
        {
            get
            {
                return this.outputVariablesField;
            }
            set
            {
                this.outputVariablesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDVendorElementVariable
    {

        private connectionPointIn connectionPointInField;

        private System.Xml.XmlElement documentationField;

        private string formalParameterField;

        private bool negatedField;

        private edgeModifierType edgeField;

        private storageModifierType storageField;

        private bool hiddenField;

        public bodyFBDVendorElementVariable()
        {
            this.negatedField = false;
            this.edgeField = edgeModifierType.none;
            this.storageField = storageModifierType.none;
            this.hiddenField = false;
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formalParameter
        {
            get
            {
                return this.formalParameterField;
            }
            set
            {
                this.formalParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(edgeModifierType.none)]
        public edgeModifierType edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(storageModifierType.none)]
        public storageModifierType storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDVendorElementVariable1
    {

        private connectionPointIn connectionPointInField;

        private connectionPointOut connectionPointOutField;

        private System.Xml.XmlElement documentationField;

        private string formalParameterField;

        private bool negatedField;

        private edgeModifierType edgeField;

        private storageModifierType storageField;

        private bool hiddenField;

        public bodyFBDVendorElementVariable1()
        {
            this.negatedField = false;
            this.edgeField = edgeModifierType.none;
            this.storageField = storageModifierType.none;
            this.hiddenField = false;
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formalParameter
        {
            get
            {
                return this.formalParameterField;
            }
            set
            {
                this.formalParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(edgeModifierType.none)]
        public edgeModifierType edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(storageModifierType.none)]
        public storageModifierType storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyFBDVendorElementVariable2
    {

        private connectionPointOut connectionPointOutField;

        private System.Xml.XmlElement documentationField;

        private string formalParameterField;

        private bool negatedField;

        private edgeModifierType edgeField;

        private storageModifierType storageField;

        private bool hiddenField;

        public bodyFBDVendorElementVariable2()
        {
            this.negatedField = false;
            this.edgeField = edgeModifierType.none;
            this.storageField = storageModifierType.none;
            this.hiddenField = false;
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formalParameter
        {
            get
            {
                return this.formalParameterField;
            }
            set
            {
                this.formalParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(edgeModifierType.none)]
        public edgeModifierType edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(storageModifierType.none)]
        public storageModifierType storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool hidden
        {
            get
            {
                return this.hiddenField;
            }
            set
            {
                this.hiddenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyLD
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actionBlock", typeof(bodyFBDActionBlock))]
        [System.Xml.Serialization.XmlElementAttribute("block", typeof(bodyFBDBlock))]
        [System.Xml.Serialization.XmlElementAttribute("coil", typeof(bodyLDCoil))]
        [System.Xml.Serialization.XmlElementAttribute("comment", typeof(bodyFBDComment))]
        [System.Xml.Serialization.XmlElementAttribute("connector", typeof(bodyFBDConnector))]
        [System.Xml.Serialization.XmlElementAttribute("contact", typeof(bodyLDContact))]
        [System.Xml.Serialization.XmlElementAttribute("continuation", typeof(bodyFBDContinuation))]
        [System.Xml.Serialization.XmlElementAttribute("error", typeof(bodyFBDError))]
        [System.Xml.Serialization.XmlElementAttribute("inOutVariable", typeof(bodyFBDInOutVariable))]
        [System.Xml.Serialization.XmlElementAttribute("inVariable", typeof(bodyFBDInVariable))]
        [System.Xml.Serialization.XmlElementAttribute("jump", typeof(bodyFBDJump))]
        [System.Xml.Serialization.XmlElementAttribute("label", typeof(bodyFBDLabel))]
        [System.Xml.Serialization.XmlElementAttribute("leftPowerRail", typeof(bodyLDLeftPowerRail))]
        [System.Xml.Serialization.XmlElementAttribute("outVariable", typeof(bodyFBDOutVariable))]
        [System.Xml.Serialization.XmlElementAttribute("return", typeof(bodyFBDReturn))]
        [System.Xml.Serialization.XmlElementAttribute("rightPowerRail", typeof(bodyLDRightPowerRail))]
        [System.Xml.Serialization.XmlElementAttribute("vendorElement", typeof(bodyFBDVendorElement))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyLDCoil
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private connectionPointOut connectionPointOutField;

        private string variableField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private bool negatedField;

        private edgeModifierType edgeField;

        private storageModifierType storageField;

        private string globalIdField;

        public bodyLDCoil()
        {
            this.negatedField = false;
            this.edgeField = edgeModifierType.none;
            this.storageField = storageModifierType.none;
        }

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        public string variable
        {
            get
            {
                return this.variableField;
            }
            set
            {
                this.variableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(edgeModifierType.none)]
        public edgeModifierType edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(storageModifierType.none)]
        public storageModifierType storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyLDContact
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private connectionPointOut connectionPointOutField;

        private string variableField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private bool negatedField;

        private edgeModifierType edgeField;

        private storageModifierType storageField;

        private string globalIdField;

        public bodyLDContact()
        {
            this.negatedField = false;
            this.edgeField = edgeModifierType.none;
            this.storageField = storageModifierType.none;
        }

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        public string variable
        {
            get
            {
                return this.variableField;
            }
            set
            {
                this.variableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(edgeModifierType.none)]
        public edgeModifierType edge
        {
            get
            {
                return this.edgeField;
            }
            set
            {
                this.edgeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(storageModifierType.none)]
        public storageModifierType storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyLDLeftPowerRail
    {

        private position positionField;

        private bodyLDLeftPowerRailConnectionPointOut[] connectionPointOutField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("connectionPointOut")]
        public bodyLDLeftPowerRailConnectionPointOut[] connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyLDLeftPowerRailConnectionPointOut : connectionPointOut
    {

        private string formalParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formalParameter
        {
            get
            {
                return this.formalParameterField;
            }
            set
            {
                this.formalParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodyLDRightPowerRail
    {

        private position positionField;

        private connectionPointIn[] connectionPointInField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("connectionPointIn")]
        public connectionPointIn[] connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFC
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("actionBlock", typeof(bodyFBDActionBlock))]
        [System.Xml.Serialization.XmlElementAttribute("block", typeof(bodyFBDBlock))]
        [System.Xml.Serialization.XmlElementAttribute("coil", typeof(bodyLDCoil))]
        [System.Xml.Serialization.XmlElementAttribute("comment", typeof(bodyFBDComment))]
        [System.Xml.Serialization.XmlElementAttribute("connector", typeof(bodyFBDConnector))]
        [System.Xml.Serialization.XmlElementAttribute("contact", typeof(bodyLDContact))]
        [System.Xml.Serialization.XmlElementAttribute("continuation", typeof(bodyFBDContinuation))]
        [System.Xml.Serialization.XmlElementAttribute("error", typeof(bodyFBDError))]
        [System.Xml.Serialization.XmlElementAttribute("inOutVariable", typeof(bodyFBDInOutVariable))]
        [System.Xml.Serialization.XmlElementAttribute("inVariable", typeof(bodyFBDInVariable))]
        [System.Xml.Serialization.XmlElementAttribute("jump", typeof(bodyFBDJump))]
        [System.Xml.Serialization.XmlElementAttribute("jumpStep", typeof(bodySFCJumpStep))]
        [System.Xml.Serialization.XmlElementAttribute("label", typeof(bodyFBDLabel))]
        [System.Xml.Serialization.XmlElementAttribute("leftPowerRail", typeof(bodyLDLeftPowerRail))]
        [System.Xml.Serialization.XmlElementAttribute("macroStep", typeof(bodySFCMacroStep))]
        [System.Xml.Serialization.XmlElementAttribute("outVariable", typeof(bodyFBDOutVariable))]
        [System.Xml.Serialization.XmlElementAttribute("return", typeof(bodyFBDReturn))]
        [System.Xml.Serialization.XmlElementAttribute("rightPowerRail", typeof(bodyLDRightPowerRail))]
        [System.Xml.Serialization.XmlElementAttribute("selectionConvergence", typeof(bodySFCSelectionConvergence))]
        [System.Xml.Serialization.XmlElementAttribute("selectionDivergence", typeof(bodySFCSelectionDivergence))]
        [System.Xml.Serialization.XmlElementAttribute("simultaneousConvergence", typeof(bodySFCSimultaneousConvergence))]
        [System.Xml.Serialization.XmlElementAttribute("simultaneousDivergence", typeof(bodySFCSimultaneousDivergence))]
        [System.Xml.Serialization.XmlElementAttribute("step", typeof(bodySFCStep))]
        [System.Xml.Serialization.XmlElementAttribute("transition", typeof(bodySFCTransition))]
        [System.Xml.Serialization.XmlElementAttribute("vendorElement", typeof(bodyFBDVendorElement))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCJumpStep
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string targetNameField;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetName
        {
            get
            {
                return this.targetNameField;
            }
            set
            {
                this.targetNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCMacroStep
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private connectionPointOut connectionPointOutField;

        private body bodyField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string nameField;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        public body body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCSelectionConvergence
    {

        private position positionField;

        private bodySFCSelectionConvergenceConnectionPointIn[] connectionPointInField;

        private connectionPointOut connectionPointOutField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("connectionPointIn")]
        public bodySFCSelectionConvergenceConnectionPointIn[] connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCSelectionConvergenceConnectionPointIn : connectionPointIn
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCSelectionDivergence
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private bodySFCSelectionDivergenceConnectionPointOut[] connectionPointOutField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("connectionPointOut")]
        public bodySFCSelectionDivergenceConnectionPointOut[] connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCSelectionDivergenceConnectionPointOut : connectionPointOut
    {

        private string formalParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formalParameter
        {
            get
            {
                return this.formalParameterField;
            }
            set
            {
                this.formalParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCSimultaneousConvergence
    {

        private position positionField;

        private connectionPointIn[] connectionPointInField;

        private connectionPointOut connectionPointOutField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("connectionPointIn")]
        public connectionPointIn[] connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCSimultaneousDivergence
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private bodySFCSimultaneousDivergenceConnectionPointOut[] connectionPointOutField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string nameField;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("connectionPointOut")]
        public bodySFCSimultaneousDivergenceConnectionPointOut[] connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCSimultaneousDivergenceConnectionPointOut : connectionPointOut
    {

        private string formalParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formalParameter
        {
            get
            {
                return this.formalParameterField;
            }
            set
            {
                this.formalParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCStep
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private bodySFCStepConnectionPointOut connectionPointOutField;

        private bodySFCStepConnectionPointOutAction connectionPointOutActionField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string nameField;

        private bool initialStepField;

        private bool negatedField;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        public bodySFCStep()
        {
            this.initialStepField = false;
            this.negatedField = false;
        }

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public bodySFCStepConnectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        public bodySFCStepConnectionPointOutAction connectionPointOutAction
        {
            get
            {
                return this.connectionPointOutActionField;
            }
            set
            {
                this.connectionPointOutActionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool initialStep
        {
            get
            {
                return this.initialStepField;
            }
            set
            {
                this.initialStepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCStepConnectionPointOut : connectionPointOut
    {

        private string formalParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formalParameter
        {
            get
            {
                return this.formalParameterField;
            }
            set
            {
                this.formalParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCStepConnectionPointOutAction : connectionPointOut
    {

        private string formalParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string formalParameter
        {
            get
            {
                return this.formalParameterField;
            }
            set
            {
                this.formalParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCTransition
    {

        private position positionField;

        private connectionPointIn connectionPointInField;

        private connectionPointOut connectionPointOutField;

        private bodySFCTransitionCondition conditionField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private ulong localIdField;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private ulong priorityField;

        private bool priorityFieldSpecified;

        private ulong executionOrderIdField;

        private bool executionOrderIdFieldSpecified;

        private string globalIdField;

        /// <remarks/>
        public position position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        public connectionPointIn connectionPointIn
        {
            get
            {
                return this.connectionPointInField;
            }
            set
            {
                this.connectionPointInField = value;
            }
        }

        /// <remarks/>
        public connectionPointOut connectionPointOut
        {
            get
            {
                return this.connectionPointOutField;
            }
            set
            {
                this.connectionPointOutField = value;
            }
        }

        /// <remarks/>
        public bodySFCTransitionCondition condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong localId
        {
            get
            {
                return this.localIdField;
            }
            set
            {
                this.localIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool heightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prioritySpecified
        {
            get
            {
                return this.priorityFieldSpecified;
            }
            set
            {
                this.priorityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong executionOrderId
        {
            get
            {
                return this.executionOrderIdField;
            }
            set
            {
                this.executionOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool executionOrderIdSpecified
        {
            get
            {
                return this.executionOrderIdFieldSpecified;
            }
            set
            {
                this.executionOrderIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCTransitionCondition
    {

        private object itemField;

        private bool negatedField;

        public bodySFCTransitionCondition()
        {
            this.negatedField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("connectionPointIn", typeof(connectionPointIn))]
        [System.Xml.Serialization.XmlElementAttribute("inline", typeof(bodySFCTransitionConditionInline))]
        [System.Xml.Serialization.XmlElementAttribute("reference", typeof(bodySFCTransitionConditionReference))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool negated
        {
            get
            {
                return this.negatedField;
            }
            set
            {
                this.negatedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCTransitionConditionInline : body
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class bodySFCTransitionConditionReference
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        FBD,

        /// <remarks/>
        IL,

        /// <remarks/>
        LD,

        /// <remarks/>
        SFC,

        /// <remarks/>
        ST,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectContentHeader
    {

        private string commentField;

        private projectContentHeaderCoordinateInfo coordinateInfoField;

        private addDataInfoInfo[] addDataInfoField;

        private addDataData[] addDataField;

        private string nameField;

        private string versionField;

        private System.DateTime modificationDateTimeField;

        private bool modificationDateTimeFieldSpecified;

        private string organizationField;

        private string authorField;

        private string languageField;

        /// <remarks/>
        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        public projectContentHeaderCoordinateInfo coordinateInfo
        {
            get
            {
                return this.coordinateInfoField;
            }
            set
            {
                this.coordinateInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("info", IsNullable = false)]
        public addDataInfoInfo[] addDataInfo
        {
            get
            {
                return this.addDataInfoField;
            }
            set
            {
                this.addDataInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime modificationDateTime
        {
            get
            {
                return this.modificationDateTimeField;
            }
            set
            {
                this.modificationDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modificationDateTimeSpecified
        {
            get
            {
                return this.modificationDateTimeFieldSpecified;
            }
            set
            {
                this.modificationDateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "language")]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectContentHeaderCoordinateInfo
    {

        private projectContentHeaderCoordinateInfoPageSize pageSizeField;

        private projectContentHeaderCoordinateInfoFbd fbdField;

        private projectContentHeaderCoordinateInfoLD ldField;

        private projectContentHeaderCoordinateInfoSfc sfcField;

        /// <remarks/>
        public projectContentHeaderCoordinateInfoPageSize pageSize
        {
            get
            {
                return this.pageSizeField;
            }
            set
            {
                this.pageSizeField = value;
            }
        }

        /// <remarks/>
        public projectContentHeaderCoordinateInfoFbd fbd
        {
            get
            {
                return this.fbdField;
            }
            set
            {
                this.fbdField = value;
            }
        }

        /// <remarks/>
        public projectContentHeaderCoordinateInfoLD ld
        {
            get
            {
                return this.ldField;
            }
            set
            {
                this.ldField = value;
            }
        }

        /// <remarks/>
        public projectContentHeaderCoordinateInfoSfc sfc
        {
            get
            {
                return this.sfcField;
            }
            set
            {
                this.sfcField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectContentHeaderCoordinateInfoPageSize
    {

        private decimal xField;

        private decimal yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectContentHeaderCoordinateInfoFbd
    {

        private projectContentHeaderCoordinateInfoFbdScaling scalingField;

        /// <remarks/>
        public projectContentHeaderCoordinateInfoFbdScaling scaling
        {
            get
            {
                return this.scalingField;
            }
            set
            {
                this.scalingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectContentHeaderCoordinateInfoFbdScaling
    {

        private decimal xField;

        private decimal yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectContentHeaderCoordinateInfoLD
    {

        private projectContentHeaderCoordinateInfoLDScaling scalingField;

        /// <remarks/>
        public projectContentHeaderCoordinateInfoLDScaling scaling
        {
            get
            {
                return this.scalingField;
            }
            set
            {
                this.scalingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectContentHeaderCoordinateInfoLDScaling
    {

        private decimal xField;

        private decimal yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectContentHeaderCoordinateInfoSfc
    {

        private projectContentHeaderCoordinateInfoSfcScaling scalingField;

        /// <remarks/>
        public projectContentHeaderCoordinateInfoSfcScaling scaling
        {
            get
            {
                return this.scalingField;
            }
            set
            {
                this.scalingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectContentHeaderCoordinateInfoSfcScaling
    {

        private decimal xField;

        private decimal yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class addDataInfoInfo
    {

        private System.Xml.XmlElement descriptionField;

        private string nameField;

        private decimal versionField;

        private bool versionFieldSpecified;

        private string vendorField;

        /// <remarks/>
        public System.Xml.XmlElement description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool versionSpecified
        {
            get
            {
                return this.versionFieldSpecified;
            }
            set
            {
                this.versionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string vendor
        {
            get
            {
                return this.vendorField;
            }
            set
            {
                this.vendorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypes
    {

        private projectTypesDataType[] dataTypesField;

        private projectTypesPou[] pousField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("dataType", IsNullable = false)]
        public projectTypesDataType[] dataTypes
        {
            get
            {
                return this.dataTypesField;
            }
            set
            {
                this.dataTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("pou", IsNullable = false)]
        public projectTypesPou[] pous
        {
            get
            {
                return this.pousField;
            }
            set
            {
                this.pousField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypesDataType
    {

        private dataType baseTypeField;

        private value initialValueField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string nameField;

        /// <remarks/>
        public dataType baseType
        {
            get
            {
                return this.baseTypeField;
            }
            set
            {
                this.baseTypeField = value;
            }
        }

        /// <remarks/>
        public value initialValue
        {
            get
            {
                return this.initialValueField;
            }
            set
            {
                this.initialValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypesPou
    {

        private projectTypesPouInterface interfaceField;

        private projectTypesPouAction[] actionsField;

        private projectTypesPouTransition[] transitionsField;

        private body[] bodyField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string nameField;

        private pouType pouTypeField;

        private string globalIdField;

        /// <remarks/>
        public projectTypesPouInterface @interface
        {
            get
            {
                return this.interfaceField;
            }
            set
            {
                this.interfaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("action", IsNullable = false)]
        public projectTypesPouAction[] actions
        {
            get
            {
                return this.actionsField;
            }
            set
            {
                this.actionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("transition", IsNullable = false)]
        public projectTypesPouTransition[] transitions
        {
            get
            {
                return this.transitionsField;
            }
            set
            {
                this.transitionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("body")]
        public body[] body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public pouType pouType
        {
            get
            {
                return this.pouTypeField;
            }
            set
            {
                this.pouTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypesPouInterface
    {

        private dataType returnTypeField;

        private varList[] itemsField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        /// <remarks/>
        public dataType returnType
        {
            get
            {
                return this.returnTypeField;
            }
            set
            {
                this.returnTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("accessVars", typeof(varList))]
        [System.Xml.Serialization.XmlElementAttribute("externalVars", typeof(projectTypesPouInterfaceExternalVars))]
        [System.Xml.Serialization.XmlElementAttribute("globalVars", typeof(projectTypesPouInterfaceGlobalVars))]
        [System.Xml.Serialization.XmlElementAttribute("inOutVars", typeof(projectTypesPouInterfaceInOutVars))]
        [System.Xml.Serialization.XmlElementAttribute("inputVars", typeof(projectTypesPouInterfaceInputVars))]
        [System.Xml.Serialization.XmlElementAttribute("localVars", typeof(projectTypesPouInterfaceLocalVars))]
        [System.Xml.Serialization.XmlElementAttribute("outputVars", typeof(projectTypesPouInterfaceOutputVars))]
        [System.Xml.Serialization.XmlElementAttribute("tempVars", typeof(projectTypesPouInterfaceTempVars))]
        public varList[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypesPouInterfaceExternalVars : varList
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypesPouInterfaceGlobalVars : varList
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypesPouInterfaceInOutVars : varList
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypesPouInterfaceInputVars : varList
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypesPouInterfaceLocalVars : varList
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypesPouInterfaceOutputVars : varList
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypesPouInterfaceTempVars : varList
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypesPouAction
    {

        private body bodyField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string nameField;

        private string globalIdField;

        /// <remarks/>
        public body body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectTypesPouTransition
    {

        private body bodyField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string nameField;

        private string globalIdField;

        /// <remarks/>
        public body body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public enum pouType
    {

        /// <remarks/>
        function,

        /// <remarks/>
        functionBlock,

        /// <remarks/>
        program,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectInstances
    {

        private projectInstancesConfiguration[] configurationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("configuration", IsNullable = false)]
        public projectInstancesConfiguration[] configurations
        {
            get
            {
                return this.configurationsField;
            }
            set
            {
                this.configurationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectInstancesConfiguration
    {

        private projectInstancesConfigurationResource[] resourceField;

        private varList[] globalVarsField;

        private varListAccess accessVarsField;

        private varListConfig configVarsField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string nameField;

        private string globalIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("resource")]
        public projectInstancesConfigurationResource[] resource
        {
            get
            {
                return this.resourceField;
            }
            set
            {
                this.resourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("globalVars")]
        public varList[] globalVars
        {
            get
            {
                return this.globalVarsField;
            }
            set
            {
                this.globalVarsField = value;
            }
        }

        /// <remarks/>
        public varListAccess accessVars
        {
            get
            {
                return this.accessVarsField;
            }
            set
            {
                this.accessVarsField = value;
            }
        }

        /// <remarks/>
        public varListConfig configVars
        {
            get
            {
                return this.configVarsField;
            }
            set
            {
                this.configVarsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectInstancesConfigurationResource
    {

        private projectInstancesConfigurationResourceTask[] taskField;

        private varList[] globalVarsField;

        private pouInstance[] pouInstanceField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string nameField;

        private string globalIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("task")]
        public projectInstancesConfigurationResourceTask[] task
        {
            get
            {
                return this.taskField;
            }
            set
            {
                this.taskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("globalVars")]
        public varList[] globalVars
        {
            get
            {
                return this.globalVarsField;
            }
            set
            {
                this.globalVarsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pouInstance")]
        public pouInstance[] pouInstance
        {
            get
            {
                return this.pouInstanceField;
            }
            set
            {
                this.pouInstanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class projectInstancesConfigurationResourceTask
    {

        private pouInstance[] pouInstanceField;

        private addDataData[] addDataField;

        private System.Xml.XmlElement documentationField;

        private string nameField;

        private string singleField;

        private string intervalField;

        private string priorityField;

        private string globalIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pouInstance")]
        public pouInstance[] pouInstance
        {
            get
            {
                return this.pouInstanceField;
            }
            set
            {
                this.pouInstanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
        public addDataData[] addData
        {
            get
            {
                return this.addDataField;
            }
            set
            {
                this.addDataField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string single
        {
            get
            {
                return this.singleField;
            }
            set
            {
                this.singleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string interval
        {
            get
            {
                return this.intervalField;
            }
            set
            {
                this.intervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string globalId
        {
            get
            {
                return this.globalIdField;
            }
            set
            {
                this.globalIdField = value;
            }
        }
    }
}
