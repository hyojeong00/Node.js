<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="prac3.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row owl-height">
            <img src="imgs/welding.png"/ height="50px">
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-6 center-block">
                <div class="row">
                    
                </div>
                <div class="row">
                    <div class="col">
                        <center>
                                    <h3>Admin Login</h3>
                                </center>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <hr>
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <label>ID</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                        </div>
                        <label>Password</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="Button1" CssClass="btn btn-success btn-block btn-lg" runat="server" Text="Login" />
                        </div>
                    </div>
                </div>


            </div>
        </div>
    </div>
</asp:Content>
