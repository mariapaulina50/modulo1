<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Vista.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
       <title>Login</title>
</head>
<body style="background-image:url('https://besthqwallpapers.com/img/original/39662/box-with-fresh-vegetables-fruit-healthy-food-concepts-tomatoes-cucumbers.jpg'); background-repeat:no-repeat; background-size:cover;">
    <nav class="navbar navbar-expand-lg navbar-light bg-success">
  <a class="navbar-brand text-white" href="HomePage.aspx"> <img src="Imagenes/Imagen.jpg" width="58" height="60" alt="Alternate Text" /></a>
  <button class="navbar-toggler text-white" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
      <li class="nav-item active">
        <a class="nav-link text-white" href="Login.aspx">Iniciar sesion<span class="sr-only">(current)</span></a>
      </li>
        <li class="nav-item active">
        <a class="nav-link text-white" href="Registrarse.aspx">Registrarse<span class="sr-only">(current)</span></a>
      </li>
    </ul>
  </div>
</nav>
    <div class="container">
        <div class="row">
            <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
                <div class="card card-signin my-5">
                    <div class="card-body bg-success">
                        <h5 class="card-title text-center text-white">Inicio de sesión</h5>
                        <p class="card-text">
                        <form runat="server">
                            <div class="form-group text-white">
                                <asp:Label ID="Label1" runat="server" Text="Correo: "></asp:Label>
                            <asp:TextBox ID="txtcorreo" CssClass="form-control" placeholder="Ingrese su usuario" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group text-white">
                                <asp:Label ID="Label2" runat="server" Text="Contraseña: "></asp:Label>
                                <asp:TextBox ID="txtclave" TextMode="Password" placeholder="Ingrese su contraseña" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group form-check">&nbsp;</div>
                            <asp:Button ID="btnLogin" CssClass="btn btn-lg btn-block text-white bg-dark" runat="server" Text="Enviar" OnClick="btnLogin_Click" />

                            <div class="form-group form-check">&nbsp;</div>
                        
                        </form>
                        </p>
                    </div>
                </div>
            </div>
        </div>        
    </div>
  
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="js/bootstrap.min.js"></script>

</body>
</html>