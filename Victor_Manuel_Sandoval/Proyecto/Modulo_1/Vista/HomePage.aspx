﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Vista.HomePage" %>

<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <title>Home Page</title>
  </head>
  <body>
    <nav class="navbar navbar-expand-lg navbar-light bg-dark">
  <a class="navbar-brand text-white" href=""> <img src="Imagenes/Imagen.jpg" width="58" height="60" alt="Alternate Text" /></a>
  <button class="navbar-toggler text-white" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
      <li class="nav-item active">
        <a class="nav-link text-white" href="Login.aspx">Iniciar Sesion<span class="sr-only">(current)</span></a>
      </li>
    </ul>
  </div>
</nav>
      <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="https://s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2018/05/02101555/comida-saludable.jpg" width="800" height="500" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="https://i.pinimg.com/originals/33/cb/7c/33cb7c366d3115523fcd9123aaaa2ce1.jpg" width="800" height="500" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="http://elestimulo.com/bienmesabe/wp-content/uploads/sites/7/2017/02/comida-sana.jpg" width="800" height="500" class="d-block w-100" alt="...">
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
              <div class="col-md-6 bg-dark text-white">
          <p>Como hemos comentado anteriormente, una dieta poco saludable puede llevar a una persona a sufrir obesidad, lo que puede hacer aumentar el riesgo de padecer cáncer.
              Un estudio del año 2014 desveló que una dieta rica en frutas reducía las posibilidades de sufrir cáncer en el tracto gastrointestinal superior y también, que ingerir una gran cantidad de fibra disminuía el riesgo de cáncer de hígado y de cáncer colorrectal.
              Además, muchos de los fitoquímicos que encontramos en los vegetales y en las legumbres actúan como antioxidantes, lo que protege a las células del daño que puede causar el cáncer. Algunos de estos antioxidantes son los betacarotenos, el licopeno y vitaminas A, C y E.
          </p>
                  </div>
              <div class="col-md-6 bg-dark text-white">
                  <p>
                      <img src="https://www.gastronomiami.com/wp-content/uploads/2019/03/04_meeting-of-chefs.jpg" width="500" height="250" alt="Alternate Text" /><br />
                  Nuestros chefs estan a la espera de complecer sus necesidades.</p>
              </div>
              </div>
      </div>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
  </body>
</html>