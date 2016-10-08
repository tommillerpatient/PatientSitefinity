<%@ Control %>
<%@ Register Assembly="Telerik.Sitefinity" TagPrefix="sf" Namespace="Telerik.Sitefinity.Web.UI" %>
<%@ Register Assembly="Telerik.Sitefinity" TagPrefix="sitefinity" Namespace="Telerik.Sitefinity.Web.UI" %>
<%@ Register Assembly="Telerik.Sitefinity" TagPrefix="sfFields" Namespace="Telerik.Sitefinity.Web.UI.Fields" %>

<sitefinity:ResourceLinks ID="resourcesLinks" runat="server">
    <sitefinity:ResourceFile Name="Styles/Ajax.css" />
</sitefinity:ResourceLinks>
<div id="designerLayoutRoot" class="sfContentViews sfSingleContentView" style="max-height: 400px; overflow: auto; ">
<ol>        
    <li class="sfFormCtrl">
    <asp:Label runat="server" AssociatedControlID="AuthorizationUrl" CssClass="sfTxtLbl">Authorization Url</asp:Label>
    <asp:TextBox ID="AuthorizationUrl" runat="server" CssClass="sfTxt" />
    <div class="sfExample"></div>
    </li>
    
    <li class="sfFormCtrl">
    <asp:Label runat="server" AssociatedControlID="UnauthorizationUrl" CssClass="sfTxtLbl">Unauthorization Url</asp:Label>
    <asp:TextBox ID="UnauthorizationUrl" runat="server" CssClass="sfTxt" />
    <div class="sfExample"></div>
    </li>
    
</ol>
</div>
