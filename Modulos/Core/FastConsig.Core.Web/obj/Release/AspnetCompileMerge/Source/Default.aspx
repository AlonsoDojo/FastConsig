<%@ Page Title="FastConsig" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FastConsig.Core.Web._Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .panel-nomargim {
            margin-right: 0;
            margin-left: 0;
            padding-left: 0;
            padding-right: 0;
        }
        .panel-invisible {
            background-color: transparent;
            -moz-box-shadow: none;
            -webkit-box-shadow: none;
            box-shadow: none;
        }
        .feed-title > span {
            font-weight: 300;
            font-size: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <!-- Main content -->
    <div class="main-content">

        <div class="row">
            <div class="col-lg-12 panel-nomargim">
                <div class="panel panel-invisible panel-nomargim">

                </div>
            </div>
        </div>

    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContent" runat="server"></asp:Content>
