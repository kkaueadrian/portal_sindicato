<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePublicacoes.aspx.cs" Inherits="Paginas_HomePublicacoes" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
  <meta name="description" content=""/>
  <meta name="author" content=""/>
    <link href="../Content/HomePub/css/modern-business.css" rel="stylesheet" />
    <link href="../Content/HomePub/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <title>Home Sindicato</title>
    <style>
        #gv,#repeater{
            float: left;
        }
        #dropped {
            float: none;
        }    

    </style>
</head>
<body>
     <nav class="navbar fixed-top navbar-expand-lg navbar-dark bg-dark fixed-top">
    <div class="container">
      <a class="navbar-brand" href="HomePublicacoes.aspx">Sindicato Rural Lorena e Piquete</a>
      <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarResponsive">
        <ul class="navbar-nav ml-auto">
          <li class="nav-item">
            <a class="nav-link" href="Login.aspx"">Login</a>
          </li>
          </ul>
      </div>
    </div>
  </nav>

    <header>
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
      <ol class="carousel-indicators">
        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
      </ol>
      <div class="carousel-inner" role="listbox">
        <!-- Slide One - Set the background image for this slide in the line below -->
        <div class="carousel-item active" style="background-image: url('http://localhost:54428/Content/HomePub/Imagem/thumb-1920-62836.jpg')">
          <div class="carousel-caption d-none d-md-block">
            <h3>Vaca test</h3>
            <p>This is a description for the first slide.</p>
          </div>
        </div>
        <!-- Slide Two - Set the background image for this slide in the line below -->
        <div class="carousel-item" style="background-image: url('http://localhost:54428/Content/HomePub/Imagem/thumb-1920-366544.jpg')">
          <div class="carousel-caption d-none d-md-block">
            <h3>Second Slide</h3>
            <p>This is a description for the second slide.</p>
          </div>
        </div>
        <!-- Slide Three - Set the background image for this slide in the line below -->
        <div class="carousel-item" style="background-image: url('http://localhost:54428/Content/HomePub/Imagem/pexels-photo-689164.jpeg')">
          <div class="carousel-caption d-none d-md-block">
            <h3>Third Slide</h3>
            <p>This is a description for the third slide.</p>
          </div>
        </div>
      </div>
      <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
      </a>
      <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
      </a>
    </div>
  </header>
    <br />

    <div class="container">
    
        <form id="form1" runat="server">
        <div>
   
           
   
            <h2>Lista de Publicações</h2>
   
        <br />
      
            
        </div>
            <div class="row">
<div class="col-lg-9" id="repeater">
          
       <asp:Repeater ID="rptPublicacoes" runat="server" OnItemCommand="Repeater1_ItemCommand" >
       <ItemTemplate>
           <div class="col-lg-8 col-sm-6 portfolio-item"> 
       <div class="card h-100">
          <asp:Image ID="Image1" runat="server" ImageUrl='<%#"../Upload/" + Eval("pub_imagem") %>' class="card-img-top" width="500px" />
          <div class="card-body">
           <p class="card-text">
                <asp:Label ID="lblDescricao" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "pub_descricao")%>'></asp:Label></p>
          </div>
        </div>
      </div>
       </ItemTemplate>
       </asp:Repeater>

</div>
   
           

            <br />

            <div class="col-lg-3" id="gv">
            
            <asp:GridView ID="gvPublicacao" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvPublicacao_RowDataBound" >
               
                <Columns>
                    <asp:BoundField HeaderText="Imagem"/>
                    <asp:BoundField DataField="pub_endereco" HeaderText="Endereço" />
                    <asp:BoundField DataField="pub_descricao" HeaderText="Descrição" />
                    <asp:BoundField DataField="pub_tipo" HeaderText="Tipo" />
                </Columns>
            </asp:GridView>
       
                 
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
            </div>
                </div>

            <div class="row">
      <div class="col-lg-6" id="dropped">
        <h2>Modern Business Features</h2>
        <p>The Modern Business template by Start Bootstrap includes:</p>
        <ul>
          <li>
            <strong>Bootstrap v4</strong>
          </li>
          <li>jQuery</li>
          <li>Font Awesome</li>
          <li>Working contact form with validation</li>
          <li>Unstyled page elements for easy customization</li>
        </ul>
        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Corporis, omnis doloremque non cum id reprehenderit, quisquam totam aspernatur tempora minima unde aliquid ea culpa sunt. Reiciendis quia dolorum ducimus unde.</p>
      </div>
      <div class="col-lg-6">
        <img class="img-fluid rounded" src="http://placehold.it/700x450" alt=""/>
      </div>
    </div>
            </form>
      <div class="row mb-4">
      <div class="col-md-8">
        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Molestias, expedita, saepe, vero rerum deleniti beatae veniam harum neque nemo praesentium cum alias asperiores commodi.</p>
      </div>
      <div class="col-md-4">
        <a class="btn btn-lg btn-secondary btn-block" href="#">Ir ao topo da pagina</a>
      </div>
    </div>

   <footer class="py-5 bg-dark">
    <div class="container">
      <p class="m-0 text-center text-white">Copyright &copy; Your Website 2019</p>
        
    </div>
    <!-- /.container -->
  </footer>
</div>
        <!-- Bootstrap core JavaScript -->
    <script src="../Content/HomePub/vendor/jquery/jquery.min.js"></script>
    <script src="../Content/HomePub/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
       
        <asp:Label ID="lblMensagem2" runat="server" Text="Label"></asp:Label>
        
       
    
        
</body>
</html>
