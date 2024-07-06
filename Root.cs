using System.Xml.Serialization;

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false, ElementName = "root")]
public partial class Root {
    
    private RootItem[] itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public RootItem[] Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}


[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class RootItem {
    
    private string stringField;
    
    private string normalizedstringField;
    
    private string tokenField;
    
    private string languageField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName = "string")]
    public string @String {
        get {
            return this.stringField;
        }
        set {
            this.stringField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("normalized-string", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="normalizedString", ElementName = "normalized-string")]
    public string Normalizedstring {
        get {
            return this.normalizedstringField;
        }
        set {
            this.normalizedstringField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token", ElementName = "token")]
    public string Token {
        get {
            return this.tokenField;
        }
        set {
            this.tokenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="language", ElementName = "language")]
    public string Language {
        get {
            return this.languageField;
        }
        set {
            this.languageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="Name", ElementName = "name")]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}
