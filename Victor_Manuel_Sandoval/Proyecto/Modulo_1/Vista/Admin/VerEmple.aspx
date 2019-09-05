<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerEmple.aspx.cs" Inherits="Vista.Admin.VerEmple" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" href="../css/bootstrap.min.css" />
    <title>Ver Personas</title>
</head>
<body style="background-image: url('https://besthqwallpapers.com/img/original/39662/box-with-fresh-vegetables-fruit-healthy-food-concepts-tomatoes-cucumbers.jpg'); background-repeat: no-repeat; background-size: cover;">
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-expand-lg navbar-light bg-success">
                <a class="navbar-brand text-white" href="MenuAdmin.aspx">
                    <img src="../Imagenes/Imagen.jpg" width="58" height="60" alt="Alternate Text" /></a>
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
                        </div>
                    </ul>
                </div>
            </nav>
        </div>
        <div>
            <center><h1 class="text-white"</h1>VER EMPLEADOS</center>
            <div class="col-sm-9 col-md-7 col-lg-8 mx-auto">
                <div class="card card-signin my-5">
                    <div class="table-responsive bg-success">
                        <table class="table table-active bg-success">
                            <tr>
                                <td>
                                    <center>
                        <asp:GridView ID="gvEmpleados" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvEmpleados_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="accion" ShowHeader="True" Text="Modificar" />
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView></center>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div id="Modificar" runat="server">
                    <div style="margin-top: 20px;">
                        <center><h1 class="text-white">MODIFICAR EMPLEADOS</h1></center>

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
                                                    <asp:HiddenField ID="hdEmpleadoID" runat="server" />
                                                    <asp:HiddenField ID="hdDocumentoEmpleado" runat="server" />
                                                </div>
                                                <div class="form-group">
                                                    <asp:Label runat="server" class="text-white" Text="Correo"></asp:Label>
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

                                                    <asp:Button ID="btnModificar" CssClass="btn btn-secondary btn-block" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                                                    <asp:Button ID="btnEliminar" CssClass="btn btn-warning btn-block" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                                                    <asp:Button ID="btnCancelar" CssClass="btn btn-danger btn-block" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />

                                                </div>
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

