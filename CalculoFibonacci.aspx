<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculoFibonacci.aspx.cs" Inherits="SequenciaFibonacci.CalculoFibonacci" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sequência Fibonacci</title>

    <link rel="stylesheet" href="StylesCSS/EstilosGeraisPaginaInicial.css"/>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Verificar Sequência de Fibonacci</h2>
            <label for="txtNumero">Informe um número:</label>
            <asp:TextBox ID="txtNumero" runat="server" onkeypress="return isNumberKey(event)" onkeyup="validateInput(this)"></asp:TextBox>
            <br />
            <span id="errorMsgTXT" style="color: red; display: none; font-size: 14px;">Insira um número válido.</span>
            <br />
            <br />
            <asp:Button ID="btnVerificar" runat="server" OnClick="btnVerificar_Click" ToolTip="Verificar" CssClass="btn-Verificar" />
            <asp:Button ID="btnLimpar" runat="server" OnClick="btnLimpar_Click" ToolTip="Apagar" CssClass="btn-Limpar" />
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        </div>
    </form>

    <script src="ScriptsJS/ApenasNumerosTextBox.js"></script>

</body>
</html>
