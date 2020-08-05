<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EscuelaDemo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Listado de Alumnos</h2>
        <div>
            <asp:GridView ID="gvdAlumnos" runat="server" AutoGenerateColumns="false" DataKeyNames="ClaveAlumno" CssClass="table table-striped">
                <Columns>
                    <asp:BoundField DataField="ClaveAlumno" HeaderText="Clave Alumno" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="ApellidoPaterno" HeaderText="Apellido Paterno" />
                    <asp:BoundField DataField="ApellidoMaterno" HeaderText="Apellido Materno" />
                    <asp:BoundField DataField="CorreoElectronico" HeaderText="Correo Electronico" />

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lkbActualizar" runat="server" Text="Actualizar" OnClick="lkbActualizar_Click" CssClass="btn btn-primary"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lkbEliminar" runat="server" Text="Eliminar" OnClick="lkbEliminar_Click" CssClass="btn btn-danger"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <div>
        <asp:Button ID="btnNuevoAlumno" CssClass="btn btn-success btn-lg" runat="server" Text="Nuevo Alumno" OnClick="btnNuevoAlumno_Click" />
    </div>
    <hr />
    <div>
        <asp:Panel ID="pnlAltaAlumno" runat="server" Visible="false" CssClass="table table-striped">
            <div>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="lblApPaterno" runat="server" Text="Apellido Paterno"></asp:Label>
                <asp:TextBox ID="txtApPaterno" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="lblApMaterno" runat="server" Text="Apellido Materno"></asp:Label>
                <asp:TextBox ID="txtApMaterno" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="lblEmail" runat="server" Text="Correo Electronico"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
            <br />
            <asp:Label ID="lblAlumnoId" runat="server" Visible="false"></asp:Label>
            <br />
            <asp:Button ID="btnGuardarAlumno" CssClass="btn btn-success btn-lg" runat="server" Text="Guardar Alumno" OnClick="btnGuardarAlumno_Click" />
            <asp:Button ID="btnActualizar" CssClass="btn btn-warning btn-lg" runat="server" Text="Actualizar Alumno" OnClick="btnActualizar_Click" />
        </asp:Panel>
    </div>


</asp:Content>
