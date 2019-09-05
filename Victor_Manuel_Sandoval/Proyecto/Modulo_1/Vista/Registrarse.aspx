<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Vista.Registrarse" %>

<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script> 

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link href="estilo.css" rel="stylesheet" type="text/css" />
    <title>Registro</title>
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
      <div class="container register-form">
          <form runat="server">
            <div class="form">
                <div class="form-content">
                    <div class="row">
                        <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
                        <div class="card card-signin my-5">
                         <div class="card-body bg-success">
                             <h5 class="card-title text-center text-white">Registro</h5>
                             <p class="card-text">
                            <div class="form-group">
                                <asp:Label runat="server" class="text-white" Text="Numero de documento"></asp:Label>
                        <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" TextMode="Number" required></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label  runat="server" class="text-white" Text="Correo"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" required></asp:TextBox>
                            </div>
                             <div class="form-group">
                               <asp:Label runat="server" class="text-white" Text="Nombre"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <asp:Label runat="server" class="text-white" Text="Dirección"></asp:Label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label runat="server" class="text-white" Text="Telefono"></asp:Label>
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                            </div>
                        <div class="form-group col-md-12">

                        <asp:Button ID="btnGuardar1" CssClass="btn btn-secondary btn-block" runat="server" Text="Guardar" OnClick="btnGuardar1_Click" />  
                    </div>
                    </div>
                    </div>
                    </div>
                   </div>
                </div>
            </div>
              </form>
        </div>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
  </body>
</html>