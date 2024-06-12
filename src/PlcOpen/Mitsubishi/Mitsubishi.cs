using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcOpen.Mitsubishi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201", IsNullable = false)]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mitsubishielectric.com/xml/variableLineNumber")]
    public partial class variableLineNumber
    {
        private int numberField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int number
        {
            get { return numberField; }
            set { numberField = value; }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201", IsNullable = false)]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mitsubishielectric.com/xml/variableExternalDeviceAccess")]
    public partial class variableExternalDeviceAccess
    {
        private bool isAccessField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isAccess
        {
            get { return isAccessField; }
            set { isAccessField = value; }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.plcopen.org/xml/tc6_0201", IsNullable = false)]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class variableStructDeviceAssignment
    {
        private memberData[] memberField;

        private arrayDefinitionData arrayDataField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public memberData[] member
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

        [System.Xml.Serialization.XmlElementAttribute()]
        public arrayDefinitionData array
        {
            get
            {
                return this.arrayDataField;
            }
            set
            {
                this.arrayDataField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class memberData
    {
        private string nameField;

        private string addressField;

        private structData structField;

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

        [System.Xml.Serialization.XmlElementAttribute("struct", IsNullable = false)]
        public structData structure
        {
            get
            {
                return this.structField;
            }
            set
            {
                this.structField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class arrayDefinitionData
    {
        private string wordAddressField;

        private string wordOffsetField;

        private bool isBitDesignationField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wordAddress
        {
            get
            {
                return this.wordAddressField;
            }
            set
            {
                this.wordAddressField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wordOffset
        {
            get
            {
                return this.wordOffsetField;
            }
            set
            {
                this.wordOffsetField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isBitDesignation
        {
            get
            {
                return this.isBitDesignationField;
            }
            set
            {
                this.isBitDesignationField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.plcopen.org/xml/tc6_0201")]
    public partial class structData
    {
        private memberData[] memberField;

        [System.Xml.Serialization.XmlElementAttribute()]
        public memberData[] member
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
}
