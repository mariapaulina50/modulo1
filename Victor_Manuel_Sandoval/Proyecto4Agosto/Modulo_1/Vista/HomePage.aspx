<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Vista.HomePage" %>

<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
      <link href="estilo.css" rel="stylesheet" type="text/css" />
    <title>Home Page</title>
  </head>
  <body class="bg-success">
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
      <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
           <img src="Imagenes/1.jpg" width="200" height="500" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="Imagenes/2.jpg" width="200" height="500" class="d-block w-100" alt="...">
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
      <div class="container col-12">
          <div class="row">
              <div class="col-md-4 text- bg-success text-white">
          <p>
              <h1>Mision</h1>
              Proveer un ambiente divertido y seguro donde los clientes disfruten de buena comida con ingredientes de calidad y a precios accesibles.
          </p>
              </div>
              <div class="col-md-4 text- bg-success text-white">
          <p>
              <h1>Vision</h1>
               Ir hacia un crecimiento rentable y mejorar para servir comida deliciosa a más clientes, cada día y en todo el mundo.
          </p>
                  <img src="Imagenes/empresa.png" width="400" height="300" alt="Alternate Text" />
          </div>
              <div class="col-md-4 text- bg-success text-white">
          <p>
              <h1>Valores</h1>
               Calidad, responsabilidad, unión y mejora. 
          </p>
          </div>
      </div>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
  </body>
</html>
