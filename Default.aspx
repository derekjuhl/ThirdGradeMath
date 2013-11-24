<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>math time</title>
    <link href="BasicMath.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Math Play Time</h1>
        <p>
        <asp:Button ID="getNumbers" runat="server" Text="+" OnClick="addition_Click" />
        <asp:Button ID="btnDivision" runat="server" Text="/" OnClick="btnDivision_Click" />
         
            
        </p>
        <p>
            <asp:Label ID="lblNumber1" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblOperator" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblNumber2" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="="></asp:Label>
            <asp:TextBox ID="txtUserAnswer" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtRemainder" runat="server"></asp:TextBox>
            </p>
        <p>
            <asp:Button ID="btnCheckAnswer" runat="server" Text="Check Answer" OnClick="btnCheckAnswer_Click" />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </p>

    </div>
    </form>
</body>
</html>

