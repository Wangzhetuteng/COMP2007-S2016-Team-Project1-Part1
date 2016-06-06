<%@ Page Title="Students" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="COMP2007_S2016_Lesson4.About1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <h1>Student List</h1>
                <asp:GridView runat="server" CssClass="table table-bordered table-striped table-hover" 
                    ID="StudentsGridView" AutoGenerateCollumns="false">
                    <Columns>
                                       
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

</asp:Content>
