// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
// This source code was auto-generated by Web Services Description Language Utility
//Mono Framework v4.0.30319.1
//


/// <remarks/>
[System.Web.Services.WebServiceBinding(Name="WebservicesSoap", Namespace="http://regexlib.com/webservices.asmx")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseDataObject))]
public partial class Webservices : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback getRegExpDetailsOperationCompleted;
    
    private System.Threading.SendOrPostCallback ListAllAsXmlOperationCompleted;
    
    private System.Threading.SendOrPostCallback listRegExpOperationCompleted;
    
    public Webservices() {
        this.Url = "http://regexlib.com/WebServices.asmx";
    }
    
    public event getRegExpDetailsCompletedEventHandler getRegExpDetailsCompleted;
    
    public event ListAllAsXmlCompletedEventHandler ListAllAsXmlCompleted;
    
    public event listRegExpCompletedEventHandler listRegExpCompleted;
    
    /// <remarks>
///Returns information about a particular regular expression as a RegExpDetails struct object.
///</remarks>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://regexlib.com/webservices.asmx/getRegExpDetails", RequestNamespace="http://regexlib.com/webservices.asmx", ResponseNamespace="http://regexlib.com/webservices.asmx", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public RegExpDetails getRegExpDetails(int regexpId) {
        object[] results = this.Invoke("getRegExpDetails", new object[] {
                    regexpId});
        return ((RegExpDetails)(results[0]));
    }
    
    public System.IAsyncResult BegingetRegExpDetails(int regexpId, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("getRegExpDetails", new object[] {
                    regexpId}, callback, asyncState);
    }
    
    public RegExpDetails EndgetRegExpDetails(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((RegExpDetails)(results[0]));
    }
    
    public void getRegExpDetailsAsync(int regexpId) {
        this.getRegExpDetailsAsync(regexpId, null);
    }
    
    public void getRegExpDetailsAsync(int regexpId, object userState) {
        if ((this.getRegExpDetailsOperationCompleted == null)) {
            this.getRegExpDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetRegExpDetailsCompleted);
        }
        this.InvokeAsync("getRegExpDetails", new object[] {
                    regexpId}, this.getRegExpDetailsOperationCompleted, userState);
    }
    
    private void OngetRegExpDetailsCompleted(object arg) {
        if ((this.getRegExpDetailsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getRegExpDetailsCompleted(this, new getRegExpDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks>
///Returns N expressions in order by date added to library, descending.
///</remarks>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://regexlib.com/webservices.asmx/ListAllAsXml", RequestNamespace="http://regexlib.com/webservices.asmx", ResponseNamespace="http://regexlib.com/webservices.asmx", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public Expression[] ListAllAsXml(int maxrows) {
        object[] results = this.Invoke("ListAllAsXml", new object[] {
                    maxrows});
        return ((Expression[])(results[0]));
    }
    
    public System.IAsyncResult BeginListAllAsXml(int maxrows, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("ListAllAsXml", new object[] {
                    maxrows}, callback, asyncState);
    }
    
    public Expression[] EndListAllAsXml(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Expression[])(results[0]));
    }
    
    public void ListAllAsXmlAsync(int maxrows) {
        this.ListAllAsXmlAsync(maxrows, null);
    }
    
    public void ListAllAsXmlAsync(int maxrows, object userState) {
        if ((this.ListAllAsXmlOperationCompleted == null)) {
            this.ListAllAsXmlOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListAllAsXmlCompleted);
        }
        this.InvokeAsync("ListAllAsXml", new object[] {
                    maxrows}, this.ListAllAsXmlOperationCompleted, userState);
    }
    
    private void OnListAllAsXmlCompleted(object arg) {
        if ((this.ListAllAsXmlCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.ListAllAsXmlCompleted(this, new ListAllAsXmlCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks>
///Returns a dataset holding information about all of the regular expressions that matched the query provided.
///</remarks>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://regexlib.com/webservices.asmx/listRegExp", RequestNamespace="http://regexlib.com/webservices.asmx", ResponseNamespace="http://regexlib.com/webservices.asmx", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public System.Data.DataSet listRegExp(string keyword, string regexp_substring, int min_rating, int howmanyrows) {
        object[] results = this.Invoke("listRegExp", new object[] {
                    keyword,
                    regexp_substring,
                    min_rating,
                    howmanyrows});
        return ((System.Data.DataSet)(results[0]));
    }
    
    public System.IAsyncResult BeginlistRegExp(string keyword, string regexp_substring, int min_rating, int howmanyrows, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("listRegExp", new object[] {
                    keyword,
                    regexp_substring,
                    min_rating,
                    howmanyrows}, callback, asyncState);
    }
    
    public System.Data.DataSet EndlistRegExp(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((System.Data.DataSet)(results[0]));
    }
    
    public void listRegExpAsync(string keyword, string regexp_substring, int min_rating, int howmanyrows) {
        this.listRegExpAsync(keyword, regexp_substring, min_rating, howmanyrows, null);
    }
    
    public void listRegExpAsync(string keyword, string regexp_substring, int min_rating, int howmanyrows, object userState) {
        if ((this.listRegExpOperationCompleted == null)) {
            this.listRegExpOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistRegExpCompleted);
        }
        this.InvokeAsync("listRegExp", new object[] {
                    keyword,
                    regexp_substring,
                    min_rating,
                    howmanyrows}, this.listRegExpOperationCompleted, userState);
    }
    
    private void OnlistRegExpCompleted(object arg) {
        if ((this.listRegExpCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.listRegExpCompleted(this, new listRegExpCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://regexlib.com/webservices.asmx")]
public partial class RegExpDetails {
    
    private int user_idField;
    
    private int regexp_idField;
    
    private string regular_expressionField;
    
    private string matchesField;
    
    private string not_matchesField;
    
    private string sourceField;
    
    private string descriptionField;
    
    private System.DateTime create_dateField;
    
    private bool disableField;
    
    private int ratingField;
    
    /// <remarks/>
    public int user_id {
        get {
            return this.user_idField;
        }
        set {
            this.user_idField = value;
        }
    }
    
    /// <remarks/>
    public int regexp_id {
        get {
            return this.regexp_idField;
        }
        set {
            this.regexp_idField = value;
        }
    }
    
    /// <remarks/>
    public string regular_expression {
        get {
            return this.regular_expressionField;
        }
        set {
            this.regular_expressionField = value;
        }
    }
    
    /// <remarks/>
    public string matches {
        get {
            return this.matchesField;
        }
        set {
            this.matchesField = value;
        }
    }
    
    /// <remarks/>
    public string not_matches {
        get {
            return this.not_matchesField;
        }
        set {
            this.not_matchesField = value;
        }
    }
    
    /// <remarks/>
    public string source {
        get {
            return this.sourceField;
        }
        set {
            this.sourceField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime create_date {
        get {
            return this.create_dateField;
        }
        set {
            this.create_dateField = value;
        }
    }
    
    /// <remarks/>
    public bool disable {
        get {
            return this.disableField;
        }
        set {
            this.disableField = value;
        }
    }
    
    /// <remarks/>
    public int rating {
        get {
            return this.ratingField;
        }
        set {
            this.ratingField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://regexlib.com/webservices.asmx")]
public partial class Expression : BaseDataObject {
    
    private string authorIdField;
    
    private string authorNameField;
    
    private int providerIdField;
    
    private string titleField;
    
    private string patternField;
    
    private string matchingTextField;
    
    private string nonMatchingTextField;
    
    private bool enabledField;
    
    private int ratingField1;
    
    private string sourceField1;
    
    private string descriptionField1;
    
    /// <remarks/>
    public string AuthorId {
        get {
            return this.authorIdField;
        }
        set {
            this.authorIdField = value;
        }
    }
    
    /// <remarks/>
    public string AuthorName {
        get {
            return this.authorNameField;
        }
        set {
            this.authorNameField = value;
        }
    }
    
    /// <remarks/>
    public int ProviderId {
        get {
            return this.providerIdField;
        }
        set {
            this.providerIdField = value;
        }
    }
    
    /// <remarks/>
    public string Title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    public string Pattern {
        get {
            return this.patternField;
        }
        set {
            this.patternField = value;
        }
    }
    
    /// <remarks/>
    public string MatchingText {
        get {
            return this.matchingTextField;
        }
        set {
            this.matchingTextField = value;
        }
    }
    
    /// <remarks/>
    public string NonMatchingText {
        get {
            return this.nonMatchingTextField;
        }
        set {
            this.nonMatchingTextField = value;
        }
    }
    
    /// <remarks/>
    public bool Enabled {
        get {
            return this.enabledField;
        }
        set {
            this.enabledField = value;
        }
    }
    
    /// <remarks/>
    public int Rating {
        get {
            return this.ratingField1;
        }
        set {
            this.ratingField1 = value;
        }
    }
    
    /// <remarks/>
    public string Source {
        get {
            return this.sourceField1;
        }
        set {
            this.sourceField1 = value;
        }
    }
    
    /// <remarks/>
    public string Description {
        get {
            return this.descriptionField1;
        }
        set {
            this.descriptionField1 = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://regexlib.com/webservices.asmx")]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Expression))]
public partial class BaseDataObject {
    
    private int idField;
    
    private System.DateTime dateCreatedField;
    
    private System.DateTime dateModifiedField;
    
    private bool isDirtyField;
    
    /// <remarks/>
    public int Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime DateCreated {
        get {
            return this.dateCreatedField;
        }
        set {
            this.dateCreatedField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime DateModified {
        get {
            return this.dateModifiedField;
        }
        set {
            this.dateModifiedField = value;
        }
    }
    
    /// <remarks/>
    public bool IsDirty {
        get {
            return this.isDirtyField;
        }
        set {
            this.isDirtyField = value;
        }
    }
}

public partial class getRegExpDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal getRegExpDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public RegExpDetails Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((RegExpDetails)(this.results[0]));
        }
    }
}

public delegate void getRegExpDetailsCompletedEventHandler(object sender, getRegExpDetailsCompletedEventArgs args);

public partial class ListAllAsXmlCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal ListAllAsXmlCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public Expression[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((Expression[])(this.results[0]));
        }
    }
}

public delegate void ListAllAsXmlCompletedEventHandler(object sender, ListAllAsXmlCompletedEventArgs args);

public partial class listRegExpCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal listRegExpCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public System.Data.DataSet Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((System.Data.DataSet)(this.results[0]));
        }
    }
}

public delegate void listRegExpCompletedEventHandler(object sender, listRegExpCompletedEventArgs args);
