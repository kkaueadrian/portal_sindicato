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
    <link href="../Content/Cadastro%20CSS/GridViewCSS.css" rel="stylesheet" />
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
        <div class="carousel-item active" style="  background-image: url(http://localhost:54428/Content/HomePub/Imagem/c5d98a49-18ab-4a99-8cd7-12dcefe9012c.jpg)">
          <div class="carousel-caption d-none d-md-block">
            <h3>Faça sua visita ao Sindicato Rural de Lorena</h3>
            <p>Discrição</p>
          </div>
        </div>
        <!-- Slide Two - Set the background image for this slide in the line below -->
        <div class="carousel-item" style=" background-image: url(http://localhost:54428/Content/HomePub/Imagem/17c50e60-7eb0-45f8-84f2-4b961f58a64f.jpg)">
          <div class="carousel-caption d-none d-md-block">
            <h3 style="color:black;">Da União Nasce a Força! </h3>
            <p>Discrição</p>
          </div>
        </div>
        <!-- Slide Three - Set the background image for this slide in the line below -->
        <div class="carousel-item" style="  background-image: url(http://localhost:54428/Content/HomePub/Imagem/ato-declaratório-executivo.jpg)">
          <div class="carousel-caption d-none d-md-block">
            <h3>Acesso para o prudutor rural </h3>
            <p>Discrição</p>
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
   
           
   
            <h2>Publicações</h2>
   
        <br />
      
            
        </div>
            <div class="row">
<div class="col-md-9 sm-12" id="repeater">
          
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

            <div class="col-md-3 sm-12" id="gv">
            
            <asp:GridView ID="gvPublicacao" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvPublicacao_RowDataBound" Width="350px" AllowPaging="true" PageSize="8"  CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr" >
               
                <Columns>
                    <asp:BoundField HeaderText="Imagem"/>
                    <asp:BoundField DataField="pub_endereco" HeaderText="Endereço" />
                    <asp:BoundField DataField="pub_descricao" HeaderText="Descrição" />
                    
                </Columns>
            </asp:GridView>
       
                 
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
            </div>
                </div>
            <br />
             <br />
            <div class="row">
      <div class="col-lg-6" id="dropped">
        <h2>Contato e Localização</h2>
        
        <ul>
          <li>
            <strong>Telefone: (12) 3153-1743</strong>
          </li>
          <li><strong>Celular: (12) 98207-0651</strong></li>
          <li><strong>Horário de atendimento: 7:00h ás 17:00h de Segunda a Sexta.</strong></li>
         
          
        </ul>
          <h2>Sobre o Sindicato Rural de Lorena e Piquete</h2>
        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Corporis, omnis doloremque non cum id reprehenderit,<br /> quisquam totam aspernatur tempora minima unde aliquid ea culpa sunt. Reiciendis quia dolorum ducimus unde.
            Corporis, omnis doloremque non cum id reprehenderit, quisquam totam <br />aspernatur tempora minima unde aliquid ea culpa sunt.
            Corporis, omnis doloremque non cum id reprehenderit, omnis doloremque non cum id reprehenderit.
      </div>
      <div class="col-lg-6">
        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d709.3948418495987!2d-45.12438504320183!3d-22.73250085434636!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ccc8e91a1cc0b3%3A0xfcdb67289262cada!2sR.+Dom+B%C3%B4sco%2C+78+-+Centro%2C+Lorena+-+SP%2C+12600-100!5e0!3m2!1spt-BR!2sbr!4v1559331962468!5m2!1spt-BR!2sbr" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>
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
