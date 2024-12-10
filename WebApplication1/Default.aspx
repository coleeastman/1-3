<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First Web Application</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtInput1" runat="server"></asp:TextBox> +
            <asp:TextBox ID="txtInput2" runat="server"></asp:TextBox> =
            <asp:Label ID="addResult" runat="server" Text="Result "></asp:Label>
            <asp:Button ID="btnAddExe" runat="server" OnClick="btnAdd_Click" Text="Execute Addition" />
            <p />
            <asp:TextBox ID="txtInput3" runat="server"></asp:TextBox> =
            <asp:Label ID="c2fResult" runat="server" Text="Result "></asp:Label> Degrees Fahrenheit
            <asp:Button ID="btnC2fExe" runat="server" OnClick="btnC2f_Click" Text="Execute Celcius to FahrenHeit" />
            <p />
            <asp:TextBox ID="txtInput4" runat="server"></asp:TextBox> =
            <asp:Label ID="f2cResult" runat="server" Text="Result "></asp:Label> Degrees Celcius
            <asp:Button ID="btnF2cExe" runat="server" OnClick="btnF2c_Click" Text="Execute Fahrenheit to Celcius" />
            <p />
            <asp:TextBox ID="txtInput5" runat="server"></asp:TextBox> =
            <asp:Label ID="sortResult" runat="server" Text="Result "></asp:Label>
            <asp:Button ID="btnSortExe" runat="server" OnClick="btnSort_Click" Text="Execute Sort" />
            <p />
        </div>
    </form>
</body>
</html>
