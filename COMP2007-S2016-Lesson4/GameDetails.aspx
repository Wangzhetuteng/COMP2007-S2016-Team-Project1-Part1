<%@ Page Title="Game Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameDetails.aspx.cs" Inherits="COMP2007_S2016_Lesson4.GameDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Game Details</h1>
                <h5>All Fiels Are Required</h5>
                <br />
                <div class="form-group">
                    <label class="control-label" for="NameTextBox">Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="NameTextBox" placeholder="Name" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="DescriptionTextBox">Description</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="DescriptionTextBox" placeholder="Description" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="TotalPointsScoredTextBox">Total Points Scored</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="TotalPointsScoredTextBox" placeholder="Total Points Scored" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="NumberofSpectatorsTextBox">Number of Spectators</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="NumberofSpectatorsTextBox" placeholder="Number of Spectators" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="WinningTeamTextBox">Winning Team</label>
                    <asp:TextBox runat="server" CssClass="form-control" id="WinningTeamTextBox" placeholder="Winning Team" required="true"></asp:TextBox>
                </div>
                <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server" 
                        UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click"/>
                    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="SaveButton_Click"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
