<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerUsu.aspx.cs" Inherits="Vista.Admin.VerUsu" %>

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
                </div>
        </div>
        <div>
            <center><h1 class="text-white"</h1>VER USUARIOS</center>
            <div class="col-sm-9 col-md-7 col-lg-4 mx-auto">
                <div class="card card-signin my-5">
                    <div class="table-responsive bg-success">
                        <table class="table table-active bg-success">
                            <tr>
                                <td>
                                    <center>
                        <asp:GridView ID="gvUsuarios" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="accion" ShowHeader="True" Text="Ver" />
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
            </div>
        </div>
    </form>
</body>
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="../js/bootstrap.min.js"></script>
</html>

