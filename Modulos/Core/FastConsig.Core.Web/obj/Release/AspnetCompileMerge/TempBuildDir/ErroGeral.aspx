<%@ Page Title="" Language="C#" MasterPageFile="~/SecuritylessSite.Master" AutoEventWireup="true" CodeBehind="ErroGeral.aspx.cs" Inherits="FastConsig.Core.Web.ErroGeral" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
   <style>
      #genericerror {
         position: relative;
         height: 89vh;
      }

         #genericerror .genericerror {
            position: absolute;
            left: 50%;
            top: 50%;
            -webkit-transform: translate(-50%, -50%);
            -ms-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
         }

      .genericerror {
         max-width: 710px;
         width: 100%;
         padding-left: 190px;
         line-height: 1.4;
      }

         .genericerror .genericerror-000 {
            position: absolute;
            left: 0;
            top: 0;
            width: 150px;
            height: 150px;
         }

            .genericerror .genericerror-000 h1 {
               font-family: 'Passion One', cursive;
               color: #00b5c3;
               font-size: 150px;
               letter-spacing: 15.5px;
               margin: 0px;
               font-weight: 900;
               position: absolute;
               left: 50%;
               top: 50%;
               -webkit-transform: translate(-50%, -50%);
               -ms-transform: translate(-50%, -50%);
               transform: translate(-50%, -50%);
            }

         .genericerror h2 {
            font-family: 'Raleway', sans-serif;
            color: #292929;
            font-size: 28px;
            font-weight: 700;
            text-transform: uppercase;
            letter-spacing: 2.5px;
            margin-top: 0;
         }

         .genericerror p {
            font-family: 'Raleway', sans-serif;
            font-size: 14px;
            font-weight: 400;
            margin-top: 0;
            margin-bottom: 15px;
            color: #333;
         }

         .genericerror a {
            font-family: 'Raleway', sans-serif;
            font-size: 14px;
            text-decoration: none;
            text-transform: uppercase;
            background: #fff;
            display: inline-block;
            padding: 15px 30px;
            border-radius: 40px;
            color: #292929;
            font-weight: 700;
            -webkit-box-shadow: 0px 4px 15px -5px rgba(0, 0, 0, 0.3);
            box-shadow: 0px 4px 15px -5px rgba(0, 0, 0, 0.3);
            -webkit-transition: 0.2s all;
            transition: 0.2s all;
         }

            .genericerror a:hover {
               color: #fff;
               background-color: #00b5c3;
            }

      @media only screen and (max-width: 480px) {
         .genericerror {
            text-align: center;
         }

            .genericerror .genericerror-000 {
               position: relative;
               width: 100%;
               margin-bottom: 15px;
            }

         .genericerror {
            padding-left: 15px;
            padding-right: 15px;
         }
      }
   </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div class="my-5 pt-sm-5">
      <div class="container">

         <div class="row">
            <div class="col-md-12">
               <div class="text-center">
                  <div>
                     <div class="row justify-content-center">
                        <div class="col-sm-4">
                           <div class="error-img">
                              <img src="/Imagens/500-error.png" alt="" class="img-fluid mx-auto d-block">
                           </div>
                        </div>
                     </div>
                  </div>
                  <h4 class="text-uppercase mt-4">Opss...ocorreu um erro no processmanto da sua requisição</h4>
                  <p class="text-muted">
                     Desculpe-nos, mas as vezes as coisas podem dar errado!<br />
                     Entre em contato com a equipe de suporte técnico do sistema e informe o ocorrido.<br />
                     Preferencialmente informe os passos que foram executados para tornar mais simples a detecção da falaha ocorrida. 
      E com certeza, sua ajuda nos dtalhes terá uma grande colaboração na melhoria do produto.
                  </p>
                  <div class="mt-5">
                     <a class="btn btn-primary waves-effect waves-light" href="/Default.aspx">Página inicial</a>
                  </div>
               </div>

            </div>
         </div>
      </div>
   </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server"></asp:Content>
