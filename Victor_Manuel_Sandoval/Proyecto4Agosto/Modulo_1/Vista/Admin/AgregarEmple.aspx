<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarEmple.aspx.cs" Inherits="Vista.Admin.AgregarEmple" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link rel="stylesheet" href="../css/bootstrap.min.css"/>
    <title>Administrar Personas</title>
</head>
<body style="background-image:url('https://besthqwallpapers.com/img/original/39662/box-with-fresh-vegetables-fruit-healthy-food-concepts-tomatoes-cucumbers.jpg'); background-repeat:no-repeat; background-size:cover;">
       <nav class="navbar navbar-expand-lg navbar-light bg-success">
  <a class="navbar-brand text-white" href="MenuAdmin.aspx"> <img src="../Imagenes/Imagen.jpg" width="58" height="60" alt="Alternate Text" /></a>
  <button class="navbar-toggler text-white" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
<div class="btn-group">
  <button type="button" class="btn dropdown-toggle text-white" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
    Ver
  </button>
  <div class="dropdown-menu bg-success">
    <a class="dropdown-item text-white bg-success" href="VerUsu.aspx">Ver usuarios</a>
    <a class="dropdown-item text-white bg-success" href="VerClien.aspx">Ver clientes</a>
    <a class="dropdown-item text-white bg-success" href="VerEmple.aspx">Ver empleados</a>
  </div>
</div>

<div class="btn-group">
  <button type="button" class="btn dropdown-toggle text-white" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
    Agregar
  </button>
  <div class="dropdown-menu bg-success">
    <a class="dropdown-item text-white bg-success" href="AgregarUsu.aspx">Agregar usuarios</a>
    <a class="dropdown-item text-white bg-success" href="AgregarClien.aspx">Agregar clientes</a>
    <a class="dropdown-item text-white bg-success" href="AgregarEmple.aspx">Agregar empleados</a>
  </div>
</div>
        <li class="nav-item">
        <a class="nav-link text-white" href="../HomePage.aspx">Salir</a>
      </li>
    </ul>
  </div>
</nav>
    <form runat="server">
        <div style="margin-top:20px;">
            <center><h1 class="text-white">AGREGAR EMPLEADOS</h1></center>
        </div>
  <div class="container register-form">
                <div class="form-content">
                    <div class="row">
                        <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
                        <div class="card card-signin my-5">
                         <div class="card-body bg-success">
                             <h5 class="card-title text-center text-white">Administrador</h5>
                             <p class="card-text">
                            <div class="form-group">
                                <asp:Label runat="server" class="text-white" Text="N. Documento"></asp:Label>
                        <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label  runat="server" class="text-white" Text="Correo"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                            </div>
                             <div class="form-group">
                               <asp:Label runat="server" class="text-white" Text="Nombre"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" TextMode="SingleLine"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <asp:Label runat="server" class="text-white" Text="Dirección"></asp:Label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label runat="server" class="text-white" Text="Telefono"></asp:Label>
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        <div class="form-group col-md-12">

                        <asp:Button ID="btnGuardar" CssClass="btn btn-secondary btn-block" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />  
                    </div>
                    </div>
                    </div>
                    </div>
                   </div>
                </div>
            </div>
              </form>
</body>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="../js/bootstrap.min.js"></script>
</html>
