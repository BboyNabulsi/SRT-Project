<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SrtSplitter.aspx.cs" Inherits="SRT_Project.SrtSplitter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FU1" runat="server" /><br />
            <asp:TextBox runat="server" TextMode="MultiLine" ID="TxtEn" Height="100px"></asp:TextBox>
            <asp:TextBox runat="server" TextMode="MultiLine" ID="TxtAr" Height="100px"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="BtnRead" OnClick="BtnRead_Click" Text="Show" />

        </div>
    </form>
</body>
</html>
