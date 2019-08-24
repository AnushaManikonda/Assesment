<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication6.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="https://code.jquery.com/jquery-1.4.1.min.js"></script>
    <script src="JScript1.js" type="text/javascript"></script>

</head>
<body>
  <form id="form1" runat="server">
  enter the id:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
  <br />
  <br />
  <button id="Button1" onclick="geting();" type="button">
      user
    </button>



    <br />
  <br />
  enter the page size<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
  <br />
  enter the page no.<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
  <br />
  <br />



    <button id="Button3" onclick="get();" type="button">
      usersss
    </button>
    <p id="showData">
    </p>
    <!--<asp:Label ID="Label1" runat="server" Text="Enter the page no"></asp:Label>
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
       <br />
       <br />
       <asp:Label ID="Label2" runat="server" Text="Enter the page size"></asp:Label>
       <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
       <br />
       <br />
       <button id="btnHello" type="button" onclick="hello();">List User</button>
      <p id=""></p>-->


        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" DataKeyNames="Id" DataSourceID="SqlDataSource1" 
            GridLines="Vertical" AllowPaging="True" AllowSorting="True">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" 
                    SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" 
                    SortExpression="LastName" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Country" HeaderText="Country" 
                    SortExpression="Country" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:WebApplication6.Properties.Settings.Setting %>" 
            SelectCommand="SELECT * FROM [Customer]"></asp:SqlDataSource>
  
  <p>
  </p>
  <p>
   <!--   <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Button" />-->
  </p>
    </form>
        
</body>
</html>
