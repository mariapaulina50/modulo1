<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerPers.aspx.cs" Inherits="Vista.Admin.VerPers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link rel="stylesheet" href="../css/bootstrap.min.css"/>
    <title>Ver Personas</title>
</head>
<body class="bg-dark">
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-expand-lg navbar-light bg-dark">
  <a class="navbar-brand text-white" href="MenuAdmin.aspx"> <img src="../Imagenes/Imagen.jpg" width="58" height="60" alt="Alternate Text" /></a>
  <button class="navbar-toggler text-white" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
   <div class="btn-group">
  <button type="button" class="btn dropdown-toggle text-white" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
    Listado
  </button>
  <div class="dropdown-menu bg-dark">
    <a class="dropdown-item text-white bg-dark" href="VerPers.aspx">Ver usuarios</a>
    <a class="dropdown-item text-white bg-dark" href="AdminPers.aspx">Agregar usuarios</a>
  </div>
</div>
    </ul>
  </div>
</nav>
        </div>
        <div class="bg-dark">
            <center><h1 class="text-white">VER USUARIOS</h1></center>

            <div class="table-responsive bg-dark">
            <table class="table table-active bg-dark">
                <tr>
                    <td><center>
                        <asp:GridView ID="gvPersonas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
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
    </form>
</body>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="../js/bootstrap.min.js"></script>
</html>
