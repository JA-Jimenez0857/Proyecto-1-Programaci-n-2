<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web_Calculator.aspx.cs" Inherits="WebCalculator_repaso_02_11.Web_Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculadora_Web</title>
    <link rel="stylesheet" type="text/css" href="Estilo.css" />
</head>
<body>
    <form id="Calculadora" runat="server">
        <div>
            <h1>Calculadora Web</h1>
            <br />
            <br />
            <asp:Button ID="b1" Text="1" CssClass="button" runat="server" OnClick="b1_Click" />
            <asp:Button ID="b2" Text="2" CssClass="button" runat="server" OnClick="b2_Click" />
            <asp:Button ID="b3" Text="3" CssClass="button" runat="server" OnClick="b3_Click" />
            &nbsp;&nbsp;
             <asp:Button ID="bpot2" Text="^2" CssClass="button" runat="server" OnClick="bpot2_Click" />
             <asp:Button ID="bpot3" Text="^3" CssClass="button" runat="server" OnClick="bpot3_Click" />
             <asp:Button ID="braiz" Text="√" CssClass="button" runat="server" OnClick="braiz_Click" />
        </div>
        <div >
            <asp:Button ID="b4" Text="4" CssClass="button" runat="server" OnClick="b4_Click" />
            <asp:Button ID="b5" Text="5" CssClass="button" runat="server" OnClick="b5_Click" />
            <asp:Button ID="b6" Text="6" CssClass="button" runat="server" OnClick="b6_Click" />
        &nbsp;&nbsp; <asp:Button ID="bmulti" Text="x" CssClass="button" runat="server" OnClick="bmulti_Click" />
            <asp:Button ID="bdiv" Text="÷" CssClass="button" runat="server" OnClick="bdiv_Click" />
             &nbsp;<asp:Button ID="bfact" Text="n!" CssClass="button" runat="server" OnClick="bfact_Click" />
        </div>
        <div >
            <asp:Button ID="b7" Text="7" CssClass="button" runat="server" OnClick="b7_Click" />
            <asp:Button ID="b8" Text="8" CssClass="button" runat="server" OnClick="b8_Click" />
            <asp:Button ID="b9" Text="9" CssClass="button" runat="server" OnClick="b9_Click" />
            &nbsp;&nbsp; <asp:Button ID="bsuma" Text="+" CssClass="button" runat="server" OnClick="bsuma_Click" />
            <asp:Button ID="bresta" Text="-" CssClass="button" runat="server" OnClick="bresta_Click" />
            &nbsp;<asp:Button ID="bfibon" Text="Φ" CssClass="button" runat="server" OnClick="bfibon_Click" />
        </div>
         <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="b0" Text="0" CssClass="button" runat="server" OnClick="b0_Click" />
            <asp:Button ID="bcom" Text="," CssClass="button" runat="server" OnClick="bcom_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="bclear" CssClass="button" Text="C" runat="server" OnClick="bclear_Click" />
            <asp:Button ID="bequal" CssClass="button" Text="=" runat="server" OnClick="bequal_Click" />
             <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
            <br />
            <div>
            <label>Numero 1: </label>
            <asp:TextBox ID="Tvalor1" runat="server"></asp:TextBox>
            <br />
            <label>Numero 2: </label>
            <asp:TextBox ID="Tvalor2" runat="server"></asp:TextBox>
                <br />
                <br />
            <asp:Label ID="lresultado" runat="server" Text="Resultado: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Oper" runat="server" Text="Operación seleccionada: "></asp:Label>
            <br />
            <asp:RadioButton ID="rsuma" GroupName="Operador" Text="Suma" runat="server" />
            <br />
            <asp:RadioButton ID="rresta" GroupName="Operador" Text="Resta" runat="server" />
            <br />
            <asp:RadioButton ID="rmulti" GroupName="Operador" Text="Multiplicacion" runat="server" />
            <br />
            <asp:RadioButton ID="rdivision" GroupName="Operador" Text="Division" runat="server" />
            <br />
            <asp:RadioButton ID="Pot2" GroupName="Operador" Text="Potencia 2" runat="server" />
            <br />
            <asp:RadioButton ID="Pot3" GroupName="Operador" Text="Potencia 3" runat="server" />
            <br />
            <asp:RadioButton ID="RaizCu" GroupName="Operador" Text="Raiz Cuadrada" runat="server" />
            <br />
            <asp:RadioButton ID="Facto" GroupName="Operador" Text="Factorial" runat="server" />
            <br />
            <asp:RadioButton ID="Fibon" GroupName="Operador" Text="Fibonacci" runat="server" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
