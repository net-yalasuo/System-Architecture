<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Oxcoder.PersonalChl_qi.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p runat="server" id ="resultMsg"></p>
        <asp:Table ID="classTable" runat="server" CssClass="table table-condensed">
              <asp:TableRow CssClass="">
                  <asp:TableCell><b>ID</b></asp:TableCell>
                  <asp:TableCell><b>Name</b></asp:TableCell>
              </asp:TableRow>
          </asp:Table>
    </div>
    </form>
</body>
</html>
