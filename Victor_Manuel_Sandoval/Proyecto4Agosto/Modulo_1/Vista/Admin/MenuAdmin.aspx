﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuAdmin.aspx.cs" Inherits="Vista.MenuAdmin" %>

<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <title>Admin</title>
  </head>
  <body class="bg-success">
    <nav class="navbar navbar-expand-lg navbar-light bg-success">
  <a class="navbar-brand text-white" href="MenuAdmin.aspx"> <img src="../Imagenes/Imagen.jpg" width="58" height="60" alt="Alternate Text" /></a>
  <button class="navbar-toggler text-white" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
      <!-- Example single danger button -->
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
      <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
           <img src="../Imagenes/1.jpg" width="200" height="500" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="../Imagenes/2.jpg" width="200" height="500" class="d-block w-100" alt="...">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>


    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
  </body>
</html>