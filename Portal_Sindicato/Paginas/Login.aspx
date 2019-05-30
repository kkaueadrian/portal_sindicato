<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Paginas_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title>Login</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="../Resorces/images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../Resorces/vendor/bootstrap/css/bootstrap.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../Resorces/fonts/font-awesome-4.7.0/css/font-awesome.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../Resorces/fonts/Linearicons-Free-v1.0.0/icon-font.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../Resorces/vendor/animate/animate.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="../Resorces/vendor/css-hamburgers/hamburgers.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../Resorces/vendor/animsition/css/animsition.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../Resorces/vendor/select2/select2.min.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="../Resorces/vendor/daterangepicker/daterangepicker.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="../Resorces/css/util.css"/>
	<link rel="stylesheet" type="text/css" href="../Resorces/css/main.css"/>
<!--===============================================================================================-->
</head>
<body>
    
    <div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-50">
    <form id="form1" class="login100-form validate-form" runat="server">
        <div>
            <span class="login100-form-title p-b-33">
						Login
					</span>

            
           
            <div class="wrap-input100 validate-input" data-validate = "Insira o CPF">
            <asp:TextBox ID="txtCpf" runat="server" class="input100" type="text" name="email" placeholder="CPF"></asp:TextBox>
                <span class="focus-input100-1"></span>
				<span class="focus-input100-2"></span>
            </div>
            
            <div class="wrap-input100 rs1 validate-input" data-validate="Insira a senha">
            <asp:TextBox ID="txtSenha" runat="server" class="input100" type="password" name="pass" placeholder="Senha"></asp:TextBox>
                <span class="focus-input100-1"></span>
				<span class="focus-input100-2"></span>
            </div>
            
            <div>
            <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" class="login100-form-btn"/>
            </div>

            <div>
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
            </div>

           
					</div>
				</form>
			</div>
		</div>
	</div>

        <!--===============================================================================================-->
	<script src="../Resorces/vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="../Resorces/vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="../Resorces/vendor/bootstrap/js/popper.js"></script>
	<script src="../Resorces/vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="../Resorces/vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="../Resorces/vendor/daterangepicker/moment.min.js"></script>
	<script src="../Resorces/vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="../Resorces/vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>
    
</body>
</html>
