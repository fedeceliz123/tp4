<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="StagePro.Ingreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Login.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.1/css/all.css" >
    <title></title>
</head>
<body  style="background-image:url('./Imagenes/fondologin.png');  background-repeat: no-repeat; background-size: 100% 100%; height: 100vh;
    width: 100%;" >
    <form runat="server">
        <div class="container-fluid fondo">
            
            

        

             <div class="formulario">
                    <h3 class="log-text">Login</h3>

                    <div class="input-group mb-3 tamano">
                        <asp:TextBox ID="TextBox1" runat="server" type="text" CssClass="form-control" placeholder="Usuario"></asp:TextBox>
                        <%--<asp:TextBox   aria-label="Example text with button addon" aria-describedby="button-addon1" />--%>
                    </div>
                    <div class="input-group mb-3 tamano">
                        <asp:TextBox ID="TextBox2" runat="server" type="password" class="form-control" placeholder="Contraseña"></asp:TextBox >
<%--                         <input type="password" class="form-control" placeholder="Contraseña" aria-label="Example text with button addon" aria-describedby="button-addon1" />--%>
                        <button class="btn btn-primary" type="button" id="button-addon1"><i class="fas fa-eye"></i></button>
                    </div>
                    <div>
                        <a  class="link-log">Recuperar Clave</a>
                    </div>
                    <div>
                        <a class="btn btn-primary m-4" >Ingresar</a>
                        <a class="btn btn-secondary bg-dark" >Cancelar</a>
                    </div>
            </div>
             

        </div>
        </form>
    
</body>
</html>
